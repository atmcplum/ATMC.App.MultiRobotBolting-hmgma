using Abeo.Controls;
using Abeo.Controls.ZeroCode;
using ATMC.Common;
using LotusAPI;
using LotusAPI.Controls;
using LotusAPI.Controls.Dialogs;
using LotusAPI.Controls.Graph;
using LotusAPI.HW;
using LotusAPI.Math;
using LotusAPI.MV;
using LotusAPI.Robotics;
using LotusAPI.Robotics.Hyundai;
using LotusAPI.Robotics.Kawasaki;
using LotusAPI.Robotics.Yaskawa;
using LotusAPI.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Img = LotusAPI.MV.Image;

namespace ATMC.App.MultiRobotBolting {
    public partial class FormMain : Form {
        bool _isBusy = false;         //Program is busy (inspecting, collecting data...)
        ThreadSafeFlag _cycleStarted = new ThreadSafeFlag(false);
        ModelConfig _crrModel = null;
        Result _crrResult = null;
        TicToc _cycleTimer = new TicToc();

        //AUTO MANUAL
        bool _isAuto = false;
        internal bool IsAuto => _isAuto;
        internal bool IsManual => !_isAuto;

        void BInvoke(Action a) {
            try {
                if(this.InvokeRequired) BeginInvoke(a); else a();
            } catch(Exception ex) { Logger.Error(ex.Message); Logger.Trace(ex.StackTrace); }
        }

        //StateMachine<State> _sm = null;
        SerialTaskQueue _tq = new SerialTaskQueue("Main TaskQueue");

        public FormMain() {
            //TODO: Setup registry in Program.cs
            InitializeComponent();
            this.Enabled = false;

            Global.InitGlobalSetting();

            //Setup logviewer
            Logger.Add(new LogViewLogger(logview));
            reslog.InitLogView();

            logfileWatcher.LogDirectory = Global.LogDir;
            //Clear logview when log file changed
            logfileWatcher.LogFileChangedEvent += LogfileWatcher_LogFileChangedEvent;
            //Start log file watcher
            logfileWatcher.Start();

            //Init lotus API library
            Library.Initialize();

            //TODO: Initialization
            Global.Init();

            //Init DB views
            InitDB();

            //TODO: Init  HARDWARE
            InitHW();

            //When user type this password, open Localization setting screen
            LotusAPI.Dialogs.DialogLogin.AddAction(
                Registry.GetStringValue("LocalizationPassword", "atmc1111"),
                delegate { if(TypeUtils.ShowTypeEditorDialog(false)) Global.Localize(); });

            LotusAPI.Dialogs.DialogLogin.AddAction("abeo", delegate { statusbar.ShowRunningGirl ^= true; });

            Global.MainForm = this;
        }

        private void LogfileWatcher_LogFileChangedEvent() {
            try {
                logview.Clear();
                Logger.Log("Clearing history files...");
                LotusAPI.IOUtils.RemoveHistoryFolders(Global.ResultDir + "/OK", Global.Setting.HistoryDayCount);
                LotusAPI.IOUtils.RemoveHistoryFiles(Global.LogDir, Global.Setting.HistoryDayCount);
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }

        internal void UpdateGUI() {
            tabbar.STAT_Button.Visible = Global.Setting.ShowStatPanel;
            statusbar.StatusItems.Items = "PLC\n"
                + (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner0 ? "" : "SCANNER0|S0\n")
                + (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner1 ? "" : "SCANNER1|S1\n")
                + (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner2 ? "" : "SCANNER2|S2\n")
                + (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner3 ? "" : "SCANNER3|S3\n")
                + (Global.Setting.EnableR0 ? "ROBOT0|R0\n" : "")
                + (Global.Setting.EnableR1 ? "ROBOT1|R1\n" : "")
                + (Global.Setting.EnableR2 ? "ROBOT2|R2\n" : "")
                + (Global.Setting.EnableR3 ? "ROBOT3|R3\n" : "");
        }

        //Init GUI related stuff once the Form is loaded
        private void FormMain_Load(object sender, EventArgs e) {
            vc.Init("3DView");

            UpdateGUI();
            //update status
            UpdateHwStatus();
            //
            UpdateCounter();
            //try to set auto
            SetAuto();
            //Visibility
            UpdateVisionPass();
            //Goto home view
            tabbar.GoHome();
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e) { Global.Terminate(); }


        void UpdateCounter() => reslog.UpdateDataView(DB.Query, Global.ResetTime, new string[] { "ID", "DATE", "MODEL", "BODY_NO", "SEQ_NO", "RESULT" }, 10);

        void InitDB() {
            try {
                //statview
                statview.Query = DB.Query;
                statview.ModelColumnName = DB.COL.MODEL.ToString();
                //dbview
                Global.DB.InitView(dbView);
                reslog.SetResultColorMap(DB.GetColorMaps());
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }


        //Initialize harware
        void InitHW() {
            try {
#if USE_PLC
                InitPLC();
#endif

#if USE_ROBOT
                InitRobot();
#endif
                InitScanners();

                UpdateHwStatus();

            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

#if USE_ROBOT
        private void InitRobot() {
            //try {
            //    for(int i = 0; i < Global.ROBOT_COUNT; i++) {
            //        Global.Robots[i].RobotDisconnectedEvent += delegate { UpdateHwStatus(); };
            //        Global.Robots[i].RobotConnectedEvent += delegate { UpdateHwStatus(); };
            //    }
            //} catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }
#endif

        private void InitScanners() {
            try {
                foreach(var scanner in Global.Scanners) {
                    if(scanner == null) continue;
                    scanner.ConnectedEvent -= FormMain_ScannerConDisconEventHandler;
                    scanner.DisconnectedEvent -= FormMain_ScannerConDisconEventHandler;
                    scanner.ConnectedEvent += FormMain_ScannerConDisconEventHandler;
                    scanner.DisconnectedEvent += FormMain_ScannerConDisconEventHandler;
                }
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }
        private void FormMain_ScannerConDisconEventHandler(AbeoScan sender) { UpdateHwStatus(); }

#if USE_PLC
        private void InitPLC() {
            try {
                //PLC connected
                Global.PlcMan.Plc.ConnectedEvent += delegate { UpdateHwStatus(); };

                //PLC disconnected
                Global.PlcMan.Plc.DisconnectedEvent += delegate { UpdateHwStatus(); };

                //memory block changed
                Global.PlcMan.Plc.MemoryBlockChangedEvent += Plc_MemoryBlockChangedEvent;
                //Bit changed
                Global.PlcMan.Plc.BitChangedEvent += Plc_BitChangedEvent;

                Global.PlcMan.Plc.Setting.PropertyChangedEvent += Setting_PropertyChangedEvent;

                if(Global.Setting.PCRUN == PCRUNMethod.MemoryBlock)
                    Global.PlcMan.PCRUNChangedEvent += PlcMan_PCRUNChangedEvent;

                UpdatePinMap();

                ThreadUtils.DelayExecute(delegate {
                    BInvoke(delegate { ReconnectPLC(); });
                }, 3000);

            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        public void ReconnectPLC() {
            try {
                Global.PlcMan.Reconnect();
                Global.PlcMan.EnablePCRUN = true;
                UpdateHwStatus();
            } catch(Exception ex) { Logger.Error(ex.Message); Logger.Trace(ex.StackTrace); }
        }
        private void PlcMan_PCRUNChangedEvent(object sender, bool value) {
            BInvoke(delegate {
                try {
                    var pin = Global.PlcMan.Plc.PinMap.GetOutputPin(Global.OutputPin.PCRUN);
                    if(pin != null) reslog.IOMap.UpdatePin(pin, value);
                } catch { }
            });
        }

        void UpdatePinMap() { reslog.SetPinMap(Global.PlcMan.Plc.PinMap); }


        private void Setting_PropertyChangedEvent(object sender, LotusAPI.Settings.Property e) {
            try {

                if(e.Name == "PinMap") {
                    UpdatePinMap();
                }
                ReconnectPLC();
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        //PLC bit changed
        private void Plc_BitChangedEvent(LotusAPI.HW.PinInfo pin, bool old_value, bool new_value) {
            BInvoke(delegate {
                try {
                    reslog.IOMap.UpdatePin(pin, new_value);
                    if(pin.Name == "--" || pin.Name == "N/A" || pin.Name == "__NOPIN__" || pin.Name == "PCRUN") return;
                    Logger.Log($"PLC.{pin.Function}.{pin.Name} = {new_value}");

                    if (pin.Name.EndsWith("_PASS")) {

                        if (new_value) {
                            if (pin.Name == "VISION0_PASS") Global.Setting.ScannerPass.Value = ScannerConfigEnum.Scanner0;
                            else if (pin.Name == "VISION1_PASS") Global.Setting.ScannerPass.Value = ScannerConfigEnum.Scanner1;
                            else if (pin.Name == "VISION2_PASS") Global.Setting.ScannerPass.Value = ScannerConfigEnum.Scanner2;
                            else if (pin.Name == "VISION3_PASS") Global.Setting.ScannerPass.Value = ScannerConfigEnum.Scanner3;
                        }
                        //else { Global.Setting.ScannerPass.Value = ScannerConfigEnum.None; } 0패스일때 혹시나 1패스 해제를 0패스가 꺼져버리는 경우
                        else {
                            if (pin.Name == "VISION0_PASS" && Global.Setting.ScannerPass.Value.Equals(ScannerConfigEnum.Scanner0))
                                Global.Setting.ScannerPass.Value = ScannerConfigEnum.None;
                            else if (pin.Name == "VISION1_PASS" && Global.Setting.ScannerPass.Value.Equals(ScannerConfigEnum.Scanner1))
                                Global.Setting.ScannerPass.Value = ScannerConfigEnum.None;
                            else if (pin.Name == "VISION2_PASS" && Global.Setting.ScannerPass.Value.Equals(ScannerConfigEnum.Scanner2))
                                Global.Setting.ScannerPass.Value = ScannerConfigEnum.None;
                            else if (pin.Name == "VISION3_PASS" && Global.Setting.ScannerPass.Value.Equals(ScannerConfigEnum.Scanner3))
                                Global.Setting.ScannerPass.Value = ScannerConfigEnum.None;
                        }

                        Global.PlcMan.WriteDOBit(pin.Name, new_value);

                        UpdateHwStatus();
                        UpdateVisionPass();
                    }

                    if (pin.Function == LotusAPI.HW.PinFunc.DI && new_value && IsAuto) {
                        ProcessInputSignal(pin.Name);
                    }
                } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
            });
        }

        //PLC Memory block changed
        private void Plc_MemoryBlockChangedEvent(LotusAPI.HW.IPLC.MemoryBlock block) {
            //try {
            //    if(block.Name == "PCRUN") return;
            //    Logger.Log($"BlockChanged: [{block.Name}] = {block.ToString()}");
            //} catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

#endif
        //Update all hardware status
        void UpdateHwStatus() => BInvoke(delegate {
            List<object> skip_objs = new List<object>();
            if (!Global.Setting.EnableR0) skip_objs.Add(Global.Robots[0]);
            if (!Global.Setting.EnableR1) skip_objs.Add(Global.Robots[1]);
            if (!Global.Setting.EnableR2) skip_objs.Add(Global.Robots[2]);
            if (!Global.Setting.EnableR3) skip_objs.Add(Global.Robots[3]);
            if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner0) skip_objs.Add(Global.Scanners[0]);
            if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner1) skip_objs.Add(Global.Scanners[1]);
            if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner2) skip_objs.Add(Global.Scanners[2]);
            if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner3) skip_objs.Add(Global.Scanners[3]);
            ATMC.Common.Utils.UpdateHwStatus(statusbar, Global.Setting.ShowHwErrAlarm, skip_objs.ToArray(), Global.PlcMan, Global.Robots, Global.Scanners);
        });

        bool CanAuto {
            get {
                //TODO: check all auto condition
                return true;
            }
        }

        void SetAuto() {
            try {
                //If cannot go to auto mode -> go to manual mode
                if(!CanAuto) {
                    SetManual();
                    throw new Exception("Failed to set AUTO mode, please check hardware connection.");
                }

                _isAuto = true;
                titlebar.Auto = true;
                statusbar.StripeMotionEnable = true;
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        void SetManual() {
            try {
                //IF system is busy, we cant go to MANUAL
                if(IsAuto && _isBusy) throw new Exception("Failed to set MANUAL mode, program is BUSY!");
                _isAuto = false;
                titlebar.Auto = false;
                statusbar.StripeMotionEnable = false;
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        private void titlebar_AutoManualDoubleClickEvent(object sender, EventArgs e) {
            if(DialogUtils.AskForPermission() == false) return;
            if(IsAuto) { SetManual(); }
            else if(IsManual) { SetAuto(); }
        }

        private void btSettings_Click(object sender, EventArgs e) {
            if(DialogUtils.AskForPermission()) {
                (new FormSetting(IsAuto)).ShowDialog();
            }
        }
        internal void UpdateVisionPass() {
            //if (SimPLC_UpdateVisionPass()) return;
            BInvoke(delegate {
                try {
                    int bypassCnt = 0;

                    if (Global.PlcMan.GetDIBit("VISION0_PASS")) bypassCnt++;
                    if (Global.PlcMan.GetDIBit("VISION1_PASS")) bypassCnt++;
                    if (Global.PlcMan.GetDIBit("VISION2_PASS")) bypassCnt++;
                    if (Global.PlcMan.GetDIBit("VISION3_PASS")) bypassCnt++;

                    Logger.Log($"[Status] Bypass Count: {bypassCnt}");
                }
                catch (Exception ex) {
                    LotusAPI.Logger.Error(ex.Message);
                }
            });
        }


        private void tabbar_DB_CheckedEvent(object sender, EventArgs e) { if(tabbar.DB_Button.Checked) dbView.Update(); }
        private void tabbar_STAT_CheckedEvent(object sender, EventArgs e) { if(tabbar.STAT_Button.Checked) statview.Update(); }

#if USE_SCANNER
        public void TestScan(int idx) {
            try {
                var cloud = Global.Scanners[idx].Scan();
                var pcv = vc.GetPCV();
                pcv.Clear();
                pcv.Add(cloud, Color.Gray);
                pcv.Render();
                string file = DialogUtils.ShowSavePlyFileDialog();
                if(file == "") return;
                GObject.WritePLY(file, cloud);
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        string ScannerID(int idx) => $"SCANNER{idx}";

        public void ConnectScanner(int idx) {
            try {
                //scanner already connected and we are in manual mode -> test scan
                if(Global.Scanners[idx] != null && Global.Scanners[idx].IsConnected && IsManual) TestScan(idx);
                //connect
                else if(Global.Scanners[idx] == null || !Global.Scanners[idx].IsConnected) {
                    Global.Scanners.Connect(idx, Global.Setting.ScannerProfile);
                }
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
            UpdateHwStatus();
        }
#endif

        //When double click on item
        private void statusbar_ItemDoubleClickedEvent(object sender,
            Abeo.Controls.ZeroCode.StatusItemPanel.Item item) {
            try {
#if USE_PLC
                if(item.Name.StartsWith("PLC")) {
                    ReconnectPLC();
                }
#endif

#if USE_SCANNER
                if(item.Name.StartsWith("SCANNER")) {
                    ConnectScanner(int.Parse(item.Name.Substring("SCANNER".Length)));
                }
#endif

#if USE_ROBOT
                if(item.Name.StartsWith("ROBOT")) {
                    ConnectRobot(int.Parse(item.Name.Substring("ROBOT".Length)));
                }
#endif

                UpdateHwStatus();

            } catch(Exception ex) {
                Logger.Error(ex.Message);
                Logger.Debug(ex.StackTrace);
            }
        }

        //Manual double click on DO
        private void iomap_ItemDoubleClickEvent(LotusAPI.HW.PinFunc func, string name) {
            try {
                if (name == "--") return;
                //if (SimPLC_DoubleClick(func, name)) return;
                if (IsAuto && ModifierKeys != Keys.Control)
                    throw new Exception("Manual signal is disabled in AUTO mode. Try CTRL+DoubleClick");
                Logger.Log($"[MANUAL] PLC.{func} =  {name}");
                if (func == LotusAPI.HW.PinFunc.DI) {
                    ProcessInputSignal(name);
                }
                else if (func == LotusAPI.HW.PinFunc.DO) {
                    Global.PlcMan.ToggleDOBit(name);
                }
            }
            catch (Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        void AssertCycleStarted() { if(!_cycleStarted) throw new Exception("Cycle has not been started."); }

        #region Actions
        void Do_RESET() {
            try {
                //Save result if not saved
                if(_cycleStarted && _crrResult != null) SaveResult();

                _cycleStarted.Set(false);
                _crrModel = null;
                _crrResult = null;
                //Reset PLC output
                //Global.PlcMan.ClearDO();
                Global.PlcMan.WriteDOBit(Global.OutputPin.OK, false);
                Global.PlcMan.WriteDOBit(Global.OutputPin.NG, false);
                Global.PlcMan.WriteDOBit(Global.OutputPin.HW_ERR, false);
                //SimPLC_RESET();

                if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner0) {
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION0_PASS, true);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION1_PASS, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION2_PASS, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION3_PASS, false);
                }
                else if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner1) {
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION0_PASS, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION1_PASS, true);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION2_PASS, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION3_PASS, false);
                }
                else if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner2) {
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION0_PASS, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION1_PASS, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION2_PASS, true);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION3_PASS, false);
                }
                else if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner3) {
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION0_PASS, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION1_PASS, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION2_PASS, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION3_PASS, true);
                }
                else {
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION0_PASS, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION1_PASS, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION2_PASS, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.VISION3_PASS, false);
                }

                //Clear display
                BInvoke(delegate {
                    vc.Reset();
                    tabbar.ResetValue();
                    vc.ShiftOffset.Reset();
                });

                if (Global.Setting.ReconnectRobotOnRESET) {
                    //connect all robot and check hw 
                    try {
                        for (int i = 0; i < Global.ROBOT_COUNT; i++) {
                            bool data_ok = false;
                            for (int try_id = 0; try_id <= Global.Setting.ReconnectRobotCount; try_id++) {
                                var robot = Global.Robots[i];
                                robot.Disconnect();
                                robot.Connect();
                                if (robot.IsConnected) data_ok = true;
                                if (data_ok) break;
                                Logger.Warn($"Failed to send data to robot [{i}] (try={try_id})");
                                Task.Delay(200).Wait();
                            }
                        }
                    }
                    catch (Exception ex) { Logger.Error(ex.Message); Logger.Trace(ex.StackTrace); }
                    UpdateHwStatus();
                }
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }


        void ReadWorkCycleInfo() {
            try {
                var res = _crrResult;
                //read car type -> prepare current model
                {
                    int model_number = Global.PlcMan.ReadBlockInt16(Global.PlcBlock.CAR_TYPE, 0);
                    SetCurrentModel(model_number);
                }

                AssertCurrentModelResult();
                res = _crrResult;
                //read  body no
                {
                    string body_no = Global.PlcMan.ReadBlockUserString(Global.PlcBlock.BODY_NO);
                    BInvoke(delegate { tabbar.SetBodyNo(body_no); });
                    res.BodyNo = body_no;
                }

                //cmt no
                {
                    var seq_no = Global.PlcMan.ReadBlockUserString(Global.PlcBlock.SEQ_NO);
                    BInvoke(delegate { tabbar.SetSeqNo(seq_no); });
                    res.SeqNo = seq_no;
                }
            } catch(Exception ex) {
                LotusAPI.Logger.Error(ex.Message);
                LotusAPI.Logger.Debug(ex.StackTrace);
            }
        }
        /// <summary>
        /// GetDIBit -> Count current DI Signals -> bypassCount++
        /// </summary>
        void Do_START() {
            try {
                if(_cycleStarted) { Logger.Warn("Cycle has already started."); return; }
                if (IsAuto) ReadWorkCycleInfo();
                //if (SimPLC_START()) return;
                int bypassCount = 0;
                try {
                    if (Global.PlcMan.GetDIBit("VISION0_PASS")) bypassCount++;
                    if (Global.PlcMan.GetDIBit("VISION1_PASS")) bypassCount++;
                    if (Global.PlcMan.GetDIBit("VISION2_PASS")) bypassCount++;
                    if (Global.PlcMan.GetDIBit("VISION3_PASS")) bypassCount++;
                }
                catch (Exception ex) {
                    Logger.Error($"[ERROR] Failed to read DI signal: {ex.Message}");
                }

                if (bypassCount >= 2) {
                    Logger.Error($"[ERROR] Forcing NG: Multiple BYPASS signals ({bypassCount}) are active. CHECK PLC SETTINGS");

                    Global.PlcMan.WriteDOBit(Global.OutputPin.NG, true);
                    if (_crrResult != null) _crrResult.OK = false; // for the SaveResult, must be here

                    UpdateHwStatus();
                    UpdateVisionPass();
                    return;
                }

                //TODO: Start cycle
                Logger.Info("Starting cycle...");

                //Start cycle timer
                _cycleTimer.Tic();
                //Reconnect robot on start
                UpdateHwStatus();

                AssertCurrentModelResult();

                //mark cycle started
                _cycleStarted.Set(true);

            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        void Do_SCAN() => Do_SCAN(false);
        void Do_MANUAL_LOAD() => Do_SCAN(true);
        void Do_SCAN(bool manual_load) {
            try {
                //reset PLC Output
                if(!manual_load) {
                    //Global.PlcMan.ClearDO(); 
                    Global.PlcMan.WriteDOBit(Global.OutputPin.OK, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.NG, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.HW_ERR, false);

                    //if (Global.Setting.ScannerPass.Value == ScannerConfigEnum.Scanner0) 오류뜨면 .Value 넣기
                    if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner0) {
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION0_PASS, true);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION1_PASS, false);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION2_PASS, false);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION3_PASS, false);
                    }
                    //else if (Global.Setting.ScannerPass.Value == ScannerConfigEnum.Scanner1)
                    else if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner1) {
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION0_PASS, false);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION1_PASS, true);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION2_PASS, false);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION3_PASS, false);
                    }
                    //else if (Global.Setting.ScannerPass.Value == ScannerConfigEnum.Scanner2)
                    else if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner2) {
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION0_PASS, false);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION1_PASS, false);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION2_PASS, true);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION3_PASS, false);
                    }
                    //else if (Global.Setting.ScannerPass.Value == ScannerConfigEnum.Scanner3)
                    else if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner3) {
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION0_PASS, false);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION1_PASS, false);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION2_PASS, false);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION3_PASS, true);
                    }
                    else {
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION0_PASS, false);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION1_PASS, false);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION2_PASS, false);
                        Global.PlcMan.WriteDOBit(Global.OutputPin.VISION3_PASS, false);
                    }
                }

                AssertCurrentModelResult();
                var m = _crrModel;
                var r = _crrResult;
                var reg = m.Registration;

                Pointcloud scene_cc = null;
                Img[] scene_imgs = null;
                for(int try_id = 0; try_id < Global.Setting.TryCount; try_id++) {
                    RobotPoseEx[] poses = null;
                    if(manual_load) {
                        scene_cc = new Pointcloud(LotusAPI.DialogUtils.OpenPLYFile("Open scene file"));
                    }
                    else {
                        scene_cc = MyUtils.Scan(reg.ScanPoses, out poses, out scene_imgs);
                    }
                    if(scene_cc == null) {
                        Logger.Warn($"Failed to scan => RETRY ({try_id})");
                        BInvoke(delegate { UpdateHwStatus(); });
                        continue;
                    }

                    //align in CC, dont check limit because we are not in UF
                    if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner0) {
                        r.RegistationResult = m.Align(scene_cc, reg.Model_WithOutS0, true, true, false);
                    }
                    else if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner1) {
                        r.RegistationResult = m.Align(scene_cc, reg.Model_WithOutS1, true, true, false);
                    }
                    else if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner2) {
                        r.RegistationResult = m.Align(scene_cc, reg.Model_WithOutS2, true, true, false);
                    }
                    else if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner3) {
                        r.RegistationResult = m.Align(scene_cc, reg.Model_WithOutS3, true, true, false);
                    }
                    else {
                        r.RegistationResult = m.Registration.Align(scene_cc, true, true, false);
                    }
                    
                    r.RegistationResult.SceneImgs = scene_imgs;

                    r.OK = r.RegistationResult.OK;

                    r.TryCount = try_id + 1;

                    if(r.OK || manual_load) break;
                    Logger.Warn($"Failed to align => RETRY ({try_id})");
                }

                Logger.Log("TryCount: " + r.TryCount);

                //result matrix is CC align
                //we need compute shift in UF before display, since all robot share same UF we use hand-eye 0
                var he = Global.HandEyes[0];
                var H_uf = he.CC2UF(r.RegistationResult.Matrix);
                //check limit and set result OK
                r.RegistationResult.LimitOK = reg.ShiftLimit.IsInLimit(H_uf);
                r.OK = r.RegistationResult.OK;

                //DISPLAY here because when testing robot & PLC may not be available
                BInvoke(delegate {
                    r.RegistationResult.SetView(vc, reg);
                    vc.SetShift(H_uf, reg.ShiftLimit);

                    //display cad model
                    GObject cad_model = null;
                    if(reg.CadModel != null) {
                        cad_model = reg.CadModel.Clone() as GObject;
                        cad_model.Matrix = r.RegistationResult.Matrix;
                        cad_model.ApplyTransform();
                    }

                    //3D view
                    var pcv = vc.GetPCV();
                    pcv.Clear();
                    pcv.Add(cad_model, Color.FromArgb(Global.Setting.CadModelOpacity, Color.Gray));
                    pcv.Add(r.RegistationResult.Scene, Color.Yellow);
                    pcv.Add(r.RegistationResult.Aligned, r.OK ? Color.Lime : Color.Red);
                    pcv.DrawCoordinate("", he.UFMatrix, 300);
                    pcv.DrawCoordinate("UF", he.UFMatrix * H_uf, 300);
                    pcv.Render();
                });

                //Dont continue in manual load mode
                if(manual_load) return;

                bool data_ok = true;
                if(r.OK) {
                    //make shift data
                    H_uf = m.Registration.ShiftOffset.ApplyShift(H_uf);
                    int uf_id = Global.Setting.UF;

                    //assume data ok
                    data_ok = true;
                    for(int i = 0; i < Global.ROBOT_COUNT; i++) {
                        if(!Global.EnableR(i)) continue;
                        bool data_i_ok = false;
                        for(int try_id = 0; try_id <= Global.Setting.DataSendTryCount; try_id++) {
                            var robot = Global.Robots[i];
                            if(!robot.IsConnected) robot.Connect();

                            if(robot.IsYaskawa()) {
                                int var_idx = Global.Setting.UFVarIdx;
                                data_i_ok = Global.Robots[i].SendUFData_Yaskawa(H_uf, var_idx, uf_id);
                            }
                            else if(robot.IsKawasaki()) {
                                data_i_ok = Global.Robots[i].SendBaseShiftData_Kawasaki(Global.HandEyes[i].UF2Base(H_uf), uf_id);
                            }
                            else if(robot.IsHyundai()) {
                                int var_idx = Global.Setting.UFVarIdx;
                                data_i_ok = Global.Robots[i].SendUFData_Hyundai(H_uf, var_idx);
                            }
                            else throw new Exception($"Robot type = ({Global.Setting.RobotType.Value}) is not supported!");

                            if(data_i_ok) break;

                            Logger.Warn($"Failed to send data to robot [{i}] (try={try_id})");
                            Task.Delay(200).Wait();
                        }
                        data_ok = data_ok && data_i_ok;
                    }
                }

                bool res_ok = r.OK && data_ok;

                //Now the data is sent to ROBOT, we then set SCAN_OK
                //SCAN_OK signal serves as the DATA_OK trigger
                Global.PlcMan.WriteDOBit(Global.OutputPin.OK, res_ok);
                Global.PlcMan.WriteDOBit(Global.OutputPin.NG, !res_ok);
                //Break out

            } catch(Exception ex) {
                LotusAPI.Logger.Error(ex.Message);
                LotusAPI.Logger.Debug(ex.StackTrace);
                if(!manual_load) {
                    BInvoke(delegate { UpdateHwStatus(); });
                    Global.PlcMan.WriteDOBit(Global.OutputPin.OK, false);
                    Global.PlcMan.WriteDOBit(Global.OutputPin.NG, true);
                }
            }
        }
        void SaveResult() {
            try {
                AssertCurrentModelResult();
                var res = _crrResult;
                res.SaveDB();

                BInvoke(delegate {
                    UpdateCounter();
                    res.ScreenShot = ControlUtils.GetScreenCrop(this);
                    Task.Run(() => res.Save());
                });
            } catch(Exception ex) { Logger.Error(ex.Message); Logger.Trace(ex.StackTrace); }
        }

        void Do_END() {
            try {
                AssertCycleStarted();
                _cycleStarted.Set(false);
                SaveResult();
                Logger.Log($"CT = {(_cycleTimer.Elapsed / 1000).ToString("F3")} s");
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        #endregion

        //!MAIN IO SIGNAL PROCESSING FUNCTION
        void ProcessInputSignal(string signal_name) {
            try {
                //TODO: Other manual signal, eg: M_<MODEL>...
                if(signal_name.StartsWith("M_")) {
                    SetCurrentModel(signal_name.Substring(2));
                    return;
                }

                Global.InputPin key = (Global.InputPin)Enum.Parse(typeof(Global.InputPin), signal_name);

                switch(key) {
                    case Global.InputPin.RESET: _tq.Enqueue(Do_RESET); break;
                    case Global.InputPin.START: _tq.Enqueue(Do_START); break;
                    case Global.InputPin.SCAN: _tq.Enqueue(Do_SCAN); break;
                    case Global.InputPin.MANUAL_LOAD: Do_MANUAL_LOAD(); break;
                    case Global.InputPin.END: _tq.Enqueue(Do_END); break;
                        //TODO: SCAN SIGNAL
                }

            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }


        void DisplayModel(ModelConfig model) {
            BInvoke(delegate {
                try {
                    vc.SetOffset(model.Registration.ShiftOffset);
                    tabbar.SetModel(model.Name);
                    var pcv = vc.GetPCV();
                    pcv.Clear();
                    if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner0) {
                        pcv.Add(model.Registration.Model_WithOutS0, Color.Yellow);
                    }
                    else if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner1) {
                        pcv.Add(model.Registration.Model_WithOutS1, Color.Yellow);
                    }
                    else if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner2) {
                        pcv.Add(model.Registration.Model_WithOutS2, Color.Yellow);
                    }
                    else if (Global.Setting.ScannerPass == ScannerConfigEnum.Scanner3) {
                        pcv.Add(model.Registration.Model_WithOutS3, Color.Yellow);
                    }
                    else {
                        pcv.Add(model.Registration.Model, Color.Yellow);
                    }
                    pcv.Add(model.Registration.CadModel, Color.FromArgb(Global.Setting.CadModelOpacity, Color.Gray));
                    pcv.DrawCoordinate("UF", Global.HandEyes[0].UFMatrix, 300);
                    pcv.Render();
                } catch(Exception ex) {
                    Logger.Error(ex.Message);
                    Logger.Trace(ex.StackTrace);
                }
            });

        }
        //!Set current model by name
        // When setting the pin map, model must be prefixed with M_, eg. M_RG3, M_KI...
        void SetCurrentModel(string model_name) {
            try {
                Logger.Log($"Setting current model = {model_name}...");
                _crrModel = Global.Models.Find(x => x.Name == model_name);
                AssertModel();
                Logger.Log($"CurrentModel = {_crrModel.Name}");
                _crrResult = _crrModel.CreateResult();
                DisplayModel(_crrModel);
            } catch(Exception ex) {
                Logger.Error(ex.Message);
                Logger.Trace(ex.StackTrace);
            }
        }

        void SetCurrentModel(int model_number) {
            try {
                Logger.Log($"Setting current model number= {model_number}...");
                _crrModel = Global.Models.Find(x => x.Match(model_number));
                AssertModel();
                Logger.Log($"CurrentModel = {_crrModel.Name}");
                _crrResult = _crrModel.CreateResult();
                var model = _crrModel;
                DisplayModel(_crrModel);
            } catch(Exception ex) {
                Logger.Error(ex.Message);
                Logger.Trace(ex.StackTrace);
            }
        }

        private void AssertModel() {
            if(_crrModel == null) throw new Exception("Current model is NULL");
        }

        private void AssertResult() {
            if(_crrResult == null) throw new Exception("Current result is NULL");
        }

        private void AssertCurrentModelResult() {
            AssertModel(); AssertResult();
        }

#if USE_ROBOT
        string RobotID(int idx) => $"ROBOT{idx}";

        public void ConnectRobot(int idx) {
            try {
                //connect
                if(!Global.Robots[idx].IsConnected) {
                    Global.Robots[idx].Connect();
                }
            } catch(Exception ex) {
                Logger.Error(ex.Message);
                Logger.Debug(ex.StackTrace);
            }
            UpdateHwStatus();
        }
#endif

        private void shiftOffset_ShiftButtonClickEvent(object sender, EventArgs e) {
            (new FormOffsetLimitEditor(_crrModel == null ? "" : _crrModel.Name)).ShowDialog();
        }

        //double click on cycle info will show make model panel
        private void cycleInfo_DoubleClick(object sender, EventArgs e) { if(IsAuto) return; (new FormMakeModel()).ShowDialog(); }
        private void dbView_DataRowDoubleClickEventEx(object sender, DataRow selected_row, int col_id) { FormImageView.Show(selected_row[DB.COL.RESULT_DIR.ToString()].ToString(), "*.jpg"); }
        private void titlebar_HelpButtonClickEvent(object sender, EventArgs e) { FormHelpView.Show("help.txt", ""); }
        private void dgv_LastResult_DataRowDoubleClickEvent(object sender, DataRow selected_row) {
            try {
                string query = $"SELECT RESULT_DIR FROM RESULT WHERE ID={selected_row["ID"]} AND MODEL='{selected_row["MODEL"]}' AND BODY_NO='{selected_row["BODY_NO"]}'";
                var result = Global.DB.ExecuteQuery(query);
                FormImageView.Show(result.Rows[0]["RESULT_DIR"].ToString(), "*.jpg");
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }
    }
}
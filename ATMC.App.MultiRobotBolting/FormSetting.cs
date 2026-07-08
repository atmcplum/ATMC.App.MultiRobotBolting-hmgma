using LotusAPI;
using LotusAPI.HW;
using System;
using System.Windows.Forms;

namespace ATMC.App.MultiRobotBolting {
    public partial class FormSetting : Form {
        bool _auto = false;
        public FormSetting(bool auto) {
            _auto = auto;
            InitializeComponent();

            modelList.SetObjectList(Global.Models);
            modelList.LoadButtonVisible = false;
            modelList.SaveButtonVisible = true;
            modelList.PropertyVisible = true;

            modelList.Path = Global.ModelSettingFile;

            //go to general tab
            btGeneral.Checked = false;
            btGeneral.Checked = true;
            pgrid.SelectedObject = Global.Setting;

            UpdateButtons();
            Global.Setting.PropertyChangedEvent += Setting_PropertyChangedEvent;
        }

        private void Setting_PropertyChangedEvent(object sender, LotusAPI.Settings.Property e) {
            if(e.Name == Global.Setting.EnableR0.Name ||
                e.Name == Global.Setting.EnableR1.Name ||
                e.Name == Global.Setting.EnableR2.Name ||
                e.Name == Global.Setting.EnableR3.Name ||
                e.Name == Global.Setting.ShowHandEyeConfigPanel.Name) {
                UpdateButtons();
            }
        }
        void UpdateButtons() {
            bt_HandEye.Visible = !_auto && Global.Setting.ShowHandEyeConfigPanel;
            bt_R0.Visible = !_auto && Global.Setting.EnableR0;
            bt_R1.Visible = !_auto && Global.Setting.EnableR1;
            bt_R2.Visible = !_auto && Global.Setting.EnableR2;
            bt_R3.Visible = !_auto && Global.Setting.EnableR3;
            handEyeConfigView1.SetupButtons();
        }

        private void btGeneral_CheckedChanged(object sender, EventArgs e) {
            try {
                if(sender == btGeneral) pgrid.SelectedObject = Global.Setting;
#if USE_PLC
                else if(sender == btPLC) {
                    pgrid.SelectedObject = Global.PlcMan.Plc.Setting;
                    PinInfo.PinNames = Global.PinNames;
                    IPLC.MemoryBlock.BlockNames = Global.PlcBlockNames;
                }
#endif

#if USE_ROBOT
                else if(sender == bt_R0) {
                    pgrid.SelectedObject = Global.Robots[0].Setting;
                }
                else if(sender == bt_R1) {
                    pgrid.SelectedObject = Global.Robots[1].Setting;
                }
                else if(sender == bt_R2) {
                    pgrid.SelectedObject = Global.Robots[2].Setting;
                }
                else if(sender == bt_R3) {
                    pgrid.SelectedObject = Global.Robots[3].Setting;
                }
#endif
                else if(sender == bt_HandEye) {
                    handEyeConfigView1.SetupButtons();
                    if(DialogUtils.AskForPermission() == false) btGeneral.Checked = true;
                }
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }


        private void modelList_AfterSaveEvent(object sender, EventArgs e) {
            Global.LoadModels();
            modelList.SetObjectList(Global.Models);
        }

    }
}

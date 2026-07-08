using ATMC.Common;
using LotusAPI;
using LotusAPI.Controls.Editors;
using LotusAPI.Settings;
using System;

namespace ATMC.App.MultiRobotBolting {
    //TODO: Define application settings
    public enum ScannerConfigEnum {
        None,
        Scanner0,
        Scanner1,
        Scanner2,
        Scanner3
    }

    public class MySetting : SettingObject {
        //GENERALS
        public Property_<string> Language { get; } = new Property_<string>("ko", "GENERAL", WriteProtectionType.AskForPermission);
        public Property_<string> ResultDir { get; } = new Property_<string>("D:/Results", "GENERAL", typeof(DirectoryLocationEditor), WriteProtectionType.AskForPermission);
        public Property_<int> HistoryDayCount { get; } = new Property_<int>(90, "GENERAL", WriteProtectionType.AskForPermission);
        public Property_<int> CloudDisplayStep { get; } = new Property_<int>(7, "DISPLAY");
        public Property_<int> CadModelOpacity { get; } = new Property_<int>(50, "DISPLAY");
        public Property_<string> ScannerProfile { get; } = new Property_<string>("Default", "SCANNER", WriteProtectionType.AskForPermission);
        public Property_<int> TryCount { get; } = new Property_<int>(2, "SCANNER", WriteProtectionType.AskForPermission);
        public Property_<string> DBServerAddress { get; } = new Property_<string>("localhost", "DB", WriteProtectionType.AskForPermission);
        public Property_<int> MinPointCount { get; } = new Property_<int>(10000, "SCANNER", WriteProtectionType.AskForPermission);

        public Property_<bool> ShowStatPanel { get; } = new Property_<bool>(false, "GENERAL");
        public Property_<bool> ShowHandEyeConfigPanel { get; } = new Property_<bool>(false, "GENERAL");
        public Property_<bool> ShowHwErrAlarm { get; } = new Property_<bool>(false, "GENERAL");

        public Property_<RobotTypeEnum> RobotType { get; } = new Property_<RobotTypeEnum>(RobotTypeEnum.Huyndai, "ROBOT", WriteProtectionType.AskForPermission);
        public Property_<bool> EnableR0 { get; } = new Property_<bool>(true, "ROBOT", WriteProtectionType.AskForPermission);
        public Property_<bool> EnableR1 { get; } = new Property_<bool>(true, "ROBOT", WriteProtectionType.AskForPermission);
        public Property_<bool> EnableR2 { get; } = new Property_<bool>(true, "ROBOT", WriteProtectionType.AskForPermission);
        public Property_<bool> EnableR3 { get; } = new Property_<bool>(true, "ROBOT", WriteProtectionType.AskForPermission);

        public Property_<int> UF { get; } = new Property_<int>(6, "ROBOT", WriteProtectionType.AskForPermission);
        public Property_<int> UFVarIdx { get; } = new Property_<int>(11, "ROBOT", WriteProtectionType.AskForPermission);
        public Property_<int> DataSendTryCount { get; } = new Property_<int>(3, "ROBOT", WriteProtectionType.AskForPermission);
        public Property_<bool> ReconnectRobotOnRESET { get; } = new Property_<bool>(true, "ROBOT", WriteProtectionType.AskForPermission);
        public Property_<int> ReconnectRobotCount { get; } = new Property_<int>(3, "ROBOT", WriteProtectionType.AskForPermission);
        internal Property_<ScannerConfigEnum> ScannerPass { get; set; } = new Property_<ScannerConfigEnum>(ScannerConfigEnum.None, "SCANNER", WriteProtectionType.AskForPermission);

        public Property_<PlcTypeEnum> PlcType { get; } = new Property_<PlcTypeEnum>(PlcTypeEnum.Melsec, "PLC", WriteProtectionType.AskForPermission);
        //Sometime user want to use a separate memory block only for PCRUN
        public Property_<PCRUNMethod> PCRUN { get; } = new Property_<PCRUNMethod>(PCRUNMethod.OutputBit, "PLC", WriteProtectionType.AskForPermission);

        //PROFILERS
        public MySetting() : base() {
            this.PropertyChangedEvent += MySetting_PropertyChangedEvent;
        }

        private void MySetting_PropertyChangedEvent(object sender, Property e) {
            //when setting changed, do something...
            try {
                Global.MainForm.UpdateGUI();
                if(e.Name == "PlcType" || e.Name == "RobotType") {
                    Logger.Fatal("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Logger.Fatal("!!! Please restart the program to apply changes. !!!");
                    Logger.Fatal("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    DialogUtils.ShowInfoMsg("!!! Please restart the program to apply changes. !!!");
                }

                if(e.Name == "PCRUN") {
                    Global.PlcMan.PCRUNMethod = PCRUN;
                }

            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }
    }
}

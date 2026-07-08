using Abeo.Controls;
using LotusAPI;
using LotusAPI.HW;
using LotusAPI.Robotics;
using LotusAPI.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ATMC.App.MultiRobotBolting {
    //TODO: Declare global variables and settings here as static
    internal static partial class Global {
        //Setting files
        // Directory structure:
        // Application executable directory\
        //   |-> ProductName\
        //   |    |-> setting.json   //general settings
        //   |    |-> daq.json       //daq settings
        //   |    |-> plc.json       //plc settings
        //   |    |-> robot.json     //robot settings
        //   |    |-> scanner.json   //scanner settings
        //   |    |-> camera.json    //camera settings
        //   |    |-> Language\      //language directory (automatic)
        //   |    |    |-> ko\      
        //   |    |    |     |-> Profiles\      
        //   |    |    |     |     |-> User defined profiles\      


        //We are using directly the application directory to store local settings
        //Software back-up is then simply performed by zipping the entired app folder
        public static string SettingDir = $"./{Application.ProductName}.Settings";
        public static string GeneralSettingFile => SettingDir + "/setting.json";
        public static string UFImageFile => SettingDir + "/uf.png";
        public static string ResultDir => Global.Setting.ResultDir;
        public static string LogDir => ResultDir + "/Logs";

        public static string ResetTime = "03:00";
        public static Color ColorOK = NiceColor.Emerald;
        public static Color ColorNG = NiceColor.Alizarin;
        public static Color ColorConnected = NiceColor.Emerald;
        public static Color ColorDisconnected = NiceColor.Alizarin;
        //ENVIRONMENT VARS
        //General settings
        public static MySetting Setting = new MySetting();
        public static FormMain MainForm = null;

        //====================================================================================================
        #region MODEL
        //Models
        public static string ModelSettingFile => SettingDir + "/model.json";
        public static List<ModelConfig> Models = new List<ModelConfig>();

        //Extra model initialization
        static void InitModels() {
            try {
                Models?.ForEach(x => x.Init());
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        public static void LoadModels() {
            try {
                Logger.Info("Loading models...");
                Models = JsonUtils.Read<List<ModelConfig>>(Json.ReadFromFile(ModelSettingFile)) ?? new List<ModelConfig>();
                InitModels();
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        public static void SaveModels() {
            try {
                if(DialogUtils.AskForPermission()) {
                    Logger.Info($"Saving model to {ModelSettingFile}...");
                    JsonUtils.ToJson(Models).Save(ModelSettingFile);
                    DialogUtils.ShowInfoMsg($"Model saved! ({ModelSettingFile})");
                    InitModels();
                }
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }
        #endregion

        //====================================================================================================
        #region DATABASE
        //Database
        public static string DbFile => SettingDir + "/database.db";
        public static DB DB = new DB();
        public static void InitDB() {
            try {
                DB.Connect();
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }
        #endregion


        //================================================================================
        #region LOCALIZATION
        public static MessageText MsgTxt = new MessageText();
        public static ErrorText ErrTxt = new ErrorText();
        public static DBText DbTxt = new DBText();
        public static string LanguageDir => SettingDir + "/Language";
        public static string CurrentLanguageDir => LanguageDir + "/" + Setting.Language;
        public static void Localize() {
            try {
                //SETTING
                TypeUtils.LoadTypeInfo(CurrentLanguageDir);

                Setting.Localize();
#if USE_PLC
                PlcMan.Plc.Setting.Localize();
#endif 

#if USE_ROBOT
                for(int i = 0; i < Global.ROBOT_COUNT; i++) {
                    Robots[i].Setting.Localize();
                }
#endif
                TypeUtils.SetPropertyInfo_<ModelConfig>();
                TypeUtils.SetPropertyInfo_<PinInfo>();
                TypeUtils.SetPropertyInfo_<IPLC.MemoryBlock>();

                MsgTxt = TypeUtils.GetStringResource_<MessageText>();
                ErrTxt = TypeUtils.GetStringResource_<ErrorText>();
                DbTxt = TypeUtils.GetStringResource_<DBText>();

                TypeUtils.SaveTypeInfo(CurrentLanguageDir);
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }
        #endregion


        public static void InitGlobalSetting() {
            //First we need to load previous setting
            Setting.Serializer = new JsonSerializer(GeneralSettingFile);
        }
        //Init app
        public static void Init() {
            InitPlc();
            InitDB();
            InitRobots();
            InitScanners();
            InitHandEyes();
            LoadModels();
            Localize();
        }

        //Terminate hardware
        public static void Terminate() => Library.Terminate(); 
        public static bool EnableR(int i) {
            switch(i) {
                case 0: return Global.Setting.EnableR0;
                case 1: return Global.Setting.EnableR1;
                case 2: return Global.Setting.EnableR2;
                case 3: return Global.Setting.EnableR3;
            }
            return false;
        }

        public static bool EnableS(int i) {
            switch (i) {
                case 0: return Global.Setting.ScannerPass != ScannerConfigEnum.Scanner0;
                case 1: return Global.Setting.ScannerPass != ScannerConfigEnum.Scanner1;
                case 2: return Global.Setting.ScannerPass != ScannerConfigEnum.Scanner2;
                case 3: return Global.Setting.ScannerPass != ScannerConfigEnum.Scanner3;
            }
            return false;
        }

    }
}

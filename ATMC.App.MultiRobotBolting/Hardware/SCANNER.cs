using LotusAPI;
using LotusAPI.Controls;
using LotusAPI.HW;
using LotusAPI.MV;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

#if USE_SCANNER
namespace ATMC.App.MultiRobotBolting {
    internal static partial class Global {
        //Number of scanner used in this program
        public const int SCANNER_COUNT = 4;
        public static AbeoScanManager Scanners = new AbeoScanManager();
        public static void InitScanners() => Scanners.Init(SCANNER_COUNT, SettingDir, Global.Setting.ScannerProfile);
    }
}
#endif


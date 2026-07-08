using LotusAPI;
using LotusAPI.Math;
using LotusAPI.Robotics;
using LotusAPI.Robotics.Hyundai;
using LotusAPI.Robotics.Kawasaki;
using LotusAPI.Robotics.Yaskawa;
using LotusAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ATMC.App.MultiRobotBolting {
    internal static partial class Global {
        public const int HANDEYE_COUNT = 4;
        public static HandEyeManager HandEyes = new HandEyeManager();
        public static void InitHandEyes() { HandEyes.Init(HANDEYE_COUNT, Global.SettingDir); }
    }
}

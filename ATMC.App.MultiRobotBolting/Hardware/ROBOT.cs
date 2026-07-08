using ATMC.Common;
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

#if USE_ROBOT
namespace ATMC.App.MultiRobotBolting {
    internal static partial class Global {
        //Number of camera used in this program
        public const int ROBOT_COUNT = 4;
        public static RobotManager Robots = new RobotManager();
        static void InitRobots() => Robots.Init(Global.Setting.RobotType, ROBOT_COUNT, SettingDir);
    }
}
#endif

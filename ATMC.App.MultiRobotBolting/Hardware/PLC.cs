using ATMC.Common;
using LotusAPI;
using LotusAPI.HW;
using LotusAPI.HW.PLC;
using LotusAPI.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

#if USE_PLC
namespace ATMC.App.MultiRobotBolting {
    internal static partial class Global {
        //================================================================================
        public static string PlcSettingFile => SettingDir + "/plc.json";

        public enum PlcBlock { CAR_TYPE, BODY_NO, SEQ_NO, PCRUN }

        public static List<string> PlcBlockNames =
            Array.ConvertAll((PlcBlock[])Enum.GetValues(typeof(PlcBlock)), x => x.ToString()).ToList();


        public static PLCManager PlcMan = null;
        public static void InitPlc() {
            PlcMan = new PLCManager(Global.Setting.PlcType, PlcSettingFile);
            PlcMan.AssertPlc();
            PlcMan.PCRUNMethod = Global.Setting.PCRUN;
            //TODO: SEtup your default pin map
            if(PlcMan.Plc.PinMap.Pins.Count == 0) {
                var pinmap = new PinMap();
                pinmap.Pins.Add(new PinInfo(PinFunc.DI, 0, InputPin.RESET));
                pinmap.Pins.Add(new PinInfo(PinFunc.DI, 1, InputPin.START));
                pinmap.Pins.Add(new PinInfo(PinFunc.DI, 2, InputPin.SCAN));
                pinmap.Pins.Add(new PinInfo(PinFunc.DI, 15, InputPin.END));
                pinmap.Pins.Add(new PinInfo(PinFunc.DI, 6, InputPin.VISION0_PASS));
                pinmap.Pins.Add(new PinInfo(PinFunc.DI, 7, InputPin.VISION1_PASS));
                pinmap.Pins.Add(new PinInfo(PinFunc.DI, 8, InputPin.VISION2_PASS));
                pinmap.Pins.Add(new PinInfo(PinFunc.DI, 9, InputPin.VISION3_PASS));

                pinmap.Pins.Add(new PinInfo(PinFunc.DO, 0, OutputPin.OK));
                pinmap.Pins.Add(new PinInfo(PinFunc.DO, 1, OutputPin.NG));
                pinmap.Pins.Add(new PinInfo(PinFunc.DO, 15, OutputPin.PCRUN));
                pinmap.Pins.Add(new PinInfo(PinFunc.DO, 6, OutputPin.VISION0_PASS));
                pinmap.Pins.Add(new PinInfo(PinFunc.DO, 7, OutputPin.VISION1_PASS));
                pinmap.Pins.Add(new PinInfo(PinFunc.DO, 8, OutputPin.VISION2_PASS));
                pinmap.Pins.Add(new PinInfo(PinFunc.DO, 9, OutputPin.VISION3_PASS));
                PlcMan.Plc.PinMap = pinmap;
            }
        }
    }
}
#endif

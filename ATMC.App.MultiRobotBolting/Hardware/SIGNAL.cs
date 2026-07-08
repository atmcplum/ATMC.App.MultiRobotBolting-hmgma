using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ATMC.App.MultiRobotBolting {
    internal static partial class Global {
        //TODO: Defines output signal names
        public enum OutputPin { OK, NG, PCRUN,HW_ERR, VISION0_PASS, VISION1_PASS, VISION2_PASS, VISION3_PASS }

        // TODO: Defines input signal names
        public enum InputPin { RESET, START, SCAN, END, MANUAL_LOAD, VISION0_PASS, VISION1_PASS, VISION2_PASS, VISION3_PASS }

        //Pin name
        public static List<string> PinNames =
            Array.ConvertAll((InputPin[])Enum.GetValues(typeof(InputPin)), x => x.ToString())
            .Concat(Array.ConvertAll((OutputPin[])Enum.GetValues(typeof(OutputPin)), x => x.ToString()))
            .ToList();

        //Pin color map
        internal static Dictionary<string, Color> PinColorMap = new Dictionary<string, Color> {
            {OutputPin.NG.ToString(), Global.ColorNG},
        };
    }
}

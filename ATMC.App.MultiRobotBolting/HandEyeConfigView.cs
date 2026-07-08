using LotusAPI;
using LotusAPI.Robotics;
using System;
using System.Windows.Forms;

namespace ATMC.App.MultiRobotBolting {
    public partial class HandEyeConfigView : UserControl {
        public HandEyeConfigView() {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e) => Global.HandEyes.ConfigHandEye(0);
        private void bt1_Click(object sender, EventArgs e) => Global.HandEyes.ConfigHandEye(1);
        private void bt2_Click(object sender, EventArgs e) => Global.HandEyes.ConfigHandEye(2);
        private void bt3_Click(object sender, EventArgs e) => Global.HandEyes.ConfigHandEye(3);

        internal void SetupButtons() {
            bt0.Visible = true;
            bt1.Visible = true;
            bt2.Visible = true;
            bt3.Visible = true;
        }
    }
}

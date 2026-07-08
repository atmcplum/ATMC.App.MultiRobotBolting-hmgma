using LotusAPI;
using LotusAPI.Controls;
using LotusAPI.MV;
using LotusAPI.Robotics;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Img = LotusAPI.MV.Image;

namespace ATMC.App.MultiRobotBolting {
    public partial class FormMakeModel : Form {

        PointcloudViewer _pcv = null;

        RobotPoseEx[] _poses = new RobotPoseEx[Global.ROBOT_COUNT];
        Pointcloud _model;

        public FormMakeModel() {
            InitializeComponent();
            _pcv = new PointcloudViewer(pointcloudView1);
        }

        void UpdateView() {
            try {
                _pcv.Clear();
                if(_model != null) _pcv.Add(_model, Color.Lime);
                _pcv.Render();
            } catch(Exception ex) { DialogUtils.ShowErr(ex); }
        }


        private void bt_SCAN_Click(object sender, EventArgs e) {
            try {
                //model is in CC
                Img[] imgs;
                _model = MyUtils.Scan(null, out _poses,out imgs);
                lbPoses.Items.Clear();
                for(int i = 0; i < _poses.Length; i++) {
                    if(Global.EnableR(i)) {
                        if(_poses[i] != null) lbPoses.Items.Add($"[{i}] {_poses[i]}");
                    }
                }
                UpdateView();
            } catch(Exception ex) { DialogUtils.ShowErr(ex); }
        }

        private void bt_Save_Click(object sender, EventArgs e) {
            try {
                var dir = LotusAPI.DialogUtils.ShowFolderBrowserDialog("Open model directory");
                if(dir == "") return;
                if(_model == null) throw new Exception("Invalid model cloud!");
                _model.WritePLY(dir + "/model_cc.ply");
                JsonUtils.ToJson(_poses).Save(dir + "/scan_poses.json");
                //Global.LoadModels();
                DialogUtils.ShowInfoMsg("Please clean up model and reload!");
            } catch(Exception ex) { DialogUtils.ShowErr(ex); }
        }
    }
}

using LotusAPI;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ATMC.App.MultiRobotBolting {
    public partial class FormOffsetLimitEditor : Form {
        ModelConfig _model = null;
        public FormOffsetLimitEditor(string model_name) {
            InitializeComponent();
            try {
                if(File.Exists(Global.UFImageFile)) {
                    picbox.Image = Bitmap.FromFile(Global.UFImageFile);
                }

                cbb_Models.Items.Clear();
                foreach(var model in Global.Models) {
                    cbb_Models.Items.Add(model.Name);
                }

                //Select model if given
                if(cbb_Models.Items.Count > 0) {
                    cbb_Models.SelectedIndex = cbb_Models.FindString(model_name);
                }
            } catch(Exception ex) { LotusAPI.DialogUtils.ShowErrMsg(ex.Message); }
        }

        private void cbb_Models_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                _model = Global.Models.Find(x => x.Name == cbb_Models.Text);
                if(_model == null) throw new Exception("Invalid model");
                limitView.Limit = _model.Registration.ShiftLimit;
                offsetView.Offset = _model.Registration.ShiftOffset;
                tb_MaxFit.Text = _model.Registration.MaxFitness.ToString("F3");
                tb_MinOvl.Text = _model.Registration.MinOverlap.ToString("F3");
            } catch(Exception ex) { LotusAPI.DialogUtils.ShowErrMsg(ex.Message); }
        }

        public void SelectModel(string model_name) {
            cbb_Models.SelectedIndex = cbb_Models.FindString(model_name);
        }

        private void flatButton1_Click(object sender, EventArgs e) {
            try {
                if(_model == null) throw new Exception("Invalid model");
                _model.Registration.ShiftOffset = offsetView.Offset;
                _model.Registration.ShiftLimit = limitView.Limit;
                _model.Registration.MinOverlap = double.Parse(tb_MinOvl.Text);
                _model.Registration.MaxFitness = double.Parse(tb_MaxFit.Text);
                if(DialogUtils.AskForPermission()) {
                    //TODO: Save
                    if(DialogUtils.AskForConfirmation("Do you want to save model?")) {
                        Global.SaveModels();
                    }
                }
            } catch(Exception ex) { LotusAPI.DialogUtils.ShowErrMsg(ex.Message); }
        }
    }
}


namespace ATMC.App.MultiRobotBolting {
    partial class FormSetting {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.modelList = new Abeo.Controls.Common.ObjectListControl();
            this.pgrid = new Abeo.Controls.FlatPropertyGrid();
            this.panelSide = new Abeo.Controls.FlatPanel();
            this.bt_HandEye = new Abeo.Controls.Roundable.RoundButton();
            this.handEyeConfigView1 = new ATMC.App.MultiRobotBolting.HandEyeConfigView();
            this.bt_R3 = new Abeo.Controls.Roundable.RoundButton();
            this.bt_R2 = new Abeo.Controls.Roundable.RoundButton();
            this.bt_R1 = new Abeo.Controls.Roundable.RoundButton();
            this.bt_R0 = new Abeo.Controls.Roundable.RoundButton();
            this.btPLC = new Abeo.Controls.Roundable.RoundButton();
            this.btModels = new Abeo.Controls.Roundable.RoundButton();
            this.btGeneral = new Abeo.Controls.Roundable.RoundButton();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelList
            // 
            this.modelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.modelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.modelList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.modelList.LoadButtonVisible = false;
            this.modelList.Location = new System.Drawing.Point(101, 0);
            this.modelList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modelList.Name = "modelList";
            this.modelList.ObjectEditOnDoubleClick = false;
            this.modelList.ObjectType = null;
            this.modelList.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.modelList.Path = "";
            this.modelList.PropertyVisible = false;
            this.modelList.SaveButtonVisible = false;
            this.modelList.SelectedIndex = -1;
            this.modelList.Size = new System.Drawing.Size(1064, 722);
            this.modelList.TabIndex = 2;
            this.modelList.Title = "";
            this.modelList.AfterSaveEvent += new System.EventHandler(this.modelList_AfterSaveEvent);
            // 
            // pgrid
            // 
            this.pgrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pgrid.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.pgrid.CategorySplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pgrid.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(59)))), ((int)(((byte)(39)))));
            this.pgrid.CommandsBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pgrid.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.pgrid.CommandsLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.pgrid.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.pgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pgrid.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pgrid.HelpBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pgrid.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.pgrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.pgrid.Location = new System.Drawing.Point(101, 0);
            this.pgrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pgrid.Name = "pgrid";
            this.pgrid.SelectedItemWithFocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.pgrid.SelectedItemWithFocusForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pgrid.Size = new System.Drawing.Size(1064, 722);
            this.pgrid.TabIndex = 1;
            this.pgrid.ToolbarVisible = false;
            this.pgrid.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pgrid.ViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.pgrid.ViewForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.panelSide.Controls.Add(this.bt_HandEye);
            this.panelSide.Controls.Add(this.bt_R3);
            this.panelSide.Controls.Add(this.bt_R2);
            this.panelSide.Controls.Add(this.bt_R1);
            this.panelSide.Controls.Add(this.bt_R0);
            this.panelSide.Controls.Add(this.btPLC);
            this.panelSide.Controls.Add(this.btModels);
            this.panelSide.Controls.Add(this.btGeneral);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelSide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.panelSide.Location = new System.Drawing.Point(5, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(96, 722);
            this.panelSide.TabIndex = 0;
            // 
            // bt_HandEye
            // 
            this.bt_HandEye.BackColor = System.Drawing.Color.Transparent;
            this.bt_HandEye.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_HandEye.BorderCorners = Abeo.Controls.Roundable.Corners.None;
            this.bt_HandEye.BorderRadius = 0;
            this.bt_HandEye.BorderThickness = 0;
            this.bt_HandEye.Checked = false;
            this.bt_HandEye.CheckEnable = true;
            this.bt_HandEye.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.bt_HandEye.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.bt_HandEye.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_HandEye.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_HandEye.ControlToBringToFront = this.handEyeConfigView1;
            this.bt_HandEye.DebugMode = false;
            this.bt_HandEye.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_HandEye.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bt_HandEye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_HandEye.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.bt_HandEye.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_HandEye.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_HandEye.Icon = global::ATMC.App.MultiRobotBolting.Properties.Resources.robot_24px;
            this.bt_HandEye.IconPortion = 0.6F;
            this.bt_HandEye.IconSize = 24;
            this.bt_HandEye.IconVisible = true;
            this.bt_HandEye.Image = null;
            this.bt_HandEye.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_HandEye.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_HandEye.IsExclusive = true;
            this.bt_HandEye.Location = new System.Drawing.Point(0, 448);
            this.bt_HandEye.Margin = new System.Windows.Forms.Padding(0);
            this.bt_HandEye.Name = "bt_HandEye";
            this.bt_HandEye.Size = new System.Drawing.Size(96, 64);
            this.bt_HandEye.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_HandEye.TabIndex = 4;
            this.bt_HandEye.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_HandEye.TagLocation = Abeo.Controls.Roundable.TagLocation.Right;
            this.bt_HandEye.TagOffset = 0;
            this.bt_HandEye.TagVisible = true;
            this.bt_HandEye.TagWidth = 3;
            this.bt_HandEye.Text = "HAND-EYE";
            this.bt_HandEye.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bt_HandEye.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_HandEye.CheckedChanged += new System.EventHandler(this.btGeneral_CheckedChanged);
            // 
            // handEyeConfigView1
            // 
            this.handEyeConfigView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.handEyeConfigView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.handEyeConfigView1.Location = new System.Drawing.Point(101, 0);
            this.handEyeConfigView1.Name = "handEyeConfigView1";
            this.handEyeConfigView1.Size = new System.Drawing.Size(1064, 722);
            this.handEyeConfigView1.TabIndex = 3;
            // 
            // bt_R3
            // 
            this.bt_R3.BackColor = System.Drawing.Color.Transparent;
            this.bt_R3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_R3.BorderCorners = Abeo.Controls.Roundable.Corners.None;
            this.bt_R3.BorderRadius = 0;
            this.bt_R3.BorderThickness = 0;
            this.bt_R3.Checked = false;
            this.bt_R3.CheckEnable = true;
            this.bt_R3.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.bt_R3.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.bt_R3.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_R3.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_R3.ControlToBringToFront = this.pgrid;
            this.bt_R3.DebugMode = false;
            this.bt_R3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_R3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bt_R3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_R3.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.bt_R3.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_R3.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_R3.Icon = global::ATMC.App.MultiRobotBolting.Properties.Resources.hwcard_24;
            this.bt_R3.IconPortion = 0.6F;
            this.bt_R3.IconSize = 24;
            this.bt_R3.IconVisible = true;
            this.bt_R3.Image = null;
            this.bt_R3.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_R3.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_R3.IsExclusive = true;
            this.bt_R3.Location = new System.Drawing.Point(0, 384);
            this.bt_R3.Margin = new System.Windows.Forms.Padding(0);
            this.bt_R3.Name = "bt_R3";
            this.bt_R3.Size = new System.Drawing.Size(96, 64);
            this.bt_R3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_R3.TabIndex = 9;
            this.bt_R3.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_R3.TagLocation = Abeo.Controls.Roundable.TagLocation.Right;
            this.bt_R3.TagOffset = 0;
            this.bt_R3.TagVisible = true;
            this.bt_R3.TagWidth = 3;
            this.bt_R3.Text = "R3";
            this.bt_R3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bt_R3.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_R3.CheckedChanged += new System.EventHandler(this.btGeneral_CheckedChanged);
            // 
            // bt_R2
            // 
            this.bt_R2.BackColor = System.Drawing.Color.Transparent;
            this.bt_R2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_R2.BorderCorners = Abeo.Controls.Roundable.Corners.None;
            this.bt_R2.BorderRadius = 0;
            this.bt_R2.BorderThickness = 0;
            this.bt_R2.Checked = false;
            this.bt_R2.CheckEnable = true;
            this.bt_R2.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.bt_R2.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.bt_R2.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_R2.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_R2.ControlToBringToFront = this.pgrid;
            this.bt_R2.DebugMode = false;
            this.bt_R2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_R2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bt_R2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_R2.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.bt_R2.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_R2.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_R2.Icon = global::ATMC.App.MultiRobotBolting.Properties.Resources.hwcard_24;
            this.bt_R2.IconPortion = 0.6F;
            this.bt_R2.IconSize = 24;
            this.bt_R2.IconVisible = true;
            this.bt_R2.Image = null;
            this.bt_R2.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_R2.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_R2.IsExclusive = true;
            this.bt_R2.Location = new System.Drawing.Point(0, 320);
            this.bt_R2.Margin = new System.Windows.Forms.Padding(0);
            this.bt_R2.Name = "bt_R2";
            this.bt_R2.Size = new System.Drawing.Size(96, 64);
            this.bt_R2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_R2.TabIndex = 8;
            this.bt_R2.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_R2.TagLocation = Abeo.Controls.Roundable.TagLocation.Right;
            this.bt_R2.TagOffset = 0;
            this.bt_R2.TagVisible = true;
            this.bt_R2.TagWidth = 3;
            this.bt_R2.Text = "R2";
            this.bt_R2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bt_R2.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_R2.CheckedChanged += new System.EventHandler(this.btGeneral_CheckedChanged);
            // 
            // bt_R1
            // 
            this.bt_R1.BackColor = System.Drawing.Color.Transparent;
            this.bt_R1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_R1.BorderCorners = Abeo.Controls.Roundable.Corners.None;
            this.bt_R1.BorderRadius = 0;
            this.bt_R1.BorderThickness = 0;
            this.bt_R1.Checked = false;
            this.bt_R1.CheckEnable = true;
            this.bt_R1.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.bt_R1.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.bt_R1.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_R1.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_R1.ControlToBringToFront = this.pgrid;
            this.bt_R1.DebugMode = false;
            this.bt_R1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_R1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bt_R1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_R1.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.bt_R1.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_R1.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_R1.Icon = global::ATMC.App.MultiRobotBolting.Properties.Resources.hwcard_24;
            this.bt_R1.IconPortion = 0.6F;
            this.bt_R1.IconSize = 24;
            this.bt_R1.IconVisible = true;
            this.bt_R1.Image = null;
            this.bt_R1.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_R1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_R1.IsExclusive = true;
            this.bt_R1.Location = new System.Drawing.Point(0, 256);
            this.bt_R1.Margin = new System.Windows.Forms.Padding(0);
            this.bt_R1.Name = "bt_R1";
            this.bt_R1.Size = new System.Drawing.Size(96, 64);
            this.bt_R1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_R1.TabIndex = 7;
            this.bt_R1.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_R1.TagLocation = Abeo.Controls.Roundable.TagLocation.Right;
            this.bt_R1.TagOffset = 0;
            this.bt_R1.TagVisible = true;
            this.bt_R1.TagWidth = 3;
            this.bt_R1.Text = "R1";
            this.bt_R1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bt_R1.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_R1.CheckedChanged += new System.EventHandler(this.btGeneral_CheckedChanged);
            // 
            // bt_R0
            // 
            this.bt_R0.BackColor = System.Drawing.Color.Transparent;
            this.bt_R0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.bt_R0.BorderCorners = Abeo.Controls.Roundable.Corners.None;
            this.bt_R0.BorderRadius = 0;
            this.bt_R0.BorderThickness = 0;
            this.bt_R0.Checked = false;
            this.bt_R0.CheckEnable = true;
            this.bt_R0.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.bt_R0.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.bt_R0.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_R0.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.bt_R0.ControlToBringToFront = this.pgrid;
            this.bt_R0.DebugMode = false;
            this.bt_R0.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_R0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bt_R0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_R0.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.bt_R0.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_R0.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bt_R0.Icon = global::ATMC.App.MultiRobotBolting.Properties.Resources.hwcard_24;
            this.bt_R0.IconPortion = 0.6F;
            this.bt_R0.IconSize = 24;
            this.bt_R0.IconVisible = true;
            this.bt_R0.Image = null;
            this.bt_R0.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.bt_R0.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.bt_R0.IsExclusive = true;
            this.bt_R0.Location = new System.Drawing.Point(0, 192);
            this.bt_R0.Margin = new System.Windows.Forms.Padding(0);
            this.bt_R0.Name = "bt_R0";
            this.bt_R0.Size = new System.Drawing.Size(96, 64);
            this.bt_R0.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bt_R0.TabIndex = 6;
            this.bt_R0.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.bt_R0.TagLocation = Abeo.Controls.Roundable.TagLocation.Right;
            this.bt_R0.TagOffset = 0;
            this.bt_R0.TagVisible = true;
            this.bt_R0.TagWidth = 3;
            this.bt_R0.Text = "R0";
            this.bt_R0.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bt_R0.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_R0.CheckedChanged += new System.EventHandler(this.btGeneral_CheckedChanged);
            // 
            // btPLC
            // 
            this.btPLC.BackColor = System.Drawing.Color.Transparent;
            this.btPLC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.btPLC.BorderCorners = Abeo.Controls.Roundable.Corners.None;
            this.btPLC.BorderRadius = 0;
            this.btPLC.BorderThickness = 0;
            this.btPLC.Checked = false;
            this.btPLC.CheckEnable = true;
            this.btPLC.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btPLC.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.btPLC.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btPLC.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.btPLC.ControlToBringToFront = this.pgrid;
            this.btPLC.DebugMode = false;
            this.btPLC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPLC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btPLC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btPLC.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.btPLC.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btPLC.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btPLC.Icon = global::ATMC.App.MultiRobotBolting.Properties.Resources.hwcard_24;
            this.btPLC.IconPortion = 0.6F;
            this.btPLC.IconSize = 24;
            this.btPLC.IconVisible = true;
            this.btPLC.Image = null;
            this.btPLC.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.btPLC.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.btPLC.IsExclusive = true;
            this.btPLC.Location = new System.Drawing.Point(0, 128);
            this.btPLC.Margin = new System.Windows.Forms.Padding(0);
            this.btPLC.Name = "btPLC";
            this.btPLC.Size = new System.Drawing.Size(96, 64);
            this.btPLC.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btPLC.TabIndex = 1;
            this.btPLC.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.btPLC.TagLocation = Abeo.Controls.Roundable.TagLocation.Right;
            this.btPLC.TagOffset = 0;
            this.btPLC.TagVisible = true;
            this.btPLC.TagWidth = 3;
            this.btPLC.Text = "PLC";
            this.btPLC.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btPLC.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btPLC.CheckedChanged += new System.EventHandler(this.btGeneral_CheckedChanged);
            // 
            // btModels
            // 
            this.btModels.BackColor = System.Drawing.Color.Transparent;
            this.btModels.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.btModels.BorderCorners = Abeo.Controls.Roundable.Corners.None;
            this.btModels.BorderRadius = 0;
            this.btModels.BorderThickness = 0;
            this.btModels.Checked = true;
            this.btModels.CheckEnable = true;
            this.btModels.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btModels.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.btModels.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btModels.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.btModels.ControlToBringToFront = this.modelList;
            this.btModels.DebugMode = false;
            this.btModels.Dock = System.Windows.Forms.DockStyle.Top;
            this.btModels.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btModels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btModels.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.btModels.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btModels.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btModels.Icon = global::ATMC.App.MultiRobotBolting.Properties.Resources.model_24;
            this.btModels.IconPortion = 0.6F;
            this.btModels.IconSize = 24;
            this.btModels.IconVisible = true;
            this.btModels.Image = null;
            this.btModels.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.btModels.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.btModels.IsExclusive = true;
            this.btModels.Location = new System.Drawing.Point(0, 64);
            this.btModels.Margin = new System.Windows.Forms.Padding(0);
            this.btModels.Name = "btModels";
            this.btModels.Size = new System.Drawing.Size(96, 64);
            this.btModels.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btModels.TabIndex = 2;
            this.btModels.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.btModels.TagLocation = Abeo.Controls.Roundable.TagLocation.Right;
            this.btModels.TagOffset = 0;
            this.btModels.TagVisible = true;
            this.btModels.TagWidth = 3;
            this.btModels.Text = "MODELS";
            this.btModels.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btModels.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btModels.CheckedChanged += new System.EventHandler(this.btGeneral_CheckedChanged);
            // 
            // btGeneral
            // 
            this.btGeneral.BackColor = System.Drawing.Color.Transparent;
            this.btGeneral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.btGeneral.BorderCorners = Abeo.Controls.Roundable.Corners.None;
            this.btGeneral.BorderRadius = 0;
            this.btGeneral.BorderThickness = 0;
            this.btGeneral.Checked = false;
            this.btGeneral.CheckEnable = true;
            this.btGeneral.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btGeneral.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.btGeneral.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btGeneral.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.btGeneral.ControlToBringToFront = this.pgrid;
            this.btGeneral.DebugMode = false;
            this.btGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btGeneral.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btGeneral.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.btGeneral.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btGeneral.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btGeneral.Icon = global::ATMC.App.MultiRobotBolting.Properties.Resources.setting_24;
            this.btGeneral.IconPortion = 0.6F;
            this.btGeneral.IconSize = 24;
            this.btGeneral.IconVisible = true;
            this.btGeneral.Image = null;
            this.btGeneral.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.btGeneral.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.btGeneral.IsExclusive = true;
            this.btGeneral.Location = new System.Drawing.Point(0, 0);
            this.btGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.btGeneral.Name = "btGeneral";
            this.btGeneral.Size = new System.Drawing.Size(96, 64);
            this.btGeneral.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btGeneral.TabIndex = 0;
            this.btGeneral.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.btGeneral.TagLocation = Abeo.Controls.Roundable.TagLocation.Right;
            this.btGeneral.TagOffset = 0;
            this.btGeneral.TagVisible = true;
            this.btGeneral.TagWidth = 3;
            this.btGeneral.Text = "GENERAL";
            this.btGeneral.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btGeneral.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btGeneral.CheckedChanged += new System.EventHandler(this.btGeneral_CheckedChanged);
            // 
            // FormSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(1170, 727);
            this.Controls.Add(this.modelList);
            this.Controls.Add(this.pgrid);
            this.Controls.Add(this.handEyeConfigView1);
            this.Controls.Add(this.panelSide);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetting";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.panelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Abeo.Controls.FlatPanel panelSide;
        private Abeo.Controls.FlatPropertyGrid pgrid;
        private Abeo.Controls.Roundable.RoundButton btGeneral;
        private Abeo.Controls.Roundable.RoundButton btModels;
        private Abeo.Controls.Roundable.RoundButton btPLC;
        private Abeo.Controls.Common.ObjectListControl modelList;
        private Abeo.Controls.Roundable.RoundButton bt_HandEye;
        private Abeo.Controls.Roundable.RoundButton bt_R0;
        private HandEyeConfigView handEyeConfigView1;
        private Abeo.Controls.Roundable.RoundButton bt_R3;
        private Abeo.Controls.Roundable.RoundButton bt_R2;
        private Abeo.Controls.Roundable.RoundButton bt_R1;
    }
}
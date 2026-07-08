
namespace ATMC.App.MultiRobotBolting {
    partial class FormOffsetLimitEditor {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOffsetLimitEditor));
            this.flatLabel1 = new Abeo.Controls.FlatLabel();
            this.flatLabel3 = new Abeo.Controls.FlatLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flatLabel4 = new Abeo.Controls.FlatLabel();
            this.tb_MaxFit = new Abeo.Controls.Roundable.RoundTextbox();
            this.flatLabel2 = new Abeo.Controls.FlatLabel();
            this.tb_MinOvl = new Abeo.Controls.Roundable.RoundTextbox();
            this.limitView = new LotusAPI.Robotics.ShiftLimitEdit();
            this.offsetView = new LotusAPI.Robotics.ShiftOffsetEdit();
            this.flatButton1 = new Abeo.Controls.FlatButton();
            this.cbb_Models = new Abeo.Controls.FlatComboBox();
            this.lblModel = new Abeo.Controls.FlatLabel();
            this.roundTextbox2 = new Abeo.Controls.Roundable.RoundTextbox();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // flatLabel1
            // 
            this.flatLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flatLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.flatLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.flatLabel1.Location = new System.Drawing.Point(0, 0);
            this.flatLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(266, 32);
            this.flatLabel1.TabIndex = 0;
            this.flatLabel1.Text = "LIMIT";
            this.flatLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel3
            // 
            this.flatLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flatLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.flatLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.flatLabel3.Location = new System.Drawing.Point(268, 0);
            this.flatLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(157, 32);
            this.flatLabel3.TabIndex = 0;
            this.flatLabel3.Text = "OFFSET";
            this.flatLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lock_24px.png");
            this.imageList1.Images.SetKeyName(1, "Open Lock_24px.png");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.68657F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.31343F));
            this.tableLayoutPanel1.Controls.Add(this.flatLabel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_MaxFit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flatLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_MinOvl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.limitView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.offsetView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flatLabel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flatLabel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(600, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(425, 345);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // flatLabel4
            // 
            this.flatLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.flatLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.flatLabel4.Location = new System.Drawing.Point(3, 297);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(260, 48);
            this.flatLabel4.TabIndex = 0;
            this.flatLabel4.Text = "Min OVL";
            this.flatLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_MaxFit
            // 
            this.tb_MaxFit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MaxFit.BackColor = System.Drawing.Color.Transparent;
            this.tb_MaxFit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.tb_MaxFit.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.tb_MaxFit.BorderRadius = 3;
            this.tb_MaxFit.BorderThickness = 2;
            this.tb_MaxFit.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(162)))));
            this.tb_MaxFit.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.tb_MaxFit.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.tb_MaxFit.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.tb_MaxFit.DebugMode = false;
            this.tb_MaxFit.EnforceContent = Abeo.Controls.Roundable.RoundTextbox.EnforceType.Text;
            this.tb_MaxFit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaxFit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.tb_MaxFit.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.tb_MaxFit.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tb_MaxFit.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tb_MaxFit.Icon = null;
            this.tb_MaxFit.IconPortion = 0.3F;
            this.tb_MaxFit.IconSize = 24;
            this.tb_MaxFit.IconVisible = false;
            this.tb_MaxFit.Image = null;
            this.tb_MaxFit.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.tb_MaxFit.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.tb_MaxFit.Location = new System.Drawing.Point(269, 252);
            this.tb_MaxFit.Name = "tb_MaxFit";
            this.tb_MaxFit.Padding = new System.Windows.Forms.Padding(6);
            this.tb_MaxFit.PasswordChar = '\0';
            this.tb_MaxFit.ReadOnly = false;
            this.tb_MaxFit.Size = new System.Drawing.Size(153, 38);
            this.tb_MaxFit.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.tb_MaxFit.TabIndex = 1;
            this.tb_MaxFit.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.tb_MaxFit.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.tb_MaxFit.TagOffset = 5;
            this.tb_MaxFit.TagVisible = false;
            this.tb_MaxFit.TagWidth = 5;
            this.tb_MaxFit.Text = "0.000";
            this.tb_MaxFit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_MaxFit.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_MaxFit.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // flatLabel2
            // 
            this.flatLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.flatLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.flatLabel2.Location = new System.Drawing.Point(3, 249);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(260, 48);
            this.flatLabel2.TabIndex = 0;
            this.flatLabel2.Text = "Max FIT";
            this.flatLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_MinOvl
            // 
            this.tb_MinOvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MinOvl.BackColor = System.Drawing.Color.Transparent;
            this.tb_MinOvl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.tb_MinOvl.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.tb_MinOvl.BorderRadius = 3;
            this.tb_MinOvl.BorderThickness = 2;
            this.tb_MinOvl.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(162)))));
            this.tb_MinOvl.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.tb_MinOvl.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.tb_MinOvl.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.tb_MinOvl.DebugMode = false;
            this.tb_MinOvl.EnforceContent = Abeo.Controls.Roundable.RoundTextbox.EnforceType.Text;
            this.tb_MinOvl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MinOvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.tb_MinOvl.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.tb_MinOvl.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tb_MinOvl.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tb_MinOvl.Icon = null;
            this.tb_MinOvl.IconPortion = 0.3F;
            this.tb_MinOvl.IconSize = 24;
            this.tb_MinOvl.IconVisible = false;
            this.tb_MinOvl.Image = null;
            this.tb_MinOvl.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.tb_MinOvl.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.tb_MinOvl.Location = new System.Drawing.Point(269, 300);
            this.tb_MinOvl.Name = "tb_MinOvl";
            this.tb_MinOvl.Padding = new System.Windows.Forms.Padding(6);
            this.tb_MinOvl.PasswordChar = '\0';
            this.tb_MinOvl.ReadOnly = false;
            this.tb_MinOvl.Size = new System.Drawing.Size(153, 38);
            this.tb_MinOvl.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.tb_MinOvl.TabIndex = 1;
            this.tb_MinOvl.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.tb_MinOvl.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.tb_MinOvl.TagOffset = 5;
            this.tb_MinOvl.TagVisible = false;
            this.tb_MinOvl.TagWidth = 5;
            this.tb_MinOvl.Text = "0.000";
            this.tb_MinOvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_MinOvl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_MinOvl.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // limitView
            // 
            this.limitView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limitView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.limitView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.limitView.Location = new System.Drawing.Point(0, 32);
            this.limitView.Margin = new System.Windows.Forms.Padding(0);
            this.limitView.Name = "limitView";
            this.limitView.Size = new System.Drawing.Size(266, 217);
            this.limitView.TabIndex = 1;
            // 
            // offsetView
            // 
            this.offsetView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offsetView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.offsetView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.offsetView.Location = new System.Drawing.Point(268, 32);
            this.offsetView.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.offsetView.Name = "offsetView";
            this.offsetView.Size = new System.Drawing.Size(157, 217);
            this.offsetView.TabIndex = 2;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.flatButton1.BorderColor = System.Drawing.Color.Empty;
            this.flatButton1.BorderSize = 0;
            this.flatButton1.FlatAppearance.BorderSize = 0;
            this.flatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.flatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.flatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatButton1.Location = new System.Drawing.Point(870, 395);
            this.flatButton1.Margin = new System.Windows.Forms.Padding(8);
            this.flatButton1.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatButton1.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(153, 32);
            this.flatButton1.TabIndex = 6;
            this.flatButton1.Text = "APPLY";
            this.flatButton1.UseVisualStyleBackColor = false;
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // cbb_Models
            // 
            this.cbb_Models.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Models.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.cbb_Models.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.cbb_Models.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.cbb_Models.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.cbb_Models.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_Models.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Models.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Models.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_Models.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_Models.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.cbb_Models.ItemListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.cbb_Models.ItemListForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.cbb_Models.ItemListSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.cbb_Models.ItemListSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.cbb_Models.Location = new System.Drawing.Point(750, 5);
            this.cbb_Models.Name = "cbb_Models";
            this.cbb_Models.Size = new System.Drawing.Size(276, 30);
            this.cbb_Models.TabIndex = 7;
            this.cbb_Models.SelectedIndexChanged += new System.EventHandler(this.cbb_Models_SelectedIndexChanged);
            // 
            // lblModel
            // 
            this.lblModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModel.BackColor = System.Drawing.Color.Transparent;
            this.lblModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.lblModel.Location = new System.Drawing.Point(600, 5);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(145, 30);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "MODEL";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roundTextbox2
            // 
            this.roundTextbox2.BackColor = System.Drawing.Color.Transparent;
            this.roundTextbox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.roundTextbox2.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.roundTextbox2.BorderRadius = 3;
            this.roundTextbox2.BorderThickness = 2;
            this.roundTextbox2.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(162)))));
            this.roundTextbox2.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.roundTextbox2.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundTextbox2.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.roundTextbox2.DebugMode = false;
            this.roundTextbox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundTextbox2.EnforceContent = Abeo.Controls.Roundable.RoundTextbox.EnforceType.Text;
            this.roundTextbox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.roundTextbox2.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundTextbox2.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundTextbox2.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundTextbox2.Icon = null;
            this.roundTextbox2.IconPortion = 0.3F;
            this.roundTextbox2.IconSize = 24;
            this.roundTextbox2.IconVisible = false;
            this.roundTextbox2.Image = null;
            this.roundTextbox2.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Stretch;
            this.roundTextbox2.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.roundTextbox2.Location = new System.Drawing.Point(104, 4);
            this.roundTextbox2.Name = "roundTextbox2";
            this.roundTextbox2.Padding = new System.Windows.Forms.Padding(6);
            this.roundTextbox2.PasswordChar = '\0';
            this.roundTextbox2.ReadOnly = false;
            this.roundTextbox2.Size = new System.Drawing.Size(152, 38);
            this.roundTextbox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.roundTextbox2.TabIndex = 1;
            this.roundTextbox2.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.roundTextbox2.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.roundTextbox2.TagOffset = 5;
            this.roundTextbox2.TagVisible = false;
            this.roundTextbox2.TagWidth = 5;
            this.roundTextbox2.Text = "0.000";
            this.roundTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.roundTextbox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundTextbox2.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // picbox
            // 
            this.picbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox.BackColor = System.Drawing.Color.White;
            this.picbox.Image = global::ATMC.App.MultiRobotBolting.Properties.Resources.tire_uf;
            this.picbox.Location = new System.Drawing.Point(5, 5);
            this.picbox.Name = "picbox";
            this.picbox.Padding = new System.Windows.Forms.Padding(20);
            this.picbox.Size = new System.Drawing.Size(590, 580);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 3;
            this.picbox.TabStop = false;
            // 
            // FormOffsetLimitEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1032, 591);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cbb_Models);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.flatButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1048, 630);
            this.MinimumSize = new System.Drawing.Size(1048, 630);
            this.Name = "FormOffsetLimitEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormOffsetLimitEditor";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Abeo.Controls.FlatLabel flatLabel1;
        private Abeo.Controls.FlatLabel flatLabel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LotusAPI.Robotics.ShiftLimitEdit limitView;
        private LotusAPI.Robotics.ShiftOffsetEdit offsetView;
        private Abeo.Controls.FlatButton flatButton1;
        private Abeo.Controls.FlatComboBox cbb_Models;
        private Abeo.Controls.FlatLabel lblModel;
        private Abeo.Controls.FlatLabel flatLabel2;
        private Abeo.Controls.FlatLabel flatLabel4;
        private Abeo.Controls.Roundable.RoundTextbox tb_MaxFit;
        private Abeo.Controls.Roundable.RoundTextbox tb_MinOvl;
        private Abeo.Controls.Roundable.RoundTextbox roundTextbox2;
    }
}
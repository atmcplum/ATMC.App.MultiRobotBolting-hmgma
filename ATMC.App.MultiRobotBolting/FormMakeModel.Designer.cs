
namespace ATMC.App.MultiRobotBolting {
    partial class FormMakeModel {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMakeModel));
            this.flatPanel1 = new Abeo.Controls.FlatPanel();
            this.bt_Save = new Abeo.Controls.FlatButton();
            this.bt_SCAN = new Abeo.Controls.FlatButton();
            this.pointcloudView1 = new LotusAPI.Controls.PointcloudView();
            this.lbPoses = new Abeo.Controls.FlatListBox();
            this.flatPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointcloudView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flatPanel1
            // 
            this.flatPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatPanel1.Controls.Add(this.lbPoses);
            this.flatPanel1.Controls.Add(this.bt_Save);
            this.flatPanel1.Controls.Add(this.bt_SCAN);
            this.flatPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatPanel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.flatPanel1.Location = new System.Drawing.Point(5, 0);
            this.flatPanel1.Name = "flatPanel1";
            this.flatPanel1.Size = new System.Drawing.Size(1052, 131);
            this.flatPanel1.TabIndex = 0;
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_Save.BorderColor = System.Drawing.Color.Empty;
            this.bt_Save.BorderSize = 0;
            this.bt_Save.FlatAppearance.BorderSize = 0;
            this.bt_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.bt_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Save.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bt_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.bt_Save.Location = new System.Drawing.Point(104, 7);
            this.bt_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_Save.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.bt_Save.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(90, 32);
            this.bt_Save.TabIndex = 1;
            this.bt_Save.Text = "SAVE";
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_SCAN
            // 
            this.bt_SCAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.bt_SCAN.BorderColor = System.Drawing.Color.Empty;
            this.bt_SCAN.BorderSize = 0;
            this.bt_SCAN.FlatAppearance.BorderSize = 0;
            this.bt_SCAN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.bt_SCAN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.bt_SCAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SCAN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bt_SCAN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.bt_SCAN.Location = new System.Drawing.Point(6, 7);
            this.bt_SCAN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_SCAN.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.bt_SCAN.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.bt_SCAN.Name = "bt_SCAN";
            this.bt_SCAN.Size = new System.Drawing.Size(90, 32);
            this.bt_SCAN.TabIndex = 0;
            this.bt_SCAN.Text = "SCAN";
            this.bt_SCAN.UseVisualStyleBackColor = false;
            this.bt_SCAN.Click += new System.EventHandler(this.bt_SCAN_Click);
            // 
            // pointcloudView1
            // 
            this.pointcloudView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointcloudView1.DrawFPS = false;
            this.pointcloudView1.GLBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.pointcloudView1.Location = new System.Drawing.Point(5, 131);
            this.pointcloudView1.Margin = new System.Windows.Forms.Padding(5);
            this.pointcloudView1.Name = "pointcloudView1";
            this.pointcloudView1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.pointcloudView1.RenderContextType = SharpGL.RenderContextType.FBO;
            this.pointcloudView1.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.pointcloudView1.Size = new System.Drawing.Size(1052, 617);
            this.pointcloudView1.TabIndex = 1;
            // 
            // lbPoses
            // 
            this.lbPoses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.lbPoses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPoses.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbPoses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lbPoses.FormattingEnabled = true;
            this.lbPoses.ItemHeight = 19;
            this.lbPoses.Items.AddRange(new object[] {
            "[0]",
            "[1]",
            "[2]",
            "[3]"});
            this.lbPoses.Location = new System.Drawing.Point(6, 47);
            this.lbPoses.Name = "lbPoses";
            this.lbPoses.Size = new System.Drawing.Size(1040, 76);
            this.lbPoses.TabIndex = 2;
            // 
            // FormMakeModel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1062, 753);
            this.Controls.Add(this.pointcloudView1);
            this.Controls.Add(this.flatPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMakeModel";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMakeModel";
            this.flatPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pointcloudView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Abeo.Controls.FlatPanel flatPanel1;
        private LotusAPI.Controls.PointcloudView pointcloudView1;
        private Abeo.Controls.FlatButton bt_SCAN;
        private Abeo.Controls.FlatButton bt_Save;
        private Abeo.Controls.FlatListBox lbPoses;
    }
}
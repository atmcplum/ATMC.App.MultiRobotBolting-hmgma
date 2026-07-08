
using ATMC.Common;

namespace ATMC.App.MultiRobotBolting {
    partial class FormMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMain = new Abeo.Controls.FlatPanel();
            this.panelHome = new Abeo.Controls.FlatPanel();
            this.vc = new ATMC.Common.ViewCard3D();
            this.reslog = new ATMC.Common.ResultSignalLogView();
            this.panelLog = new Abeo.Controls.FlatPanel();
            this.logview = new LotusAPI.Controls.LogView();
            this.statview = new LotusAPI.Data.SimpleStatView();
            this.dbView = new ATMC.Common.DBView();
            this.statusbar = new Abeo.Controls.ZeroCode.FlatStatusBar();
            this.resultGrid = new Abeo.Controls.AdvancedDataGrid();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.logfileWatcher = new LotusAPI.Utils.LogFileWatcher(this.components);
            this.tabbar = new ATMC.Common.TabBar();
            this.titlebar = new ATMC.Common.TitleBar();
            this.panelMain.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.tabbar.SuspendLayout();
            this.titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelMain.Controls.Add(this.panelHome);
            this.panelMain.Controls.Add(this.panelLog);
            this.panelMain.Controls.Add(this.statview);
            this.panelMain.Controls.Add(this.dbView);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.panelMain.Location = new System.Drawing.Point(0, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelMain.Size = new System.Drawing.Size(1770, 870);
            this.panelMain.TabIndex = 2;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelHome.Controls.Add(this.vc);
            this.panelHome.Controls.Add(this.reslog);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.panelHome.Location = new System.Drawing.Point(2, 3);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1766, 864);
            this.panelHome.TabIndex = 0;
            // 
            // vc
            // 
            this.vc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.vc.ColorNG = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.vc.ColorOK = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.vc.ColorRESET = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.vc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vc.Font = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // 
            // 
            this.vc.IOMap.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.vc.IOMap.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.vc.IOMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vc.IOMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.vc.IOMap.CellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.vc.IOMap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.vc.IOMap.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(132)))));
            this.vc.IOMap.HeaderFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.vc.IOMap.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.vc.IOMap.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.vc.IOMap.ItemFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vc.IOMap.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.vc.IOMap.LabelDI = "DI";
            this.vc.IOMap.LabelDO = "DO";
            this.vc.IOMap.LabelFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.vc.IOMap.Location = new System.Drawing.Point(569, 32);
            this.vc.IOMap.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.vc.IOMap.Name = "iomap";
            this.vc.IOMap.RWBackColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.vc.IOMap.RWBackColorInactive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.vc.IOMap.RWForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.vc.IOMap.ShowHeader = false;
            this.vc.IOMap.Size = new System.Drawing.Size(256, 99);
            this.vc.IOMap.TabIndex = 4;
            this.vc.IOMap.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(132)))));
            this.vc.IOMap.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.vc.IOMap.Visible = false;
            this.vc.IOMapHeight = 100;
            this.vc.Label = "3D VIEW";
            this.vc.Location = new System.Drawing.Point(0, 0);
            this.vc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vc.Name = "vc";
            // 
            // 
            // 
            this.vc.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vc.ResultLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.vc.ResultLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vc.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vc.ResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.vc.ResultLabel.Location = new System.Drawing.Point(1510, 289);
            this.vc.ResultLabel.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.vc.ResultLabel.Name = "lblResult";
            this.vc.ResultLabel.Size = new System.Drawing.Size(256, 319);
            this.vc.ResultLabel.TabIndex = 1;
            this.vc.ResultLabel.Text = "OK/NG";
            this.vc.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vc.ResultWidth = 256;
            // 
            // 
            // 
            this.vc.ShiftOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vc.ShiftOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.vc.ShiftOffset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vc.ShiftOffset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.vc.ShiftOffset.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.vc.ShiftOffset.ItemColor_NG = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.vc.ShiftOffset.ItemColor_OK = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.vc.ShiftOffset.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(162)))));
            this.vc.ShiftOffset.ItemNumberFormat = "F3";
            this.vc.ShiftOffset.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.vc.ShiftOffset.LabelFit = "FIT";
            this.vc.ShiftOffset.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(162)))));
            this.vc.ShiftOffset.LabelOvl = "OVL";
            this.vc.ShiftOffset.Location = new System.Drawing.Point(1510, 32);
            this.vc.ShiftOffset.Margin = new System.Windows.Forms.Padding(0);
            this.vc.ShiftOffset.Name = "shiftOffset";
            this.vc.ShiftOffset.ShowOffset = true;
            this.vc.ShiftOffset.Size = new System.Drawing.Size(256, 256);
            this.vc.ShiftOffset.TabIndex = 0;
            this.vc.ShiftOffset.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vc.ShiftOffsetHeight = 256;
            this.vc.ShowIOMap = false;
            this.vc.ShowOffset = true;
            this.vc.Size = new System.Drawing.Size(1766, 608);
            this.vc.TabIndex = 2;
            // 
            // 
            // 
            this.vc.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vc.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.vc.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vc.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vc.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(162)))));
            this.vc.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.vc.TitleLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.vc.TitleLabel.Name = "label";
            this.vc.TitleLabel.Size = new System.Drawing.Size(1766, 31);
            this.vc.TitleLabel.TabIndex = 2;
            this.vc.TitleLabel.Text = "3D VIEW";
            this.vc.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reslog
            // 
            this.reslog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            // 
            // 
            // 
            this.reslog.Counter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reslog.Counter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.reslog.Counter.BackColorNG = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.reslog.Counter.BackColorOK = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.reslog.Counter.BackColorTOTAL = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.reslog.Counter.CounterFont = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.reslog.Counter.ForeColorNG = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.reslog.Counter.ForeColorOK = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.reslog.Counter.ForeColorTOTAL = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.reslog.Counter.LabelFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.reslog.Counter.Location = new System.Drawing.Point(0, 0);
            this.reslog.Counter.Margin = new System.Windows.Forms.Padding(0);
            this.reslog.Counter.Name = "counter";
            this.reslog.Counter.PercentNumberFormat = "F3";
            this.reslog.Counter.Size = new System.Drawing.Size(600, 64);
            this.reslog.Counter.TabIndex = 0;
            // 
            // 
            // 
            this.reslog.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reslog.DataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.reslog.DataGrid.CellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.reslog.DataGrid.CellColorMode = true;
            this.reslog.DataGrid.CellTextPadding = 3;
            this.reslog.DataGrid.ColumnBorderOnly = false;
            this.reslog.DataGrid.DataSource = null;
            this.reslog.DataGrid.ExpandLastColumn = true;
            this.reslog.DataGrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reslog.DataGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.reslog.DataGrid.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.reslog.DataGrid.HeaderFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reslog.DataGrid.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(162)))));
            this.reslog.DataGrid.ItemBackColorEven = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.reslog.DataGrid.ItemBackColorOdd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.reslog.DataGrid.ItemForeColorEven = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.reslog.DataGrid.ItemForeColorOdd = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.reslog.DataGrid.Location = new System.Drawing.Point(0, 64);
            this.reslog.DataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.reslog.DataGrid.Name = "dgv";
            this.reslog.DataGrid.NumberFormat = "F3";
            this.reslog.DataGrid.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.reslog.DataGrid.ShowHeader = true;
            this.reslog.DataGrid.ShowSelection = false;
            this.reslog.DataGrid.Size = new System.Drawing.Size(600, 190);
            this.reslog.DataGrid.StretchRows = false;
            this.reslog.DataGrid.TabIndex = 3;
            this.reslog.DataGrid.UniformColumnSize = false;
            this.reslog.DataGrid.DataRowDoubleClickEvent += new Abeo.Controls.DataRowDoubleClickEventHandler(this.dgv_LastResult_DataRowDoubleClickEvent);
            this.reslog.DataGridWidth = 600;
            this.reslog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reslog.Font = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // 
            // 
            this.reslog.IOMap.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.reslog.IOMap.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.reslog.IOMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reslog.IOMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.reslog.IOMap.CellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.reslog.IOMap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reslog.IOMap.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.reslog.IOMap.HeaderFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.reslog.IOMap.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.reslog.IOMap.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.reslog.IOMap.ItemFont = new System.Drawing.Font("Segoe UI", 12F);
            this.reslog.IOMap.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(162)))));
            this.reslog.IOMap.LabelDI = "INPUT";
            this.reslog.IOMap.LabelDO = "OUTPUT";
            this.reslog.IOMap.LabelFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.reslog.IOMap.Location = new System.Drawing.Point(602, 0);
            this.reslog.IOMap.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.reslog.IOMap.Name = "ioview";
            this.reslog.IOMap.RWBackColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.reslog.IOMap.RWBackColorInactive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.reslog.IOMap.RWForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.reslog.IOMap.ShowHeader = false;
            this.reslog.IOMap.Size = new System.Drawing.Size(298, 254);
            this.reslog.IOMap.TabIndex = 1;
            this.reslog.IOMap.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.reslog.IOMap.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(162)))));
            this.reslog.IOMap.ItemDoubleClickEvent += new LotusAPI.HW.UI.IOPinmapView.ItemDoubleClickEventHandler(this.iomap_ItemDoubleClickEvent);
            this.reslog.IOMapWidth = 300;
            this.reslog.Location = new System.Drawing.Point(0, 608);
            // 
            // 
            // 
            this.reslog.LogView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.reslog.LogView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reslog.LogView.ColorDateTime = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.reslog.LogView.ColorDebug = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.reslog.LogView.ColorError = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(59)))), ((int)(((byte)(39)))));
            this.reslog.LogView.ColorFatal = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.reslog.LogView.ColorInfo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.reslog.LogView.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(162)))));
            this.reslog.LogView.ColorTrace = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.reslog.LogView.ColorWarning = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.reslog.LogView.DateTimeFormat = LotusAPI.Controls.LogDateTimeFormat.Time;
            this.reslog.LogView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reslog.LogView.Font = new System.Drawing.Font("Consolas", 9F);
            this.reslog.LogView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.reslog.LogView.LineBuffer = 1000;
            this.reslog.LogView.Location = new System.Drawing.Point(902, 0);
            this.reslog.LogView.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.reslog.LogView.Name = "logview";
            this.reslog.LogView.ReadOnly = true;
            this.reslog.LogView.ShowDateTime = true;
            this.reslog.LogView.Size = new System.Drawing.Size(864, 254);
            this.reslog.LogView.TabIndex = 4;
            this.reslog.LogView.UpdateInterval = 100;
            this.reslog.Name = "reslog";
            this.reslog.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.reslog.Size = new System.Drawing.Size(1766, 256);
            this.reslog.TabIndex = 3;
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.panelLog.Controls.Add(this.logview);
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLog.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.panelLog.Location = new System.Drawing.Point(2, 3);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(1766, 864);
            this.panelLog.TabIndex = 2;
            // 
            // logview
            // 
            this.logview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.logview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logview.ColorDateTime = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.logview.ColorDebug = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.logview.ColorError = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(59)))), ((int)(((byte)(40)))));
            this.logview.ColorFatal = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(130)))));
            this.logview.ColorInfo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.logview.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.logview.ColorTrace = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.logview.ColorWarning = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.logview.DateTimeFormat = LotusAPI.Controls.LogDateTimeFormat.Time;
            this.logview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logview.Font = new System.Drawing.Font("Consolas", 9F);
            this.logview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(213)))));
            this.logview.LineBuffer = 1000;
            this.logview.Location = new System.Drawing.Point(0, 0);
            this.logview.Name = "logview";
            this.logview.ReadOnly = true;
            this.logview.ShowDateTime = true;
            this.logview.Size = new System.Drawing.Size(1766, 864);
            this.logview.TabIndex = 0;
            this.logview.Text = "";
            this.logview.UpdateInterval = 100;
            // 
            // statview
            // 
            this.statview.BinCount = 25;
            this.statview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statview.Location = new System.Drawing.Point(2, 3);
            this.statview.ModelColumnName = "Model";
            this.statview.Name = "statview";
            this.statview.Query = null;
            this.statview.Size = new System.Drawing.Size(1766, 864);
            this.statview.TabIndex = 3;
            this.statview.XLabelFormat = "0.000";
            this.statview.YLabelFormat = "0.000";
            // 
            // dbView
            // 
            this.dbView.BackColor = System.Drawing.Color.Transparent;
            this.dbView.DateColumnName = "DATE";
            this.dbView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dbView.Location = new System.Drawing.Point(2, 3);
            this.dbView.ModelColumnName = "MODEL";
            this.dbView.Name = "dbView";
            this.dbView.ResultColumnName = "RESULT";
            this.dbView.Size = new System.Drawing.Size(1766, 864);
            this.dbView.SubpieFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dbView.SubpieInflateWidth = 8;
            this.dbView.SubpiePercentFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dbView.SubpieTitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dbView.SubResultColumnNames = "";
            this.dbView.TabIndex = 0;
            this.dbView.DataRowDoubleClickEventEx += new Abeo.Controls.DataRowDoubleClickEventHandlerEx(this.dbView_DataRowDoubleClickEventEx);
            // 
            // statusbar
            // 
            this.statusbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(22)))));
            this.statusbar.ClockColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(211)))));
            this.statusbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusbar.FixedHeight = 24;
            this.statusbar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusbar.FontResourceMonitor = new System.Drawing.Font("Consolas", 10F);
            this.statusbar.FontRTC = new System.Drawing.Font("Segoe UI", 10F);
            this.statusbar.FontStatus = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusbar.FontVersion = new System.Drawing.Font("Segoe UI", 10F);
            this.statusbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(162)))));
            this.statusbar.FreeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.statusbar.HighUseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.statusbar.Location = new System.Drawing.Point(0, 950);
            this.statusbar.LowUseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.statusbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusbar.MediumUseColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.statusbar.Name = "statusbar";
            this.statusbar.RTCWidth = 192;
            this.statusbar.ShowRunningGirl = false;
            this.statusbar.Size = new System.Drawing.Size(1770, 24);
            // 
            // 
            // 
            this.statusbar.StatusItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.statusbar.StatusItems.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.statusbar.StatusItems.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.statusbar.StatusItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.statusbar.StatusItems.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusbar.StatusItems.ForeColor = System.Drawing.Color.Black;
            this.statusbar.StatusItems.ForeColorON = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.statusbar.StatusItems.Items = "PLC\r\nSCANNER0|S0\r\nROBOT0|R0\r\nSCANNER1|S1\r\nROBOT1|R1\r\nSCANNER2|S2\r\nROBOT2|R2\r\nSCAN" +
    "NER3|S3\r\nROBOT3|R3";
            this.statusbar.StatusItems.ItemWidth = 64;
            this.statusbar.StatusItems.Location = new System.Drawing.Point(60, 0);
            this.statusbar.StatusItems.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.statusbar.StatusItems.Name = "statusItems";
            this.statusbar.StatusItems.ShowBorder = true;
            this.statusbar.StatusItems.Size = new System.Drawing.Size(575, 24);
            this.statusbar.StatusItems.TabIndex = 8;
            this.statusbar.StatusItems.ItemDoubleClickedEvent += new Abeo.Controls.ZeroCode.StatusItemPanel.ItemDoubleClickedEventHandler(this.statusbar_ItemDoubleClickedEvent);
            this.statusbar.StripeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(22)))));
            this.statusbar.StripeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.statusbar.StripeInterval = 100;
            this.statusbar.StripeMotionEnable = false;
            this.statusbar.StripeWidth = 8;
            this.statusbar.TabIndex = 0;
            // 
            // resultGrid
            // 
            this.resultGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.resultGrid.CellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.resultGrid.CellColorMode = false;
            this.resultGrid.CellTextPadding = 3;
            this.resultGrid.ColumnBorderOnly = false;
            this.resultGrid.DataSource = null;
            this.resultGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultGrid.ExpandLastColumn = true;
            this.resultGrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.resultGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.resultGrid.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.resultGrid.HeaderFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.resultGrid.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.resultGrid.ItemBackColorEven = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.resultGrid.ItemBackColorOdd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.resultGrid.ItemForeColorEven = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.resultGrid.ItemForeColorOdd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.resultGrid.Location = new System.Drawing.Point(0, 70);
            this.resultGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.NumberFormat = "0.000";
            this.resultGrid.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(226)))));
            this.resultGrid.ShowHeader = true;
            this.resultGrid.ShowSelection = false;
            this.resultGrid.Size = new System.Drawing.Size(385, 170);
            this.resultGrid.StretchRows = false;
            this.resultGrid.TabIndex = 2;
            this.resultGrid.UniformColumnSize = false;
            // 
            // logfileWatcher
            // 
            this.logfileWatcher.Interval = 3600000;
            this.logfileWatcher.LogDirectory = "./Logs/";
            this.logfileWatcher.LogLevel = 127;
            // 
            // tabbar
            // 
            this.tabbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.tabbar.ColorButtonBack = System.Drawing.Color.Transparent;
            this.tabbar.ColorButtonCheckedBack = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.tabbar.ColorButtonCheckedFore = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.tabbar.ColorButtonFore = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.tabbar.ColorButtonMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.tabbar.ColorButtonMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.tabbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabbar.FixedHeight = 48;
            this.tabbar.Location = new System.Drawing.Point(0, 32);
            this.tabbar.Name = "tabbar";
            this.tabbar.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tabbar.Size = new System.Drawing.Size(1770, 48);
            this.tabbar.StripeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.tabbar.StripeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.tabbar.StripeMotionEnable = false;
            this.tabbar.TabControl_DB = this.dbView;
            this.tabbar.TabControl_HOME = this.panelHome;
            this.tabbar.TabControl_LOG = this.panelLog;
            this.tabbar.TabControl_STAT = this.statview;
            this.tabbar.TabIndex = 1;
            this.tabbar.CycleInfoDoubleClick += new System.EventHandler(this.cycleInfo_DoubleClick);
            this.tabbar.SettingButtonClickEvent += new System.EventHandler(this.btSettings_Click);
            this.tabbar.DB_CheckedEvent += new System.EventHandler(this.tabbar_DB_CheckedEvent);
            this.tabbar.STAT_CheckedEvent += new System.EventHandler(this.tabbar_STAT_CheckedEvent);
            // 
            // titlebar
            // 
            this.titlebar.Auto = false;
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.FixedHeight = 32;
            this.titlebar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.ShowRunningGirl = false;
            this.titlebar.Size = new System.Drawing.Size(1770, 32);
            this.titlebar.StripeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(22)))));
            this.titlebar.StripeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.titlebar.TabIndex = 10;
            this.titlebar.HelpButtonClickEvent += new System.EventHandler(this.titlebar_HelpButtonClickEvent);
            this.titlebar.AutoManualDoubleClickEvent += new System.EventHandler(this.titlebar_AutoManualDoubleClickEvent);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1770, 974);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.tabbar);
            this.Controls.Add(this.titlebar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1764, 943);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelLog.ResumeLayout(false);
            this.tabbar.ResumeLayout(false);
            this.titlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Abeo.Controls.ZeroCode.FlatStatusBar statusbar;
        private Abeo.Controls.FlatPanel panelMain;
        private Abeo.Controls.FlatPanel panelHome;
        private Abeo.Controls.FlatPanel panelLog;
        private Abeo.Controls.AdvancedDataGrid resultGrid;
        private LotusAPI.Utils.LogFileWatcher logfileWatcher;
        private LotusAPI.Data.SimpleStatView statview;
        private LotusAPI.Controls.LogView logview;
        private DBView dbView;
        private System.Windows.Forms.ToolTip toolTip1;
        private TitleBar titlebar;
        private TabBar tabbar;
        private ViewCard3D vc;
        private ResultSignalLogView reslog;
    }
}


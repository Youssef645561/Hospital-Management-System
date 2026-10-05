namespace HMS.Appointment
{
    partial class frmManageAppointments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbFilter = new Youssef.WinForms.Controls.JOTextBox();
            this.btnReload = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.cbFilter = new Krypton.Toolkit.KryptonComboBox();
            this.lblRowCount = new Krypton.Toolkit.KryptonLabel();
            this.dgvAppointments = new Youssef.WinForms.Controls.JODataGridView();
            this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.schedulenewappointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.makevisitedtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rescheduletoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.canceltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.patienthistorytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbStatuses = new Krypton.Toolkit.KryptonComboBox();
            this.cbDaysOfWeek = new Krypton.Toolkit.KryptonComboBox();
            this.cbTypes = new Krypton.Toolkit.KryptonComboBox();
            this.dtpDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.cmsAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDaysOfWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFilter
            // 
            this.tbFilter.AllowSpecialCharacters = false;
            this.tbFilter.CornerRoundingRadius = 20F;
            this.tbFilter.Location = new System.Drawing.Point(173, 227);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbFilter.Size = new System.Drawing.Size(155, 35);
            this.tbFilter.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbFilter.StateCommon.Border.Rounding = 20F;
            this.tbFilter.TabIndex = 43;
            this.tbFilter.Visible = false;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.CornerRoundingRadius = 20F;
            this.btnReload.Location = new System.Drawing.Point(674, 219);
            this.btnReload.Name = "btnReload";
            this.btnReload.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnReload.Size = new System.Drawing.Size(98, 51);
            this.btnReload.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReload.StateCommon.Border.Rounding = 20F;
            this.btnReload.TabIndex = 47;
            this.btnReload.Values.Image = global::HMS.Properties.Resources.Reload_32;
            this.btnReload.Values.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(213, 138);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(359, 43);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 45;
            this.kryptonLabel1.Values.Text = "Manage Appointments";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.DropDownWidth = 143;
            this.cbFilter.IntegralHeight = false;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "ID",
            "Medical Record No",
            "Day",
            "Date",
            "Type",
            "Status"});
            this.cbFilter.Location = new System.Drawing.Point(12, 227);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbFilter.Size = new System.Drawing.Size(155, 35);
            this.cbFilter.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbFilter.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbFilter.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbFilter.TabIndex = 44;
            this.cbFilter.Text = "None";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowCount.Location = new System.Drawing.Point(12, 579);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(24, 20);
            this.lblRowCount.TabIndex = 41;
            this.lblRowCount.Values.Text = "#0";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToOrderColumns = true;
            this.dgvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAppointments.ColumnHeadersHeight = 30;
            this.dgvAppointments.ContextMenuStrip = this.cmsAppointments;
            this.dgvAppointments.Location = new System.Drawing.Point(12, 273);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowHeadersWidth = 40;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(760, 300);
            this.dgvAppointments.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvAppointments.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvAppointments.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointments.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dgvAppointments.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointments.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvAppointments.TabIndex = 40;
            this.dgvAppointments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAppointments_CellFormatting);
            this.dgvAppointments.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvAppointments_Scroll);
            // 
            // cmsAppointments
            // 
            this.cmsAppointments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailstoolStripMenuItem,
            this.toolStripSeparator1,
            this.schedulenewappointmentToolStripMenuItem,
            this.toolStripSeparator4,
            this.makevisitedtoolStripMenuItem,
            this.toolStripSeparator3,
            this.rescheduletoolStripMenuItem,
            this.toolStripSeparator5,
            this.canceltoolStripMenuItem,
            this.toolStripSeparator2,
            this.patienthistorytoolStripMenuItem});
            this.cmsAppointments.Name = "cmsPeople";
            this.cmsAppointments.Size = new System.Drawing.Size(297, 262);
            this.cmsAppointments.Opening += new System.ComponentModel.CancelEventHandler(this.cmsAppointments_Opening);
            // 
            // showDetailstoolStripMenuItem
            // 
            this.showDetailstoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailstoolStripMenuItem.Image = global::HMS.Properties.Resources.Appointment_Details_32;
            this.showDetailstoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailstoolStripMenuItem.Name = "showDetailstoolStripMenuItem";
            this.showDetailstoolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.showDetailstoolStripMenuItem.Text = "Show Details";
            this.showDetailstoolStripMenuItem.Click += new System.EventHandler(this.showDetailstoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(293, 6);
            // 
            // schedulenewappointmentToolStripMenuItem
            // 
            this.schedulenewappointmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulenewappointmentToolStripMenuItem.Image = global::HMS.Properties.Resources.Schedule_New_Appointment_32;
            this.schedulenewappointmentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.schedulenewappointmentToolStripMenuItem.Name = "schedulenewappointmentToolStripMenuItem";
            this.schedulenewappointmentToolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.schedulenewappointmentToolStripMenuItem.Text = "Schedule New Appointment";
            this.schedulenewappointmentToolStripMenuItem.Click += new System.EventHandler(this.schedulenewappointmentToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(293, 6);
            // 
            // makevisitedtoolStripMenuItem
            // 
            this.makevisitedtoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makevisitedtoolStripMenuItem.Image = global::HMS.Properties.Resources.Waiting_32;
            this.makevisitedtoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.makevisitedtoolStripMenuItem.Name = "makevisitedtoolStripMenuItem";
            this.makevisitedtoolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.makevisitedtoolStripMenuItem.Text = "Check In";
            this.makevisitedtoolStripMenuItem.Click += new System.EventHandler(this.CheckIntoolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(293, 6);
            // 
            // rescheduletoolStripMenuItem
            // 
            this.rescheduletoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rescheduletoolStripMenuItem.Image = global::HMS.Properties.Resources.Reschedule_Appointment_32;
            this.rescheduletoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rescheduletoolStripMenuItem.Name = "rescheduletoolStripMenuItem";
            this.rescheduletoolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.rescheduletoolStripMenuItem.Text = "Reschedule";
            this.rescheduletoolStripMenuItem.Click += new System.EventHandler(this.rescheduletoolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(293, 6);
            // 
            // canceltoolStripMenuItem
            // 
            this.canceltoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canceltoolStripMenuItem.Image = global::HMS.Properties.Resources.Cancel_Appointment_32;
            this.canceltoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.canceltoolStripMenuItem.Name = "canceltoolStripMenuItem";
            this.canceltoolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.canceltoolStripMenuItem.Text = "Cancel";
            this.canceltoolStripMenuItem.Click += new System.EventHandler(this.canceltoolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(293, 6);
            // 
            // patienthistorytoolStripMenuItem
            // 
            this.patienthistorytoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patienthistorytoolStripMenuItem.Image = global::HMS.Properties.Resources.Patient_History_32;
            this.patienthistorytoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patienthistorytoolStripMenuItem.Name = "patienthistorytoolStripMenuItem";
            this.patienthistorytoolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.patienthistorytoolStripMenuItem.Text = "Patient Appointments History";
            this.patienthistorytoolStripMenuItem.Click += new System.EventHandler(this.patienthistorytoolStripMenuItem_Click);
            // 
            // cbStatuses
            // 
            this.cbStatuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatuses.DropDownWidth = 143;
            this.cbStatuses.IntegralHeight = false;
            this.cbStatuses.Location = new System.Drawing.Point(173, 227);
            this.cbStatuses.Name = "cbStatuses";
            this.cbStatuses.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbStatuses.Size = new System.Drawing.Size(155, 35);
            this.cbStatuses.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbStatuses.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbStatuses.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatuses.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbStatuses.TabIndex = 46;
            this.cbStatuses.Visible = false;
            this.cbStatuses.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // cbDaysOfWeek
            // 
            this.cbDaysOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDaysOfWeek.DropDownWidth = 143;
            this.cbDaysOfWeek.IntegralHeight = false;
            this.cbDaysOfWeek.Items.AddRange(new object[] {
            "All",
            "Saturday",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cbDaysOfWeek.Location = new System.Drawing.Point(173, 227);
            this.cbDaysOfWeek.Name = "cbDaysOfWeek";
            this.cbDaysOfWeek.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbDaysOfWeek.Size = new System.Drawing.Size(155, 35);
            this.cbDaysOfWeek.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbDaysOfWeek.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbDaysOfWeek.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDaysOfWeek.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbDaysOfWeek.TabIndex = 48;
            this.cbDaysOfWeek.Text = "All";
            this.cbDaysOfWeek.Visible = false;
            this.cbDaysOfWeek.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // cbTypes
            // 
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.DropDownWidth = 143;
            this.cbTypes.IntegralHeight = false;
            this.cbTypes.Location = new System.Drawing.Point(173, 227);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbTypes.Size = new System.Drawing.Size(155, 35);
            this.cbTypes.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbTypes.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbTypes.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypes.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbTypes.TabIndex = 49;
            this.cbTypes.Visible = false;
            this.cbTypes.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarTodayDate = new System.DateTime(2026, 9, 15, 0, 0, 0, 0);
            this.dtpDate.CornerRoundingRadius = 20F;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(173, 227);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dtpDate.Size = new System.Drawing.Size(155, 35);
            this.dtpDate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDate.StateCommon.Border.Rounding = 20F;
            this.dtpDate.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.TabIndex = 50;
            this.dtpDate.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.Appointment_512;
            this.pictureBox1.Location = new System.Drawing.Point(312, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.CornerRoundingRadius = 20F;
            this.btnSearch.Location = new System.Drawing.Point(334, 221);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSearch.Size = new System.Drawing.Size(43, 46);
            this.btnSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateCommon.Border.Rounding = 20F;
            this.btnSearch.TabIndex = 58;
            this.btnSearch.Values.Image = global::HMS.Properties.Resources.Search_32;
            this.btnSearch.Values.Text = "";
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmManageAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.cbStatuses);
            this.Controls.Add(this.cbDaysOfWeek);
            this.Controls.Add(this.dtpDate);
            this.Name = "frmManageAppointments";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "Manage Appointments";
            this.Load += new System.EventHandler(this.frmManageAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.cmsAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbStatuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDaysOfWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Youssef.WinForms.Controls.JOTextBox tbFilter;
        private Krypton.Toolkit.KryptonButton btnReload;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox cbFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel lblRowCount;
        private Youssef.WinForms.Controls.JODataGridView dgvAppointments;
        private Krypton.Toolkit.KryptonComboBox cbStatuses;
        private Krypton.Toolkit.KryptonComboBox cbDaysOfWeek;
        private System.Windows.Forms.ContextMenuStrip cmsAppointments;
        private System.Windows.Forms.ToolStripMenuItem showDetailstoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem schedulenewappointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem makevisitedtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patienthistorytoolStripMenuItem;
        private Krypton.Toolkit.KryptonComboBox cbTypes;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDate;
        private System.Windows.Forms.ToolStripMenuItem rescheduletoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem canceltoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private Krypton.Toolkit.KryptonButton btnSearch;
    }
}
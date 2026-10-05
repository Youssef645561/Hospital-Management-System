namespace HMS.Appointment.Control
{
    partial class ctrlPatientAppointmentsHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvPatientAppointments = new Youssef.WinForms.Controls.JODataGridView();
            this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showDetailstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.schedulenewappointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.checkintoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rescheduletoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.canceltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRowCount = new Krypton.Toolkit.KryptonLabel();
            this.gbAppointments = new Krypton.Toolkit.KryptonGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientAppointments)).BeginInit();
            this.cmsAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbAppointments.Panel)).BeginInit();
            this.gbAppointments.Panel.SuspendLayout();
            this.gbAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPatientAppointments
            // 
            this.dgvPatientAppointments.AllowUserToAddRows = false;
            this.dgvPatientAppointments.AllowUserToDeleteRows = false;
            this.dgvPatientAppointments.AllowUserToOrderColumns = true;
            this.dgvPatientAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPatientAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatientAppointments.ColumnHeadersHeight = 30;
            this.dgvPatientAppointments.ContextMenuStrip = this.cmsAppointments;
            this.dgvPatientAppointments.Location = new System.Drawing.Point(3, 3);
            this.dgvPatientAppointments.MultiSelect = false;
            this.dgvPatientAppointments.Name = "dgvPatientAppointments";
            this.dgvPatientAppointments.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvPatientAppointments.ReadOnly = true;
            this.dgvPatientAppointments.RowHeadersVisible = false;
            this.dgvPatientAppointments.RowHeadersWidth = 40;
            this.dgvPatientAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientAppointments.Size = new System.Drawing.Size(734, 287);
            this.dgvPatientAppointments.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvPatientAppointments.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvPatientAppointments.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatientAppointments.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dgvPatientAppointments.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatientAppointments.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvPatientAppointments.TabIndex = 0;
            this.dgvPatientAppointments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPatientAppointments_CellFormatting);
            // 
            // cmsAppointments
            // 
            this.cmsAppointments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadtoolStripMenuItem,
            this.toolStripSeparator1,
            this.showDetailstoolStripMenuItem,
            this.toolStripSeparator2,
            this.schedulenewappointmentToolStripMenuItem,
            this.toolStripSeparator4,
            this.checkintoolStripMenuItem,
            this.toolStripSeparator3,
            this.rescheduletoolStripMenuItem,
            this.toolStripSeparator5,
            this.canceltoolStripMenuItem});
            this.cmsAppointments.Name = "cmsPeople";
            this.cmsAppointments.Size = new System.Drawing.Size(288, 262);
            this.cmsAppointments.Opening += new System.ComponentModel.CancelEventHandler(this.cmsAppointments_Opening);
            // 
            // reloadtoolStripMenuItem
            // 
            this.reloadtoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadtoolStripMenuItem.Image = global::HMS.Properties.Resources.Reload_32;
            this.reloadtoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reloadtoolStripMenuItem.Name = "reloadtoolStripMenuItem";
            this.reloadtoolStripMenuItem.Size = new System.Drawing.Size(287, 38);
            this.reloadtoolStripMenuItem.Text = "Reload";
            this.reloadtoolStripMenuItem.Click += new System.EventHandler(this.reloadtoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(284, 6);
            // 
            // showDetailstoolStripMenuItem
            // 
            this.showDetailstoolStripMenuItem.Enabled = false;
            this.showDetailstoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailstoolStripMenuItem.Image = global::HMS.Properties.Resources.Appointment_Details_32;
            this.showDetailstoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailstoolStripMenuItem.Name = "showDetailstoolStripMenuItem";
            this.showDetailstoolStripMenuItem.Size = new System.Drawing.Size(287, 38);
            this.showDetailstoolStripMenuItem.Text = "Show Details";
            this.showDetailstoolStripMenuItem.Click += new System.EventHandler(this.showDetailstoolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(284, 6);
            // 
            // schedulenewappointmentToolStripMenuItem
            // 
            this.schedulenewappointmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulenewappointmentToolStripMenuItem.Image = global::HMS.Properties.Resources.Schedule_New_Appointment_32;
            this.schedulenewappointmentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.schedulenewappointmentToolStripMenuItem.Name = "schedulenewappointmentToolStripMenuItem";
            this.schedulenewappointmentToolStripMenuItem.Size = new System.Drawing.Size(287, 38);
            this.schedulenewappointmentToolStripMenuItem.Text = "Schedule New Appointment";
            this.schedulenewappointmentToolStripMenuItem.Click += new System.EventHandler(this.schedulenewappointmentToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(284, 6);
            // 
            // checkintoolStripMenuItem
            // 
            this.checkintoolStripMenuItem.Enabled = false;
            this.checkintoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkintoolStripMenuItem.Image = global::HMS.Properties.Resources.Waiting_32;
            this.checkintoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.checkintoolStripMenuItem.Name = "checkintoolStripMenuItem";
            this.checkintoolStripMenuItem.Size = new System.Drawing.Size(287, 38);
            this.checkintoolStripMenuItem.Text = "Check In";
            this.checkintoolStripMenuItem.Click += new System.EventHandler(this.checkintoolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(284, 6);
            // 
            // rescheduletoolStripMenuItem
            // 
            this.rescheduletoolStripMenuItem.Enabled = false;
            this.rescheduletoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rescheduletoolStripMenuItem.Image = global::HMS.Properties.Resources.Reschedule_Appointment_32;
            this.rescheduletoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rescheduletoolStripMenuItem.Name = "rescheduletoolStripMenuItem";
            this.rescheduletoolStripMenuItem.Size = new System.Drawing.Size(287, 38);
            this.rescheduletoolStripMenuItem.Text = "Reschedule";
            this.rescheduletoolStripMenuItem.Click += new System.EventHandler(this.rescheduletoolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(284, 6);
            // 
            // canceltoolStripMenuItem
            // 
            this.canceltoolStripMenuItem.Enabled = false;
            this.canceltoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canceltoolStripMenuItem.Image = global::HMS.Properties.Resources.Cancel_Appointment_32;
            this.canceltoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.canceltoolStripMenuItem.Name = "canceltoolStripMenuItem";
            this.canceltoolStripMenuItem.Size = new System.Drawing.Size(287, 38);
            this.canceltoolStripMenuItem.Text = "Cancel";
            this.canceltoolStripMenuItem.Click += new System.EventHandler(this.canceltoolStripMenuItem_Click);
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowCount.Location = new System.Drawing.Point(3, 327);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(24, 20);
            this.lblRowCount.TabIndex = 1;
            this.lblRowCount.Values.Text = "#0";
            // 
            // gbAppointments
            // 
            this.gbAppointments.CaptionOverlap = 1D;
            this.gbAppointments.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbAppointments.Location = new System.Drawing.Point(2, 3);
            this.gbAppointments.Name = "gbAppointments";
            this.gbAppointments.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbAppointments.Panel
            // 
            this.gbAppointments.Panel.Controls.Add(this.dgvPatientAppointments);
            this.gbAppointments.Size = new System.Drawing.Size(744, 318);
            this.gbAppointments.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbAppointments.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbAppointments.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.gbAppointments.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAppointments.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAppointments.TabIndex = 34;
            this.gbAppointments.Values.Description = "Patient ID = ???";
            this.gbAppointments.Values.Heading = "Appointments";
            // 
            // ctrlPatientAppointmentsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAppointments);
            this.Controls.Add(this.lblRowCount);
            this.Name = "ctrlPatientAppointmentsHistory";
            this.Size = new System.Drawing.Size(750, 350);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientAppointments)).EndInit();
            this.cmsAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbAppointments.Panel)).EndInit();
            this.gbAppointments.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbAppointments)).EndInit();
            this.gbAppointments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Youssef.WinForms.Controls.JODataGridView dgvPatientAppointments;
        private Krypton.Toolkit.KryptonLabel lblRowCount;
        private System.Windows.Forms.ContextMenuStrip cmsAppointments;
        private System.Windows.Forms.ToolStripMenuItem showDetailstoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem schedulenewappointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem checkintoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem rescheduletoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem canceltoolStripMenuItem;
        private Krypton.Toolkit.KryptonGroupBox gbAppointments;
        private System.Windows.Forms.ToolStripMenuItem reloadtoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

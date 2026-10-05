namespace HMS.Patient_Charge
{
    partial class frmManagePatientCharges
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
            this.btnReload = new Krypton.Toolkit.KryptonButton();
            this.tbFilter = new Youssef.WinForms.Controls.JOTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.cbFilter = new Krypton.Toolkit.KryptonComboBox();
            this.lblRowCount = new Krypton.Toolkit.KryptonLabel();
            this.dgvPatientCharges = new Youssef.WinForms.Controls.JODataGridView();
            this.cmsPatientCharges = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cbStatus = new Krypton.Toolkit.KryptonComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showDetailstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performpaymenttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CanceltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentsHistorytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientCharges)).BeginInit();
            this.cmsPatientCharges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.CornerRoundingRadius = 20F;
            this.btnReload.Location = new System.Drawing.Point(674, 216);
            this.btnReload.Name = "btnReload";
            this.btnReload.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnReload.Size = new System.Drawing.Size(98, 51);
            this.btnReload.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReload.StateCommon.Border.Rounding = 20F;
            this.btnReload.TabIndex = 27;
            this.btnReload.Values.Image = global::HMS.Properties.Resources.Reload_32;
            this.btnReload.Values.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.AllowLetters = false;
            this.tbFilter.AllowSpecialCharacters = false;
            this.tbFilter.CornerRoundingRadius = 20F;
            this.tbFilter.Location = new System.Drawing.Point(173, 232);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbFilter.Size = new System.Drawing.Size(155, 35);
            this.tbFilter.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbFilter.StateCommon.Border.Rounding = 20F;
            this.tbFilter.TabIndex = 22;
            this.tbFilter.Visible = false;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(195, 138);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(394, 43);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 25;
            this.kryptonLabel1.Values.Text = "Manage Patient Charges";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.DropDownWidth = 143;
            this.cbFilter.IntegralHeight = false;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "ID",
            "Appointment ID",
            "Status"});
            this.cbFilter.Location = new System.Drawing.Point(12, 232);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbFilter.Size = new System.Drawing.Size(155, 35);
            this.cbFilter.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbFilter.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbFilter.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbFilter.TabIndex = 23;
            this.cbFilter.Text = "None";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowCount.Location = new System.Drawing.Point(12, 579);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(24, 20);
            this.lblRowCount.TabIndex = 20;
            this.lblRowCount.Values.Text = "#0";
            // 
            // dgvPatientCharges
            // 
            this.dgvPatientCharges.AllowUserToAddRows = false;
            this.dgvPatientCharges.AllowUserToDeleteRows = false;
            this.dgvPatientCharges.AllowUserToOrderColumns = true;
            this.dgvPatientCharges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatientCharges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientCharges.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPatientCharges.ColumnHeadersHeight = 30;
            this.dgvPatientCharges.ContextMenuStrip = this.cmsPatientCharges;
            this.dgvPatientCharges.Location = new System.Drawing.Point(12, 273);
            this.dgvPatientCharges.MultiSelect = false;
            this.dgvPatientCharges.Name = "dgvPatientCharges";
            this.dgvPatientCharges.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvPatientCharges.ReadOnly = true;
            this.dgvPatientCharges.RowHeadersVisible = false;
            this.dgvPatientCharges.RowHeadersWidth = 40;
            this.dgvPatientCharges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientCharges.Size = new System.Drawing.Size(760, 300);
            this.dgvPatientCharges.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvPatientCharges.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvPatientCharges.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatientCharges.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dgvPatientCharges.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatientCharges.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvPatientCharges.TabIndex = 19;
            this.dgvPatientCharges.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPatientCharges_CellFormatting);
            this.dgvPatientCharges.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvPatientCharges_Scroll);
            // 
            // cmsPatientCharges
            // 
            this.cmsPatientCharges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsPatientCharges.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailstoolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewToolStripMenuItem,
            this.toolStripSeparator3,
            this.performpaymenttoolStripMenuItem,
            this.toolStripSeparator4,
            this.CanceltoolStripMenuItem,
            this.toolStripSeparator2,
            this.PaymentsHistorytoolStripMenuItem});
            this.cmsPatientCharges.Name = "cmsPeople";
            this.cmsPatientCharges.Size = new System.Drawing.Size(215, 240);
            this.cmsPatientCharges.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPatientCharges_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(211, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.DropDownWidth = 143;
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.Location = new System.Drawing.Point(173, 232);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbStatus.Size = new System.Drawing.Size(155, 35);
            this.cbStatus.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbStatus.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbStatus.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbStatus.TabIndex = 24;
            this.cbStatus.Visible = false;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.Patient_Charges_512;
            this.pictureBox1.Location = new System.Drawing.Point(312, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // showDetailstoolStripMenuItem
            // 
            this.showDetailstoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailstoolStripMenuItem.Image = global::HMS.Properties.Resources.Details_32;
            this.showDetailstoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailstoolStripMenuItem.Name = "showDetailstoolStripMenuItem";
            this.showDetailstoolStripMenuItem.Size = new System.Drawing.Size(214, 38);
            this.showDetailstoolStripMenuItem.Text = "Show Details";
            this.showDetailstoolStripMenuItem.Click += new System.EventHandler(this.showDetailstoolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewToolStripMenuItem.Image = global::HMS.Properties.Resources.Add_32;
            this.addNewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(214, 38);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // performpaymenttoolStripMenuItem
            // 
            this.performpaymenttoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performpaymenttoolStripMenuItem.Image = global::HMS.Properties.Resources.Add_Payment_32;
            this.performpaymenttoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.performpaymenttoolStripMenuItem.Name = "performpaymenttoolStripMenuItem";
            this.performpaymenttoolStripMenuItem.Size = new System.Drawing.Size(214, 38);
            this.performpaymenttoolStripMenuItem.Text = "Perform Payment";
            this.performpaymenttoolStripMenuItem.Click += new System.EventHandler(this.performpaymenttoolStripMenuItem_Click);
            // 
            // CanceltoolStripMenuItem
            // 
            this.CanceltoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanceltoolStripMenuItem.Image = global::HMS.Properties.Resources.Delete_32;
            this.CanceltoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CanceltoolStripMenuItem.Name = "CanceltoolStripMenuItem";
            this.CanceltoolStripMenuItem.Size = new System.Drawing.Size(214, 38);
            this.CanceltoolStripMenuItem.Text = "Cancel";
            this.CanceltoolStripMenuItem.Click += new System.EventHandler(this.CanceltoolStripMenuItem_Click);
            // 
            // PaymentsHistorytoolStripMenuItem
            // 
            this.PaymentsHistorytoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentsHistorytoolStripMenuItem.Image = global::HMS.Properties.Resources.Patient_History_32;
            this.PaymentsHistorytoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PaymentsHistorytoolStripMenuItem.Name = "PaymentsHistorytoolStripMenuItem";
            this.PaymentsHistorytoolStripMenuItem.Size = new System.Drawing.Size(214, 38);
            this.PaymentsHistorytoolStripMenuItem.Text = "Payments History";
            this.PaymentsHistorytoolStripMenuItem.Click += new System.EventHandler(this.PaymentsHistorytoolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(211, 6);
            // 
            // frmManagePatientCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.dgvPatientCharges);
            this.Controls.Add(this.cbStatus);
            this.Name = "frmManagePatientCharges";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "Manage Patient Charges";
            this.Load += new System.EventHandler(this.frmManagePatientCharges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientCharges)).EndInit();
            this.cmsPatientCharges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnReload;
        private Youssef.WinForms.Controls.JOTextBox tbFilter;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox cbFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel lblRowCount;
        private Youssef.WinForms.Controls.JODataGridView dgvPatientCharges;
        private Krypton.Toolkit.KryptonComboBox cbStatus;
        private System.Windows.Forms.ContextMenuStrip cmsPatientCharges;
        private System.Windows.Forms.ToolStripMenuItem showDetailstoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CanceltoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performpaymenttoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem PaymentsHistorytoolStripMenuItem;
    }
}
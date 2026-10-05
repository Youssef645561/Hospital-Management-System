namespace HMS.Lab_Test
{
    partial class frmManageLabTests
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
            this.cbTestTypes = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.cbFilter = new Krypton.Toolkit.KryptonComboBox();
            this.lblRowCount = new Krypton.Toolkit.KryptonLabel();
            this.dgvLabTests = new Youssef.WinForms.Controls.JODataGridView();
            this.cmsLabTests = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StartTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CompleteTesttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ViewResulttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.patienthistorytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbStatuses = new Krypton.Toolkit.KryptonComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CanceltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.cbTestTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabTests)).BeginInit();
            this.cmsLabTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatuses)).BeginInit();
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
            // cbTestTypes
            // 
            this.cbTestTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTestTypes.DropDownWidth = 143;
            this.cbTestTypes.IntegralHeight = false;
            this.cbTestTypes.Location = new System.Drawing.Point(173, 232);
            this.cbTestTypes.Name = "cbTestTypes";
            this.cbTestTypes.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbTestTypes.Size = new System.Drawing.Size(155, 35);
            this.cbTestTypes.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbTestTypes.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbTestTypes.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTestTypes.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbTestTypes.TabIndex = 26;
            this.cbTestTypes.Visible = false;
            this.cbTestTypes.SelectedIndexChanged += new System.EventHandler(this.cbTestTypes_SelectedIndexChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(243, 138);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(299, 43);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 25;
            this.kryptonLabel1.Values.Text = "Manage Lab Tests";
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
            "Status",
            "Test Type"});
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
            // dgvLabTests
            // 
            this.dgvLabTests.AllowUserToAddRows = false;
            this.dgvLabTests.AllowUserToDeleteRows = false;
            this.dgvLabTests.AllowUserToOrderColumns = true;
            this.dgvLabTests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLabTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLabTests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLabTests.ColumnHeadersHeight = 30;
            this.dgvLabTests.ContextMenuStrip = this.cmsLabTests;
            this.dgvLabTests.Location = new System.Drawing.Point(12, 273);
            this.dgvLabTests.MultiSelect = false;
            this.dgvLabTests.Name = "dgvLabTests";
            this.dgvLabTests.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvLabTests.ReadOnly = true;
            this.dgvLabTests.RowHeadersVisible = false;
            this.dgvLabTests.RowHeadersWidth = 40;
            this.dgvLabTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLabTests.Size = new System.Drawing.Size(760, 300);
            this.dgvLabTests.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvLabTests.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvLabTests.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLabTests.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dgvLabTests.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLabTests.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvLabTests.TabIndex = 19;
            this.dgvLabTests.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLabTests_CellFormatting);
            this.dgvLabTests.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvLabTests_Scroll);
            // 
            // cmsLabTests
            // 
            this.cmsLabTests.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsLabTests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewResulttoolStripMenuItem,
            this.toolStripSeparator1,
            this.StartTestToolStripMenuItem,
            this.toolStripSeparator2,
            this.CompleteTesttoolStripMenuItem,
            this.toolStripSeparator3,
            this.CanceltoolStripMenuItem,
            this.toolStripSeparator4,
            this.patienthistorytoolStripMenuItem});
            this.cmsLabTests.Name = "cmsPeople";
            this.cmsLabTests.Size = new System.Drawing.Size(297, 240);
            this.cmsLabTests.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLabTests_Opening);
            // 
            // StartTestToolStripMenuItem
            // 
            this.StartTestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTestToolStripMenuItem.Image = global::HMS.Properties.Resources.Search_32;
            this.StartTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StartTestToolStripMenuItem.Name = "StartTestToolStripMenuItem";
            this.StartTestToolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.StartTestToolStripMenuItem.Text = "Start Test";
            this.StartTestToolStripMenuItem.Click += new System.EventHandler(this.StartTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(293, 6);
            // 
            // CompleteTesttoolStripMenuItem
            // 
            this.CompleteTesttoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteTesttoolStripMenuItem.Image = global::HMS.Properties.Resources.Checkmark_32;
            this.CompleteTesttoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CompleteTesttoolStripMenuItem.Name = "CompleteTesttoolStripMenuItem";
            this.CompleteTesttoolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.CompleteTesttoolStripMenuItem.Text = "Complete Test";
            this.CompleteTesttoolStripMenuItem.Click += new System.EventHandler(this.CompleteTesttoolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(293, 6);
            // 
            // ViewResulttoolStripMenuItem
            // 
            this.ViewResulttoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewResulttoolStripMenuItem.Image = global::HMS.Properties.Resources.Details_32;
            this.ViewResulttoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewResulttoolStripMenuItem.Name = "ViewResulttoolStripMenuItem";
            this.ViewResulttoolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.ViewResulttoolStripMenuItem.Text = "View Result";
            this.ViewResulttoolStripMenuItem.Click += new System.EventHandler(this.ViewResulttoolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(293, 6);
            // 
            // patienthistorytoolStripMenuItem
            // 
            this.patienthistorytoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patienthistorytoolStripMenuItem.Image = global::HMS.Properties.Resources.Patient_History_32;
            this.patienthistorytoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patienthistorytoolStripMenuItem.Name = "patienthistorytoolStripMenuItem";
            this.patienthistorytoolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.patienthistorytoolStripMenuItem.Text = "Patient Appointments History";
            // 
            // cbStatuses
            // 
            this.cbStatuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatuses.DropDownWidth = 143;
            this.cbStatuses.IntegralHeight = false;
            this.cbStatuses.Items.AddRange(new object[] {
            "All",
            "Pending",
            "InProgress",
            "Completed",
            "Cancelled"});
            this.cbStatuses.Location = new System.Drawing.Point(173, 232);
            this.cbStatuses.Name = "cbStatuses";
            this.cbStatuses.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbStatuses.Size = new System.Drawing.Size(155, 35);
            this.cbStatuses.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbStatuses.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbStatuses.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatuses.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbStatuses.TabIndex = 24;
            this.cbStatuses.Text = "All";
            this.cbStatuses.Visible = false;
            this.cbStatuses.SelectedIndexChanged += new System.EventHandler(this.cbStatuses_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.Laboratory_512;
            this.pictureBox1.Location = new System.Drawing.Point(312, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // CanceltoolStripMenuItem
            // 
            this.CanceltoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanceltoolStripMenuItem.Image = global::HMS.Properties.Resources.Delete_32;
            this.CanceltoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CanceltoolStripMenuItem.Name = "CanceltoolStripMenuItem";
            this.CanceltoolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.CanceltoolStripMenuItem.Text = "Cancel";
            this.CanceltoolStripMenuItem.Click += new System.EventHandler(this.CanceltoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(293, 6);
            // 
            // frmManageLabTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbTestTypes);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.dgvLabTests);
            this.Controls.Add(this.cbStatuses);
            this.Name = "frmManageLabTests";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "Manage Lab Tests";
            this.Load += new System.EventHandler(this.frmManageLabTests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbTestTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabTests)).EndInit();
            this.cmsLabTests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbStatuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnReload;
        private Youssef.WinForms.Controls.JOTextBox tbFilter;
        private Krypton.Toolkit.KryptonComboBox cbTestTypes;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox cbFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel lblRowCount;
        private Youssef.WinForms.Controls.JODataGridView dgvLabTests;
        private Krypton.Toolkit.KryptonComboBox cbStatuses;
        private System.Windows.Forms.ContextMenuStrip cmsLabTests;
        private System.Windows.Forms.ToolStripMenuItem StartTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CompleteTesttoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ViewResulttoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem patienthistorytoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CanceltoolStripMenuItem;
    }
}
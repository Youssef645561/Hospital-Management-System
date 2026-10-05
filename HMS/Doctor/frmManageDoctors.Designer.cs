namespace HMS.Doctors
{
    partial class frmManageDoctors
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
            this.cbDepartments = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.cbFilter = new Krypton.Toolkit.KryptonComboBox();
            this.lblRowCount = new Krypton.Toolkit.KryptonLabel();
            this.dgvDoctors = new Youssef.WinForms.Controls.JODataGridView();
            this.cmsDoctors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.edittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DeletetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbSpecializations = new Krypton.Toolkit.KryptonComboBox();
            this.cbActive = new Krypton.Toolkit.KryptonComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.cmsDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSpecializations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActive)).BeginInit();
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
            // cbDepartments
            // 
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.DropDownWidth = 143;
            this.cbDepartments.IntegralHeight = false;
            this.cbDepartments.Location = new System.Drawing.Point(173, 232);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbDepartments.Size = new System.Drawing.Size(155, 35);
            this.cbDepartments.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbDepartments.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbDepartments.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartments.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbDepartments.TabIndex = 26;
            this.cbDepartments.Visible = false;
            this.cbDepartments.SelectedIndexChanged += new System.EventHandler(this.cbDepartments_SelectedIndexChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(259, 138);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(267, 43);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 25;
            this.kryptonLabel1.Values.Text = "Manage Doctors";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.DropDownWidth = 143;
            this.cbFilter.IntegralHeight = false;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "ID",
            "Full Name",
            "Department",
            "Specialization",
            "Active"});
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
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.AllowUserToOrderColumns = true;
            this.dgvDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDoctors.ColumnHeadersHeight = 30;
            this.dgvDoctors.ContextMenuStrip = this.cmsDoctors;
            this.dgvDoctors.Location = new System.Drawing.Point(12, 273);
            this.dgvDoctors.MultiSelect = false;
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersVisible = false;
            this.dgvDoctors.RowHeadersWidth = 40;
            this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctors.Size = new System.Drawing.Size(760, 300);
            this.dgvDoctors.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvDoctors.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvDoctors.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDoctors.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dgvDoctors.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDoctors.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvDoctors.TabIndex = 19;
            this.dgvDoctors.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDoctors_CellFormatting);
            this.dgvDoctors.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvDoctors_Scroll);
            // 
            // cmsDoctors
            // 
            this.cmsDoctors.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsDoctors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailstoolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewToolStripMenuItem,
            this.toolStripSeparator2,
            this.edittoolStripMenuItem,
            this.toolStripSeparator3,
            this.DeletetoolStripMenuItem});
            this.cmsDoctors.Name = "cmsPeople";
            this.cmsDoctors.Size = new System.Drawing.Size(184, 174);
            // 
            // showDetailstoolStripMenuItem
            // 
            this.showDetailstoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailstoolStripMenuItem.Image = global::HMS.Properties.Resources.Doctor_Details_32;
            this.showDetailstoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailstoolStripMenuItem.Name = "showDetailstoolStripMenuItem";
            this.showDetailstoolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.showDetailstoolStripMenuItem.Text = "Show Details";
            this.showDetailstoolStripMenuItem.Click += new System.EventHandler(this.showDetailstoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewToolStripMenuItem.Image = global::HMS.Properties.Resources.Add_Doctor_32;
            this.addNewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // edittoolStripMenuItem
            // 
            this.edittoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edittoolStripMenuItem.Image = global::HMS.Properties.Resources.Edit_Doctor_32;
            this.edittoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.edittoolStripMenuItem.Name = "edittoolStripMenuItem";
            this.edittoolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.edittoolStripMenuItem.Text = "Edit";
            this.edittoolStripMenuItem.Click += new System.EventHandler(this.edittoolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // DeletetoolStripMenuItem
            // 
            this.DeletetoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletetoolStripMenuItem.Image = global::HMS.Properties.Resources.Delete_Doctor_32;
            this.DeletetoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeletetoolStripMenuItem.Name = "DeletetoolStripMenuItem";
            this.DeletetoolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.DeletetoolStripMenuItem.Text = "Delete";
            this.DeletetoolStripMenuItem.Click += new System.EventHandler(this.DeletetoolStripMenuItem_Click);
            // 
            // cbSpecializations
            // 
            this.cbSpecializations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecializations.DropDownWidth = 143;
            this.cbSpecializations.IntegralHeight = false;
            this.cbSpecializations.Location = new System.Drawing.Point(173, 232);
            this.cbSpecializations.Name = "cbSpecializations";
            this.cbSpecializations.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbSpecializations.Size = new System.Drawing.Size(155, 35);
            this.cbSpecializations.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbSpecializations.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbSpecializations.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpecializations.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbSpecializations.TabIndex = 29;
            this.cbSpecializations.Visible = false;
            this.cbSpecializations.SelectedIndexChanged += new System.EventHandler(this.cbSpecializations_SelectedIndexChanged);
            // 
            // cbActive
            // 
            this.cbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActive.DropDownWidth = 143;
            this.cbActive.IntegralHeight = false;
            this.cbActive.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
            this.cbActive.Location = new System.Drawing.Point(173, 232);
            this.cbActive.Name = "cbActive";
            this.cbActive.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbActive.Size = new System.Drawing.Size(155, 35);
            this.cbActive.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbActive.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbActive.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActive.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbActive.TabIndex = 30;
            this.cbActive.Text = "All";
            this.cbActive.Visible = false;
            this.cbActive.SelectedIndexChanged += new System.EventHandler(this.cbActive_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.Doctors_512;
            this.pictureBox1.Location = new System.Drawing.Point(312, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.dgvDoctors);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.cbSpecializations);
            this.Controls.Add(this.cbActive);
            this.Name = "frmManageDoctors";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "Manage Doctors";
            this.Load += new System.EventHandler(this.frmManageDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.cmsDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbSpecializations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnReload;
        private Youssef.WinForms.Controls.JOTextBox tbFilter;
        private Krypton.Toolkit.KryptonComboBox cbDepartments;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox cbFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel lblRowCount;
        private Youssef.WinForms.Controls.JODataGridView dgvDoctors;
        private System.Windows.Forms.ContextMenuStrip cmsDoctors;
        private System.Windows.Forms.ToolStripMenuItem showDetailstoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem edittoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem DeletetoolStripMenuItem;
        private Krypton.Toolkit.KryptonComboBox cbSpecializations;
        private Krypton.Toolkit.KryptonComboBox cbActive;
    }
}
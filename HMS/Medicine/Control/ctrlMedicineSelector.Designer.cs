namespace HMS.Medicine.Control
{
    partial class ctrlMedicineSelector
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
            this.lblRowCount = new Krypton.Toolkit.KryptonLabel();
            this.dgvMedicines = new Youssef.WinForms.Controls.JODataGridView();
            this.cmsMedicines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.edittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DeletetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbFilter = new Youssef.WinForms.Controls.JOTextBox();
            this.cbFilter = new Krypton.Toolkit.KryptonComboBox();
            this.cbDosageForms = new Krypton.Toolkit.KryptonComboBox();
            this.cbActive = new Krypton.Toolkit.KryptonComboBox();
            this.gbFilter = new Krypton.Toolkit.KryptonGroupBox();
            this.btnReload = new Krypton.Toolkit.KryptonButton();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.cmsMedicines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDosageForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbFilter.Panel)).BeginInit();
            this.gbFilter.Panel.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowCount.Location = new System.Drawing.Point(3, 477);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(24, 20);
            this.lblRowCount.TabIndex = 34;
            this.lblRowCount.Values.Text = "#0";
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.AllowUserToAddRows = false;
            this.dgvMedicines.AllowUserToDeleteRows = false;
            this.dgvMedicines.AllowUserToOrderColumns = true;
            this.dgvMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicines.ColumnHeadersHeight = 30;
            this.dgvMedicines.ContextMenuStrip = this.cmsMedicines;
            this.dgvMedicines.Location = new System.Drawing.Point(3, 91);
            this.dgvMedicines.MultiSelect = false;
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvMedicines.ReadOnly = true;
            this.dgvMedicines.RowHeadersVisible = false;
            this.dgvMedicines.RowHeadersWidth = 40;
            this.dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicines.Size = new System.Drawing.Size(694, 384);
            this.dgvMedicines.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvMedicines.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvMedicines.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMedicines.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dgvMedicines.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMedicines.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvMedicines.TabIndex = 33;
            this.dgvMedicines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicines_CellDoubleClick);
            this.dgvMedicines.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMedicines_CellFormatting);
            this.dgvMedicines.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvMedicines_Scroll);
            // 
            // cmsMedicines
            // 
            this.cmsMedicines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsMedicines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailstoolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewToolStripMenuItem,
            this.toolStripSeparator2,
            this.edittoolStripMenuItem,
            this.toolStripSeparator3,
            this.DeletetoolStripMenuItem});
            this.cmsMedicines.Name = "cmsPeople";
            this.cmsMedicines.Size = new System.Drawing.Size(184, 174);
            // 
            // showDetailstoolStripMenuItem
            // 
            this.showDetailstoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailstoolStripMenuItem.Image = global::HMS.Properties.Resources.Medicine_Details_32;
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
            this.addNewToolStripMenuItem.Image = global::HMS.Properties.Resources.Add_Medicine_32;
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
            this.edittoolStripMenuItem.Image = global::HMS.Properties.Resources.Edit_Medicine_32;
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
            this.DeletetoolStripMenuItem.Image = global::HMS.Properties.Resources.Delete_Medicine_32;
            this.DeletetoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeletetoolStripMenuItem.Name = "DeletetoolStripMenuItem";
            this.DeletetoolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.DeletetoolStripMenuItem.Text = "Delete";
            // 
            // tbFilter
            // 
            this.tbFilter.AllowSpecialCharacters = false;
            this.tbFilter.CornerRoundingRadius = 20F;
            this.tbFilter.Location = new System.Drawing.Point(164, 11);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbFilter.Size = new System.Drawing.Size(155, 35);
            this.tbFilter.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbFilter.StateCommon.Border.Rounding = 20F;
            this.tbFilter.TabIndex = 40;
            this.tbFilter.Visible = false;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.DropDownWidth = 143;
            this.cbFilter.IntegralHeight = false;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "ID",
            "Name",
            "Dosage Form",
            "Strength",
            "Active"});
            this.cbFilter.Location = new System.Drawing.Point(3, 11);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbFilter.Size = new System.Drawing.Size(155, 35);
            this.cbFilter.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbFilter.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbFilter.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbFilter.TabIndex = 41;
            this.cbFilter.Text = "None";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // cbDosageForms
            // 
            this.cbDosageForms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDosageForms.DropDownWidth = 143;
            this.cbDosageForms.IntegralHeight = false;
            this.cbDosageForms.Location = new System.Drawing.Point(164, 11);
            this.cbDosageForms.Name = "cbDosageForms";
            this.cbDosageForms.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbDosageForms.Size = new System.Drawing.Size(155, 35);
            this.cbDosageForms.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbDosageForms.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbDosageForms.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDosageForms.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbDosageForms.TabIndex = 42;
            this.cbDosageForms.Visible = false;
            this.cbDosageForms.SelectedIndexChanged += new System.EventHandler(this.cbDosageForms_SelectedIndexChanged);
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
            this.cbActive.Location = new System.Drawing.Point(164, 11);
            this.cbActive.Name = "cbActive";
            this.cbActive.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbActive.Size = new System.Drawing.Size(155, 35);
            this.cbActive.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbActive.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbActive.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActive.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbActive.TabIndex = 43;
            this.cbActive.Text = "All";
            this.cbActive.Visible = false;
            this.cbActive.SelectedIndexChanged += new System.EventHandler(this.cbActive_SelectedIndexChanged);
            // 
            // gbFilter
            // 
            this.gbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilter.CaptionOverlap = 1D;
            this.gbFilter.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbFilter.Panel
            // 
            this.gbFilter.Panel.Controls.Add(this.btnReload);
            this.gbFilter.Panel.Controls.Add(this.btnSearch);
            this.gbFilter.Panel.Controls.Add(this.tbFilter);
            this.gbFilter.Panel.Controls.Add(this.cbActive);
            this.gbFilter.Panel.Controls.Add(this.cbFilter);
            this.gbFilter.Panel.Controls.Add(this.cbDosageForms);
            this.gbFilter.Size = new System.Drawing.Size(694, 82);
            this.gbFilter.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbFilter.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbFilter.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.TabIndex = 44;
            this.gbFilter.Values.Heading = "Filter";
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.CornerRoundingRadius = 20F;
            this.btnReload.Location = new System.Drawing.Point(588, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnReload.Size = new System.Drawing.Size(98, 51);
            this.btnReload.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReload.StateCommon.Border.Rounding = 20F;
            this.btnReload.TabIndex = 46;
            this.btnReload.Values.Image = global::HMS.Properties.Resources.Reload_32;
            this.btnReload.Values.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.CornerRoundingRadius = 20F;
            this.btnSearch.Location = new System.Drawing.Point(324, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSearch.Size = new System.Drawing.Size(43, 46);
            this.btnSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateCommon.Border.Rounding = 20F;
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Values.Image = global::HMS.Properties.Resources.Search_32;
            this.btnSearch.Values.Text = "";
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrlMedicineSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.dgvMedicines);
            this.MinimumSize = new System.Drawing.Size(485, 200);
            this.Name = "ctrlMedicineSelector";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.cmsMedicines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDosageForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbFilter.Panel)).EndInit();
            this.gbFilter.Panel.ResumeLayout(false);
            this.gbFilter.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbFilter)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblRowCount;
        private Youssef.WinForms.Controls.JODataGridView dgvMedicines;
        private Youssef.WinForms.Controls.JOTextBox tbFilter;
        private Krypton.Toolkit.KryptonComboBox cbFilter;
        private Krypton.Toolkit.KryptonComboBox cbDosageForms;
        private Krypton.Toolkit.KryptonComboBox cbActive;
        private Krypton.Toolkit.KryptonGroupBox gbFilter;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.ContextMenuStrip cmsMedicines;
        private System.Windows.Forms.ToolStripMenuItem showDetailstoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem edittoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem DeletetoolStripMenuItem;
        private Krypton.Toolkit.KryptonButton btnReload;
    }
}

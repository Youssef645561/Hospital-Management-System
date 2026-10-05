namespace HMS.Appointment
{
    partial class frmManageWaitings
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
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblRowCount = new Krypton.Toolkit.KryptonLabel();
            this.dgvWaitings = new Youssef.WinForms.Controls.JODataGridView();
            this.cmsWaitings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startvisittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFilter = new Youssef.WinForms.Controls.JOTextBox();
            this.cbFilter = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitings)).BeginInit();
            this.cmsWaitings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter)).BeginInit();
            this.SuspendLayout();
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
            this.btnReload.TabIndex = 27;
            this.btnReload.Values.Image = global::HMS.Properties.Resources.Reload_32;
            this.btnReload.Values.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(252, 138);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(281, 43);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 25;
            this.kryptonLabel1.Values.Text = "Manage Waitings";
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
            // dgvWaitings
            // 
            this.dgvWaitings.AllowUserToAddRows = false;
            this.dgvWaitings.AllowUserToDeleteRows = false;
            this.dgvWaitings.AllowUserToOrderColumns = true;
            this.dgvWaitings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWaitings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWaitings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWaitings.ColumnHeadersHeight = 30;
            this.dgvWaitings.ContextMenuStrip = this.cmsWaitings;
            this.dgvWaitings.Location = new System.Drawing.Point(12, 273);
            this.dgvWaitings.MultiSelect = false;
            this.dgvWaitings.Name = "dgvWaitings";
            this.dgvWaitings.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvWaitings.ReadOnly = true;
            this.dgvWaitings.RowHeadersVisible = false;
            this.dgvWaitings.RowHeadersWidth = 40;
            this.dgvWaitings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWaitings.Size = new System.Drawing.Size(760, 300);
            this.dgvWaitings.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvWaitings.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvWaitings.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWaitings.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dgvWaitings.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWaitings.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvWaitings.TabIndex = 19;
            this.dgvWaitings.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvWaitings_CellFormatting);
            // 
            // cmsWaitings
            // 
            this.cmsWaitings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsWaitings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startvisittoolStripMenuItem});
            this.cmsWaitings.Name = "cmsPeople";
            this.cmsWaitings.Size = new System.Drawing.Size(160, 42);
            // 
            // startvisittoolStripMenuItem
            // 
            this.startvisittoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startvisittoolStripMenuItem.Image = global::HMS.Properties.Resources.Start_Visit_32;
            this.startvisittoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.startvisittoolStripMenuItem.Name = "startvisittoolStripMenuItem";
            this.startvisittoolStripMenuItem.Size = new System.Drawing.Size(159, 38);
            this.startvisittoolStripMenuItem.Text = "Start Visit";
            this.startvisittoolStripMenuItem.Click += new System.EventHandler(this.startvisittoolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.Patient_Queue_512;
            this.pictureBox1.Location = new System.Drawing.Point(308, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
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
            this.tbFilter.TabIndex = 51;
            this.tbFilter.Visible = false;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.DropDownWidth = 143;
            this.cbFilter.IntegralHeight = false;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "ID",
            "Medical Record No"});
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
            this.cbFilter.TabIndex = 52;
            this.cbFilter.Text = "None";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // frmManageWaitings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.dgvWaitings);
            this.Name = "frmManageWaitings";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "frmManageWaitings";
            this.Load += new System.EventHandler(this.frmManageWaitings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitings)).EndInit();
            this.cmsWaitings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnReload;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel lblRowCount;
        private Youssef.WinForms.Controls.JODataGridView dgvWaitings;
        private System.Windows.Forms.ContextMenuStrip cmsWaitings;
        private System.Windows.Forms.ToolStripMenuItem startvisittoolStripMenuItem;
        private Youssef.WinForms.Controls.JOTextBox tbFilter;
        private Krypton.Toolkit.KryptonComboBox cbFilter;
    }
}
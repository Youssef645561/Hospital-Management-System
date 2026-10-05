namespace HMS.Payment.Control
{
    partial class ctrlPaymentsHistory
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
            this.gbPayments = new Krypton.Toolkit.KryptonGroupBox();
            this.dgvPayments = new Youssef.WinForms.Controls.JODataGridView();
            this.lblRowCount = new Krypton.Toolkit.KryptonLabel();
            this.cmsPayments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showDetailstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PerformPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RefundtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gbPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPayments.Panel)).BeginInit();
            this.gbPayments.Panel.SuspendLayout();
            this.gbPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.cmsPayments.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPayments
            // 
            this.gbPayments.CaptionOverlap = 1D;
            this.gbPayments.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbPayments.Location = new System.Drawing.Point(4, 3);
            this.gbPayments.Name = "gbPayments";
            this.gbPayments.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbPayments.Panel
            // 
            this.gbPayments.Panel.Controls.Add(this.dgvPayments);
            this.gbPayments.Size = new System.Drawing.Size(744, 318);
            this.gbPayments.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbPayments.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbPayments.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.gbPayments.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPayments.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPayments.TabIndex = 36;
            this.gbPayments.Values.Description = "Patient Charge ID = ???";
            this.gbPayments.Values.Heading = "Payments";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToOrderColumns = true;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.ColumnHeadersHeight = 30;
            this.dgvPayments.ContextMenuStrip = this.cmsPayments;
            this.dgvPayments.Location = new System.Drawing.Point(3, 3);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.RowHeadersWidth = 40;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(734, 287);
            this.dgvPayments.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvPayments.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvPayments.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayments.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dgvPayments.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayments.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvPayments.TabIndex = 0;
            this.dgvPayments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPayments_CellFormatting);
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowCount.Location = new System.Drawing.Point(4, 327);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(24, 20);
            this.lblRowCount.TabIndex = 35;
            this.lblRowCount.Values.Text = "#0";
            // 
            // cmsPayments
            // 
            this.cmsPayments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsPayments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadtoolStripMenuItem,
            this.toolStripSeparator3,
            this.showDetailstoolStripMenuItem,
            this.toolStripSeparator1,
            this.PerformPaymentToolStripMenuItem,
            this.toolStripSeparator2,
            this.RefundtoolStripMenuItem});
            this.cmsPayments.Name = "cmsPeople";
            this.cmsPayments.Size = new System.Drawing.Size(214, 174);
            // 
            // reloadtoolStripMenuItem
            // 
            this.reloadtoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadtoolStripMenuItem.Image = global::HMS.Properties.Resources.Reload_32;
            this.reloadtoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reloadtoolStripMenuItem.Name = "reloadtoolStripMenuItem";
            this.reloadtoolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.reloadtoolStripMenuItem.Text = "Reload";
            this.reloadtoolStripMenuItem.Click += new System.EventHandler(this.reloadtoolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
            // 
            // showDetailstoolStripMenuItem
            // 
            this.showDetailstoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailstoolStripMenuItem.Image = global::HMS.Properties.Resources.Payment_Details_32;
            this.showDetailstoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailstoolStripMenuItem.Name = "showDetailstoolStripMenuItem";
            this.showDetailstoolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.showDetailstoolStripMenuItem.Text = "Show Details";
            this.showDetailstoolStripMenuItem.Click += new System.EventHandler(this.showDetailstoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // PerformPaymentToolStripMenuItem
            // 
            this.PerformPaymentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerformPaymentToolStripMenuItem.Image = global::HMS.Properties.Resources.Add_Payment_32;
            this.PerformPaymentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PerformPaymentToolStripMenuItem.Name = "PerformPaymentToolStripMenuItem";
            this.PerformPaymentToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.PerformPaymentToolStripMenuItem.Text = "Perform Payment";
            this.PerformPaymentToolStripMenuItem.Click += new System.EventHandler(this.PerformPaymentToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // RefundtoolStripMenuItem
            // 
            this.RefundtoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundtoolStripMenuItem.Image = global::HMS.Properties.Resources.Refund_32;
            this.RefundtoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefundtoolStripMenuItem.Name = "RefundtoolStripMenuItem";
            this.RefundtoolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.RefundtoolStripMenuItem.Text = "Refund";
            this.RefundtoolStripMenuItem.Click += new System.EventHandler(this.RefundtoolStripMenuItem_Click);
            // 
            // ctrlPaymentsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPayments);
            this.Controls.Add(this.lblRowCount);
            this.Name = "ctrlPaymentsHistory";
            this.Size = new System.Drawing.Size(752, 351);
            ((System.ComponentModel.ISupportInitialize)(this.gbPayments.Panel)).EndInit();
            this.gbPayments.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbPayments)).EndInit();
            this.gbPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.cmsPayments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbPayments;
        private Youssef.WinForms.Controls.JODataGridView dgvPayments;
        private Krypton.Toolkit.KryptonLabel lblRowCount;
        private System.Windows.Forms.ContextMenuStrip cmsPayments;
        private System.Windows.Forms.ToolStripMenuItem showDetailstoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PerformPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem RefundtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadtoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

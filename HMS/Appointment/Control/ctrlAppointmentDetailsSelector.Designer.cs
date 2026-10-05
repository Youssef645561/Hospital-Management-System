namespace HMS.Appointment.Control
{
    partial class ctrlAppointmentDetailsSelector
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
            this.ctrlAppointmentDetails1 = new HMS.Appointment.ctrlAppointmentDetails();
            this.gbFilter = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.btnAddNew = new Krypton.Toolkit.KryptonButton();
            this.tbFilter = new Youssef.WinForms.Controls.JOTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbFilter.Panel)).BeginInit();
            this.gbFilter.Panel.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlAppointmentDetails1
            // 
            this.ctrlAppointmentDetails1.Location = new System.Drawing.Point(4, 91);
            this.ctrlAppointmentDetails1.Name = "ctrlAppointmentDetails1";
            this.ctrlAppointmentDetails1.Size = new System.Drawing.Size(908, 549);
            this.ctrlAppointmentDetails1.TabIndex = 0;
            // 
            // gbFilter
            // 
            this.gbFilter.CaptionOverlap = 1D;
            this.gbFilter.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbFilter.Location = new System.Drawing.Point(318, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbFilter.Panel
            // 
            this.gbFilter.Panel.Controls.Add(this.kryptonLabel1);
            this.gbFilter.Panel.Controls.Add(this.btnSearch);
            this.gbFilter.Panel.Controls.Add(this.btnAddNew);
            this.gbFilter.Panel.Controls.Add(this.tbFilter);
            this.gbFilter.Size = new System.Drawing.Size(280, 82);
            this.gbFilter.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbFilter.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbFilter.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.TabIndex = 35;
            this.gbFilter.Values.Heading = "Filter";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 17);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(38, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 40;
            this.kryptonLabel1.Values.Text = "ID :";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.CornerRoundingRadius = 20F;
            this.btnSearch.Location = new System.Drawing.Point(181, 5);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.CornerRoundingRadius = 20F;
            this.btnAddNew.Location = new System.Drawing.Point(230, 5);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAddNew.Size = new System.Drawing.Size(43, 46);
            this.btnAddNew.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddNew.StateCommon.Border.Rounding = 20F;
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Values.Image = global::HMS.Properties.Resources.Add_32;
            this.btnAddNew.Values.Text = "";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.AllowLetters = false;
            this.tbFilter.AllowSpecialCharacters = false;
            this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilter.CornerRoundingRadius = 20F;
            this.tbFilter.Location = new System.Drawing.Point(47, 11);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbFilter.Size = new System.Drawing.Size(128, 35);
            this.tbFilter.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbFilter.StateCommon.Border.Rounding = 20F;
            this.tbFilter.TabIndex = 0;
            // 
            // ctrlAppointmentDetailsSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlAppointmentDetails1);
            this.Name = "ctrlAppointmentDetailsSelector";
            this.Size = new System.Drawing.Size(917, 643);
            ((System.ComponentModel.ISupportInitialize)(this.gbFilter.Panel)).EndInit();
            this.gbFilter.Panel.ResumeLayout(false);
            this.gbFilter.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbFilter)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlAppointmentDetails ctrlAppointmentDetails1;
        private Krypton.Toolkit.KryptonGroupBox gbFilter;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonButton btnAddNew;
        private Youssef.WinForms.Controls.JOTextBox tbFilter;
    }
}

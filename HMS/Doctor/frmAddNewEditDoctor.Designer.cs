namespace HMS.Doctors
{
    partial class frmAddNewEditDoctor
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
            this.gbDoctorData = new Krypton.Toolkit.KryptonGroupBox();
            this.ckActive = new Krypton.Toolkit.KryptonCheckBox();
            this.cbDepartments = new Krypton.Toolkit.KryptonComboBox();
            this.cbSpecializations = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.ctrlPersonDetailsSelector1 = new HMS.People.Control.ctrlPersonDetailsSelector();
            ((System.ComponentModel.ISupportInitialize)(this.gbDoctorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDoctorData.Panel)).BeginInit();
            this.gbDoctorData.Panel.SuspendLayout();
            this.gbDoctorData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSpecializations)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDoctorData
            // 
            this.gbDoctorData.CaptionOverlap = 1D;
            this.gbDoctorData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbDoctorData.Location = new System.Drawing.Point(12, 394);
            this.gbDoctorData.Name = "gbDoctorData";
            this.gbDoctorData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbDoctorData.Panel
            // 
            this.gbDoctorData.Panel.Controls.Add(this.ckActive);
            this.gbDoctorData.Panel.Controls.Add(this.cbDepartments);
            this.gbDoctorData.Panel.Controls.Add(this.cbSpecializations);
            this.gbDoctorData.Panel.Controls.Add(this.kryptonLabel1);
            this.gbDoctorData.Panel.Controls.Add(this.kryptonLabel2);
            this.gbDoctorData.Size = new System.Drawing.Size(652, 94);
            this.gbDoctorData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbDoctorData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbDoctorData.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.gbDoctorData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDoctorData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDoctorData.TabIndex = 2;
            this.gbDoctorData.Values.Description = "ID = ???";
            this.gbDoctorData.Values.Heading = "Doctor Data";
            // 
            // ckActive
            // 
            this.ckActive.Checked = true;
            this.ckActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckActive.Location = new System.Drawing.Point(583, 25);
            this.ckActive.Name = "ckActive";
            this.ckActive.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.ckActive.Size = new System.Drawing.Size(62, 19);
            this.ckActive.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckActive.TabIndex = 5;
            this.ckActive.Values.Text = "Active";
            // 
            // cbDepartments
            // 
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.DropDownWidth = 143;
            this.cbDepartments.IntegralHeight = false;
            this.cbDepartments.Location = new System.Drawing.Point(127, 17);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbDepartments.Size = new System.Drawing.Size(155, 35);
            this.cbDepartments.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbDepartments.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbDepartments.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartments.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbDepartments.TabIndex = 3;
            // 
            // cbSpecializations
            // 
            this.cbSpecializations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecializations.DropDownWidth = 143;
            this.cbSpecializations.IntegralHeight = false;
            this.cbSpecializations.Location = new System.Drawing.Point(422, 17);
            this.cbSpecializations.Name = "cbSpecializations";
            this.cbSpecializations.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbSpecializations.Size = new System.Drawing.Size(155, 35);
            this.cbSpecializations.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbSpecializations.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbSpecializations.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpecializations.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbSpecializations.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 23);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(110, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Text = "Department :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(288, 23);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(128, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Specialization :";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(333, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTitle.Size = new System.Drawing.Size(264, 43);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Values.Text = "Add New Doctor";
            this.lblTitle.SizeChanged += new System.EventHandler(this.lblTitle_SizeChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CornerRoundingRadius = 20F;
            this.btnClose.Location = new System.Drawing.Point(670, 453);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClose.Size = new System.Drawing.Size(248, 35);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 20F;
            this.btnClose.TabIndex = 7;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CornerRoundingRadius = 20F;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(670, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(248, 35);
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 20F;
            this.btnSave.TabIndex = 6;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlPersonDetailsSelector1
            // 
            this.ctrlPersonDetailsSelector1.Location = new System.Drawing.Point(12, 61);
            this.ctrlPersonDetailsSelector1.Name = "ctrlPersonDetailsSelector1";
            this.ctrlPersonDetailsSelector1.Size = new System.Drawing.Size(906, 332);
            this.ctrlPersonDetailsSelector1.TabIndex = 0;
            // 
            // frmAddNewEditDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 498);
            this.Controls.Add(this.gbDoctorData);
            this.Controls.Add(this.ctrlPersonDetailsSelector1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddNewEditDoctor";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "frmAddNewEditDoctor";
            this.Load += new System.EventHandler(this.frmAddNewEditDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbDoctorData.Panel)).EndInit();
            this.gbDoctorData.Panel.ResumeLayout(false);
            this.gbDoctorData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbDoctorData)).EndInit();
            this.gbDoctorData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSpecializations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbDoctorData;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private People.Control.ctrlPersonDetailsSelector ctrlPersonDetailsSelector1;
        private Krypton.Toolkit.KryptonComboBox cbSpecializations;
        private Krypton.Toolkit.KryptonComboBox cbDepartments;
        private Krypton.Toolkit.KryptonCheckBox ckActive;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnSave;
    }
}
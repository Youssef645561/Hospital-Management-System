namespace HMS.Patients
{
    partial class frmAddNewEditPatient
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
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.gbPatientData = new Krypton.Toolkit.KryptonGroupBox();
            this.lblMedicalRecordNo = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.cbBloodType = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.ctrlPersonDetailsSelector1 = new HMS.People.Control.ctrlPersonDetailsSelector();
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientData.Panel)).BeginInit();
            this.gbPatientData.Panel.SuspendLayout();
            this.gbPatientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbBloodType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(331, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTitle.Size = new System.Drawing.Size(271, 43);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Values.Text = "Add New Patient";
            this.lblTitle.SizeChanged += new System.EventHandler(this.lblTitle_SizeChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CornerRoundingRadius = 20F;
            this.btnClose.Location = new System.Drawing.Point(652, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClose.Size = new System.Drawing.Size(268, 35);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 20F;
            this.btnClose.TabIndex = 40;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbPatientData
            // 
            this.gbPatientData.CaptionOverlap = 1D;
            this.gbPatientData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbPatientData.Location = new System.Drawing.Point(13, 390);
            this.gbPatientData.Name = "gbPatientData";
            this.gbPatientData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbPatientData.Panel
            // 
            this.gbPatientData.Panel.Controls.Add(this.lblMedicalRecordNo);
            this.gbPatientData.Panel.Controls.Add(this.kryptonButton1);
            this.gbPatientData.Panel.Controls.Add(this.cbBloodType);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel4);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel2);
            this.gbPatientData.Size = new System.Drawing.Size(633, 80);
            this.gbPatientData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbPatientData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbPatientData.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.gbPatientData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientData.TabIndex = 42;
            this.gbPatientData.Values.Description = "ID : ???";
            this.gbPatientData.Values.Heading = "Patient Data";
            // 
            // lblMedicalRecordNo
            // 
            this.lblMedicalRecordNo.Location = new System.Drawing.Point(185, 16);
            this.lblMedicalRecordNo.Name = "lblMedicalRecordNo";
            this.lblMedicalRecordNo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblMedicalRecordNo.Size = new System.Drawing.Size(40, 23);
            this.lblMedicalRecordNo.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblMedicalRecordNo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalRecordNo.TabIndex = 40;
            this.lblMedicalRecordNo.Values.Text = "???";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.CornerRoundingRadius = 20F;
            this.kryptonButton1.Location = new System.Drawing.Point(1235, 10);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonButton1.Size = new System.Drawing.Size(98, 35);
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20F;
            this.kryptonButton1.TabIndex = 37;
            this.kryptonButton1.Values.Text = "Close";
            // 
            // cbBloodType
            // 
            this.cbBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBloodType.DropDownWidth = 143;
            this.cbBloodType.IntegralHeight = false;
            this.cbBloodType.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbBloodType.Location = new System.Drawing.Point(488, 10);
            this.cbBloodType.Name = "cbBloodType";
            this.cbBloodType.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbBloodType.Size = new System.Drawing.Size(128, 35);
            this.cbBloodType.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbBloodType.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbBloodType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBloodType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbBloodType.TabIndex = 2;
            this.cbBloodType.Text = "A+";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(375, 16);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(107, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Blood Type :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(13, 16);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(166, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Medical Record No :";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CornerRoundingRadius = 20F;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(652, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(268, 35);
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 20F;
            this.btnSave.TabIndex = 43;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlPersonDetailsSelector1
            // 
            this.ctrlPersonDetailsSelector1.Location = new System.Drawing.Point(13, 61);
            this.ctrlPersonDetailsSelector1.Name = "ctrlPersonDetailsSelector1";
            this.ctrlPersonDetailsSelector1.Size = new System.Drawing.Size(907, 323);
            this.ctrlPersonDetailsSelector1.TabIndex = 41;
            // 
            // frmAddNewEditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 482);
            this.Controls.Add(this.gbPatientData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlPersonDetailsSelector1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddNewEditPatient";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "frmAddNewEditPatient";
            this.Load += new System.EventHandler(this.frmAddNewEditPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientData.Panel)).EndInit();
            this.gbPatientData.Panel.ResumeLayout(false);
            this.gbPatientData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientData)).EndInit();
            this.gbPatientData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbBloodType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonGroupBox gbPatientData;
        private Krypton.Toolkit.KryptonLabel lblMedicalRecordNo;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonComboBox cbBloodType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnSave;
        private People.Control.ctrlPersonDetailsSelector ctrlPersonDetailsSelector1;
    }
}
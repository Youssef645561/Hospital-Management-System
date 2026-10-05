namespace HMS.Patients.Controls
{
    partial class ctrlPatientDetails
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
            this.gbPatientData = new Krypton.Toolkit.KryptonGroupBox();
            this.lblEdit = new Krypton.Toolkit.KryptonLinkLabel();
            this.lblCreatedBy = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.lblCreatedDate = new Krypton.Toolkit.KryptonLabel();
            this.lblBloodType = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.lblMedicalRecordNo = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.lblPatientAppointmentsHistory = new Krypton.Toolkit.KryptonLinkLabel();
            this.ctrlPersonDetails1 = new HMS.People.Control.ctrlPersonDetails();
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientData.Panel)).BeginInit();
            this.gbPatientData.Panel.SuspendLayout();
            this.gbPatientData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPatientData
            // 
            this.gbPatientData.CaptionOverlap = 1D;
            this.gbPatientData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbPatientData.Location = new System.Drawing.Point(4, 4);
            this.gbPatientData.Name = "gbPatientData";
            this.gbPatientData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbPatientData.Panel
            // 
            this.gbPatientData.Panel.Controls.Add(this.lblPatientAppointmentsHistory);
            this.gbPatientData.Panel.Controls.Add(this.lblEdit);
            this.gbPatientData.Panel.Controls.Add(this.lblCreatedBy);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel4);
            this.gbPatientData.Panel.Controls.Add(this.lblCreatedDate);
            this.gbPatientData.Panel.Controls.Add(this.lblBloodType);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel2);
            this.gbPatientData.Panel.Controls.Add(this.lblMedicalRecordNo);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel1);
            this.gbPatientData.Panel.Controls.Add(this.lblID);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel9);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel10);
            this.gbPatientData.Size = new System.Drawing.Size(900, 147);
            this.gbPatientData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbPatientData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbPatientData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientData.TabIndex = 32;
            this.gbPatientData.Values.Heading = "Patient Data";
            // 
            // lblEdit
            // 
            this.lblEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdit.Enabled = false;
            this.lblEdit.Location = new System.Drawing.Point(854, 3);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblEdit.Size = new System.Drawing.Size(39, 21);
            this.lblEdit.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.TabIndex = 34;
            this.lblEdit.Values.Text = "Edit";
            this.lblEdit.LinkClicked += new System.EventHandler(this.lblEdit_LinkClicked);
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.Location = new System.Drawing.Point(490, 50);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblCreatedBy.Size = new System.Drawing.Size(40, 23);
            this.lblCreatedBy.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblCreatedBy.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.TabIndex = 33;
            this.lblCreatedBy.Values.Text = "???";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(11, 87);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(107, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Blood Type :";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.Location = new System.Drawing.Point(490, 13);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblCreatedDate.Size = new System.Drawing.Size(40, 23);
            this.lblCreatedDate.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblCreatedDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.TabIndex = 30;
            this.lblCreatedDate.Values.Text = "???";
            // 
            // lblBloodType
            // 
            this.lblBloodType.Location = new System.Drawing.Point(183, 87);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblBloodType.Size = new System.Drawing.Size(40, 23);
            this.lblBloodType.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblBloodType.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodType.TabIndex = 29;
            this.lblBloodType.Values.Text = "???";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(11, 50);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(166, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Medical Record No :";
            // 
            // lblMedicalRecordNo
            // 
            this.lblMedicalRecordNo.Location = new System.Drawing.Point(183, 50);
            this.lblMedicalRecordNo.Name = "lblMedicalRecordNo";
            this.lblMedicalRecordNo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblMedicalRecordNo.Size = new System.Drawing.Size(40, 23);
            this.lblMedicalRecordNo.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblMedicalRecordNo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalRecordNo.TabIndex = 27;
            this.lblMedicalRecordNo.Values.Text = "???";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(38, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "ID :";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(183, 13);
            this.lblID.Name = "lblID";
            this.lblID.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblID.Size = new System.Drawing.Size(40, 23);
            this.lblID.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblID.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.TabIndex = 26;
            this.lblID.Values.Text = "???";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(375, 13);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel9.Size = new System.Drawing.Size(109, 23);
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 19;
            this.kryptonLabel9.Values.Text = "Date added :";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(375, 50);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel10.Size = new System.Drawing.Size(93, 23);
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 20;
            this.kryptonLabel10.Values.Text = "Added by :";
            // 
            // lblPatientAppointmentsHistory
            // 
            this.lblPatientAppointmentsHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatientAppointmentsHistory.Enabled = false;
            this.lblPatientAppointmentsHistory.Location = new System.Drawing.Point(674, 98);
            this.lblPatientAppointmentsHistory.Name = "lblPatientAppointmentsHistory";
            this.lblPatientAppointmentsHistory.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblPatientAppointmentsHistory.Size = new System.Drawing.Size(219, 21);
            this.lblPatientAppointmentsHistory.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientAppointmentsHistory.TabIndex = 41;
            this.lblPatientAppointmentsHistory.Values.Text = "Patient Appointments History";
            this.lblPatientAppointmentsHistory.LinkClicked += new System.EventHandler(this.lblPatientAppointmentsHistory_LinkClicked);
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(4, 157);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(900, 228);
            this.ctrlPersonDetails1.TabIndex = 33;
            // 
            // ctrlPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Controls.Add(this.gbPatientData);
            this.Name = "ctrlPatientDetails";
            this.Size = new System.Drawing.Size(908, 389);
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientData.Panel)).EndInit();
            this.gbPatientData.Panel.ResumeLayout(false);
            this.gbPatientData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientData)).EndInit();
            this.gbPatientData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbPatientData;
        private Krypton.Toolkit.KryptonLabel lblCreatedBy;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel lblCreatedDate;
        private Krypton.Toolkit.KryptonLabel lblBloodType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel lblMedicalRecordNo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLinkLabel lblEdit;
        private People.Control.ctrlPersonDetails ctrlPersonDetails1;
        private Krypton.Toolkit.KryptonLinkLabel lblPatientAppointmentsHistory;
    }
}

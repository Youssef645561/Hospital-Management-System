namespace HMS.Medical_Visit.Control
{
    partial class ctrlMedicalVisitDetails
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
            this.lblAppointmentDetails = new Krypton.Toolkit.KryptonLinkLabel();
            this.tbNotes = new Youssef.WinForms.Controls.JOTextBox();
            this.tbDiagnosis = new Youssef.WinForms.Controls.JOTextBox();
            this.tbSymptoms = new Youssef.WinForms.Controls.JOTextBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.lblAppointmentID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.lblEdit = new Krypton.Toolkit.KryptonLinkLabel();
            this.lblCreatedBy = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.lblCreatedDate = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
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
            this.gbPatientData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPatientData.Location = new System.Drawing.Point(0, 0);
            this.gbPatientData.Name = "gbPatientData";
            this.gbPatientData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbPatientData.Panel
            // 
            this.gbPatientData.Panel.Controls.Add(this.lblAppointmentDetails);
            this.gbPatientData.Panel.Controls.Add(this.tbNotes);
            this.gbPatientData.Panel.Controls.Add(this.tbDiagnosis);
            this.gbPatientData.Panel.Controls.Add(this.tbSymptoms);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel7);
            this.gbPatientData.Panel.Controls.Add(this.lblAppointmentID);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel5);
            this.gbPatientData.Panel.Controls.Add(this.lblEdit);
            this.gbPatientData.Panel.Controls.Add(this.lblCreatedBy);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel4);
            this.gbPatientData.Panel.Controls.Add(this.lblCreatedDate);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel2);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel1);
            this.gbPatientData.Panel.Controls.Add(this.lblID);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel9);
            this.gbPatientData.Panel.Controls.Add(this.kryptonLabel10);
            this.gbPatientData.Size = new System.Drawing.Size(918, 387);
            this.gbPatientData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbPatientData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbPatientData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientData.TabIndex = 33;
            this.gbPatientData.Values.Heading = "Medical Visit Data";
            // 
            // lblAppointmentDetails
            // 
            this.lblAppointmentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppointmentDetails.Enabled = false;
            this.lblAppointmentDetails.Location = new System.Drawing.Point(756, 3);
            this.lblAppointmentDetails.Name = "lblAppointmentDetails";
            this.lblAppointmentDetails.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblAppointmentDetails.Size = new System.Drawing.Size(155, 21);
            this.lblAppointmentDetails.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDetails.TabIndex = 46;
            this.lblAppointmentDetails.Values.Text = "Appointment Details";
            this.lblAppointmentDetails.LinkClicked += new System.EventHandler(this.lblAppointmentDetails_LinkClicked);
            // 
            // tbNotes
            // 
            this.tbNotes.CornerRoundingRadius = 20F;
            this.tbNotes.Location = new System.Drawing.Point(123, 265);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbNotes.Size = new System.Drawing.Size(380, 75);
            this.tbNotes.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbNotes.StateCommon.Border.Rounding = 20F;
            this.tbNotes.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNotes.TabIndex = 45;
            this.tbNotes.Text = "???";
            // 
            // tbDiagnosis
            // 
            this.tbDiagnosis.CornerRoundingRadius = 20F;
            this.tbDiagnosis.Location = new System.Drawing.Point(123, 184);
            this.tbDiagnosis.Multiline = true;
            this.tbDiagnosis.Name = "tbDiagnosis";
            this.tbDiagnosis.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbDiagnosis.Size = new System.Drawing.Size(380, 75);
            this.tbDiagnosis.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbDiagnosis.StateCommon.Border.Rounding = 20F;
            this.tbDiagnosis.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiagnosis.TabIndex = 44;
            this.tbDiagnosis.Text = "???";
            // 
            // tbSymptoms
            // 
            this.tbSymptoms.CornerRoundingRadius = 20F;
            this.tbSymptoms.Location = new System.Drawing.Point(123, 103);
            this.tbSymptoms.Multiline = true;
            this.tbSymptoms.Name = "tbSymptoms";
            this.tbSymptoms.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbSymptoms.Size = new System.Drawing.Size(380, 75);
            this.tbSymptoms.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSymptoms.StateCommon.Border.Rounding = 20F;
            this.tbSymptoms.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSymptoms.TabIndex = 43;
            this.tbSymptoms.Text = "???";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(509, 22);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel7.Size = new System.Drawing.Size(139, 23);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 38;
            this.kryptonLabel7.Values.Text = "Appointment ID :";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.Location = new System.Drawing.Point(654, 22);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblAppointmentID.Size = new System.Drawing.Size(40, 23);
            this.lblAppointmentID.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblAppointmentID.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.TabIndex = 39;
            this.lblAppointmentID.Values.Text = "???";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(15, 265);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel5.Size = new System.Drawing.Size(66, 23);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 36;
            this.kryptonLabel5.Values.Text = "Notes :";
            // 
            // lblEdit
            // 
            this.lblEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdit.Enabled = false;
            this.lblEdit.Location = new System.Drawing.Point(872, 338);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblEdit.Size = new System.Drawing.Size(39, 21);
            this.lblEdit.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.TabIndex = 34;
            this.lblEdit.Values.Text = "Edit";
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_LinkClicked);
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.Location = new System.Drawing.Point(654, 184);
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
            this.kryptonLabel4.Location = new System.Drawing.Point(15, 184);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(97, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Diagnosis :";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.Location = new System.Drawing.Point(654, 103);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblCreatedDate.Size = new System.Drawing.Size(40, 23);
            this.lblCreatedDate.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblCreatedDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.TabIndex = 30;
            this.lblCreatedDate.Values.Text = "???";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(15, 103);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(102, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Symptoms :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 22);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(38, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "ID :";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(123, 22);
            this.lblID.Name = "lblID";
            this.lblID.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblID.Size = new System.Drawing.Size(40, 23);
            this.lblID.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblID.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblID.TabIndex = 26;
            this.lblID.Values.Text = "???";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(509, 103);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel9.Size = new System.Drawing.Size(109, 23);
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 19;
            this.kryptonLabel9.Values.Text = "Date added :";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(509, 184);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel10.Size = new System.Drawing.Size(93, 23);
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 20;
            this.kryptonLabel10.Values.Text = "Added by :";
            // 
            // ctrlMedicalVisitDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPatientData);
            this.Name = "ctrlMedicalVisitDetails";
            this.Size = new System.Drawing.Size(918, 387);
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientData.Panel)).EndInit();
            this.gbPatientData.Panel.ResumeLayout(false);
            this.gbPatientData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientData)).EndInit();
            this.gbPatientData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbPatientData;
        private Krypton.Toolkit.KryptonLinkLabel lblEdit;
        private Krypton.Toolkit.KryptonLabel lblCreatedBy;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel lblCreatedDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel lblAppointmentID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Youssef.WinForms.Controls.JOTextBox tbSymptoms;
        private Youssef.WinForms.Controls.JOTextBox tbNotes;
        private Youssef.WinForms.Controls.JOTextBox tbDiagnosis;
        private Krypton.Toolkit.KryptonLinkLabel lblAppointmentDetails;
    }
}

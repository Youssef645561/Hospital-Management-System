namespace HMS.Appointment
{
    partial class ctrlAppointmentDetails
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
            this.gbAppointmentData = new Krypton.Toolkit.KryptonGroupBox();
            this.lblReschedule = new Krypton.Toolkit.KryptonLinkLabel();
            this.lblDay = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.lblTime = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.lblCreatedDate = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.lblCreatedBy = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.lblDate = new Krypton.Toolkit.KryptonLabel();
            this.lblType = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.lblStatus = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.lblDoctorName = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.ctrlPatientDetails1 = new HMS.Patients.Controls.ctrlPatientDetails();
            ((System.ComponentModel.ISupportInitialize)(this.gbAppointmentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbAppointmentData.Panel)).BeginInit();
            this.gbAppointmentData.Panel.SuspendLayout();
            this.gbAppointmentData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAppointmentData
            // 
            this.gbAppointmentData.CaptionOverlap = 1D;
            this.gbAppointmentData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbAppointmentData.Location = new System.Drawing.Point(4, 1);
            this.gbAppointmentData.Name = "gbAppointmentData";
            this.gbAppointmentData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbAppointmentData.Panel
            // 
            this.gbAppointmentData.Panel.Controls.Add(this.lblDoctorName);
            this.gbAppointmentData.Panel.Controls.Add(this.kryptonLabel6);
            this.gbAppointmentData.Panel.Controls.Add(this.lblReschedule);
            this.gbAppointmentData.Panel.Controls.Add(this.lblDay);
            this.gbAppointmentData.Panel.Controls.Add(this.kryptonLabel11);
            this.gbAppointmentData.Panel.Controls.Add(this.lblTime);
            this.gbAppointmentData.Panel.Controls.Add(this.kryptonLabel7);
            this.gbAppointmentData.Panel.Controls.Add(this.lblCreatedDate);
            this.gbAppointmentData.Panel.Controls.Add(this.kryptonLabel5);
            this.gbAppointmentData.Panel.Controls.Add(this.lblCreatedBy);
            this.gbAppointmentData.Panel.Controls.Add(this.kryptonLabel4);
            this.gbAppointmentData.Panel.Controls.Add(this.lblDate);
            this.gbAppointmentData.Panel.Controls.Add(this.lblType);
            this.gbAppointmentData.Panel.Controls.Add(this.kryptonLabel2);
            this.gbAppointmentData.Panel.Controls.Add(this.lblStatus);
            this.gbAppointmentData.Panel.Controls.Add(this.kryptonLabel1);
            this.gbAppointmentData.Panel.Controls.Add(this.lblID);
            this.gbAppointmentData.Panel.Controls.Add(this.kryptonLabel9);
            this.gbAppointmentData.Panel.Controls.Add(this.kryptonLabel10);
            this.gbAppointmentData.Size = new System.Drawing.Size(900, 151);
            this.gbAppointmentData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbAppointmentData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbAppointmentData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAppointmentData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAppointmentData.TabIndex = 33;
            this.gbAppointmentData.Values.Heading = "Appointment Data";
            // 
            // lblReschedule
            // 
            this.lblReschedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReschedule.Enabled = false;
            this.lblReschedule.Location = new System.Drawing.Point(797, 102);
            this.lblReschedule.Name = "lblReschedule";
            this.lblReschedule.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblReschedule.Size = new System.Drawing.Size(96, 21);
            this.lblReschedule.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReschedule.TabIndex = 40;
            this.lblReschedule.Values.Text = "Reschedule";
            this.lblReschedule.LinkClicked += new System.EventHandler(this.lblReschedule_LinkClicked);
            // 
            // lblDay
            // 
            this.lblDay.Location = new System.Drawing.Point(334, 16);
            this.lblDay.Name = "lblDay";
            this.lblDay.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblDay.Size = new System.Drawing.Size(40, 23);
            this.lblDay.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblDay.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.TabIndex = 39;
            this.lblDay.Values.Text = "???";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(269, 16);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel11.Size = new System.Drawing.Size(51, 23);
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel11.TabIndex = 38;
            this.kryptonLabel11.Values.Text = "Day :";
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(334, 88);
            this.lblTime.Name = "lblTime";
            this.lblTime.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTime.Size = new System.Drawing.Size(40, 23);
            this.lblTime.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblTime.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.TabIndex = 37;
            this.lblTime.Values.Text = "???";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(269, 88);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel7.Size = new System.Drawing.Size(59, 23);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 36;
            this.kryptonLabel7.Values.Text = "Time :";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.Location = new System.Drawing.Point(655, 52);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblCreatedDate.Size = new System.Drawing.Size(40, 23);
            this.lblCreatedDate.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblCreatedDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.TabIndex = 35;
            this.lblCreatedDate.Values.Text = "???";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(528, 52);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel5.Size = new System.Drawing.Size(109, 23);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 34;
            this.kryptonLabel5.Values.Text = "Date added :";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.Location = new System.Drawing.Point(655, 88);
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
            this.kryptonLabel4.Location = new System.Drawing.Point(11, 88);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(59, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Type :";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(334, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblDate.Size = new System.Drawing.Size(40, 23);
            this.lblDate.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.TabIndex = 30;
            this.lblDate.Values.Text = "???";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(87, 88);
            this.lblType.Name = "lblType";
            this.lblType.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblType.Size = new System.Drawing.Size(40, 23);
            this.lblType.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblType.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.TabIndex = 29;
            this.lblType.Values.Text = "???";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(11, 52);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(70, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Status :";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(87, 52);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblStatus.Size = new System.Drawing.Size(40, 23);
            this.lblStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Values.Text = "???";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 16);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(38, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "ID :";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(87, 16);
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
            this.kryptonLabel9.Location = new System.Drawing.Point(269, 52);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel9.Size = new System.Drawing.Size(57, 23);
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 19;
            this.kryptonLabel9.Values.Text = "Date :";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(527, 88);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel10.Size = new System.Drawing.Size(93, 23);
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 20;
            this.kryptonLabel10.Values.Text = "Added by :";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.Location = new System.Drawing.Point(655, 16);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblDoctorName.Size = new System.Drawing.Size(40, 23);
            this.lblDoctorName.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblDoctorName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.TabIndex = 42;
            this.lblDoctorName.Values.Text = "???";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(527, 16);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel6.Size = new System.Drawing.Size(121, 23);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 41;
            this.kryptonLabel6.Values.Text = "Doctor Name :";
            // 
            // ctrlPatientDetails1
            // 
            this.ctrlPatientDetails1.Location = new System.Drawing.Point(0, 158);
            this.ctrlPatientDetails1.Name = "ctrlPatientDetails1";
            this.ctrlPatientDetails1.Size = new System.Drawing.Size(908, 388);
            this.ctrlPatientDetails1.TabIndex = 34;
            // 
            // ctrlAppointmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPatientDetails1);
            this.Controls.Add(this.gbAppointmentData);
            this.Name = "ctrlAppointmentDetails";
            this.Size = new System.Drawing.Size(908, 549);
            ((System.ComponentModel.ISupportInitialize)(this.gbAppointmentData.Panel)).EndInit();
            this.gbAppointmentData.Panel.ResumeLayout(false);
            this.gbAppointmentData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbAppointmentData)).EndInit();
            this.gbAppointmentData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbAppointmentData;
        private Krypton.Toolkit.KryptonLabel lblCreatedBy;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel lblDate;
        private Krypton.Toolkit.KryptonLabel lblType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel lblStatus;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Patients.Controls.ctrlPatientDetails ctrlPatientDetails1;
        private Krypton.Toolkit.KryptonLabel lblCreatedDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel lblDay;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonLabel lblTime;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLinkLabel lblReschedule;
        private Krypton.Toolkit.KryptonLabel lblDoctorName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
    }
}

namespace HMS.Appointment
{
    partial class frmAddNewEditAppointment
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
            this.gbAppointmentData = new Krypton.Toolkit.KryptonGroupBox();
            this.lblTime = new Krypton.Toolkit.KryptonLabel();
            this.dtpDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.btnBack = new Krypton.Toolkit.KryptonButton();
            this.cbDoctors = new Krypton.Toolkit.KryptonComboBox();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.rbExamination = new Krypton.Toolkit.KryptonRadioButton();
            this.rbConsultation = new Krypton.Toolkit.KryptonRadioButton();
            this.cbTimeSlots = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.cbSpecializations = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.tcAddNewEditAppointment = new System.Windows.Forms.TabControl();
            this.tpPatientData = new System.Windows.Forms.TabPage();
            this.btnNext = new Krypton.Toolkit.KryptonButton();
            this.tpAppointmentData = new System.Windows.Forms.TabPage();
            this.ctrlPatientDetailsSelector1 = new HMS.Patient.Control.ctrlPatientDetailsSelector();
            ((System.ComponentModel.ISupportInitialize)(this.gbAppointmentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbAppointmentData.Panel)).BeginInit();
            this.gbAppointmentData.Panel.SuspendLayout();
            this.gbAppointmentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSpecializations)).BeginInit();
            this.tcAddNewEditAppointment.SuspendLayout();
            this.tpPatientData.SuspendLayout();
            this.tpAppointmentData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAppointmentData
            // 
            this.gbAppointmentData.CaptionOverlap = 1D;
            this.gbAppointmentData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbAppointmentData.Location = new System.Drawing.Point(8, 6);
            this.gbAppointmentData.Name = "gbAppointmentData";
            this.gbAppointmentData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbAppointmentData.Panel
            // 
            this.gbAppointmentData.Panel.Controls.Add(this.lblTime);
            this.gbAppointmentData.Panel.Controls.Add(this.dtpDate);
            this.gbAppointmentData.Panel.Controls.Add(this.btnBack);
            this.gbAppointmentData.Panel.Controls.Add(this.cbDoctors);
            this.gbAppointmentData.Panel.Controls.Add(this.btnClose);
            this.gbAppointmentData.Panel.Controls.Add(this.btnSave);
            this.gbAppointmentData.Panel.Controls.Add(this.kryptonLabel6);
            this.gbAppointmentData.Panel.Controls.Add(this.rbExamination);
            this.gbAppointmentData.Panel.Controls.Add(this.rbConsultation);
            this.gbAppointmentData.Panel.Controls.Add(this.cbTimeSlots);
            this.gbAppointmentData.Panel.Controls.Add(this.kryptonLabel4);
            this.gbAppointmentData.Panel.Controls.Add(this.kryptonLabel3);
            this.gbAppointmentData.Panel.Controls.Add(this.cbSpecializations);
            this.gbAppointmentData.Panel.Controls.Add(this.kryptonLabel2);
            this.gbAppointmentData.Size = new System.Drawing.Size(909, 585);
            this.gbAppointmentData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbAppointmentData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbAppointmentData.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.gbAppointmentData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAppointmentData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAppointmentData.TabIndex = 8;
            this.gbAppointmentData.Values.Heading = "Appointment Data";
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(144, 261);
            this.lblTime.Name = "lblTime";
            this.lblTime.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTime.Size = new System.Drawing.Size(119, 23);
            this.lblTime.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblTime.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.TabIndex = 52;
            this.lblTime.Values.Text = "No Time Slots";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarTodayDate = new System.DateTime(2026, 9, 15, 0, 0, 0, 0);
            this.dtpDate.CornerRoundingRadius = 20F;
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(144, 178);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dtpDate.Size = new System.Drawing.Size(214, 35);
            this.dtpDate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDate.StateCommon.Border.Rounding = 20F;
            this.dtpDate.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.TabIndex = 51;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.CornerRoundingRadius = 20F;
            this.btnBack.Location = new System.Drawing.Point(10, 493);
            this.btnBack.Name = "btnBack";
            this.btnBack.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnBack.Size = new System.Drawing.Size(96, 55);
            this.btnBack.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StateCommon.Border.Rounding = 20F;
            this.btnBack.TabIndex = 11;
            this.btnBack.Values.Image = global::HMS.Properties.Resources.Prev_32;
            this.btnBack.Values.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbDoctors
            // 
            this.cbDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctors.DropDownWidth = 143;
            this.cbDoctors.Enabled = false;
            this.cbDoctors.IntegralHeight = false;
            this.cbDoctors.Location = new System.Drawing.Point(144, 101);
            this.cbDoctors.Name = "cbDoctors";
            this.cbDoctors.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbDoctors.Size = new System.Drawing.Size(214, 35);
            this.cbDoctors.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbDoctors.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbDoctors.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoctors.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbDoctors.TabIndex = 26;
            this.cbDoctors.SelectedIndexChanged += new System.EventHandler(this.cbDoctors_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CornerRoundingRadius = 20F;
            this.btnClose.Location = new System.Drawing.Point(642, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClose.Size = new System.Drawing.Size(248, 35);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 20F;
            this.btnClose.TabIndex = 10;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CornerRoundingRadius = 20F;
            this.btnSave.Location = new System.Drawing.Point(642, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(248, 35);
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 20F;
            this.btnSave.TabIndex = 9;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(10, 107);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel6.Size = new System.Drawing.Size(72, 23);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 27;
            this.kryptonLabel6.Values.Text = "Doctor :";
            // 
            // rbExamination
            // 
            this.rbExamination.Checked = true;
            this.rbExamination.Location = new System.Drawing.Point(120, 332);
            this.rbExamination.Name = "rbExamination";
            this.rbExamination.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.rbExamination.Size = new System.Drawing.Size(115, 23);
            this.rbExamination.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExamination.TabIndex = 24;
            this.rbExamination.Values.Text = "Examination";
            // 
            // rbConsultation
            // 
            this.rbConsultation.Location = new System.Drawing.Point(275, 332);
            this.rbConsultation.Name = "rbConsultation";
            this.rbConsultation.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.rbConsultation.Size = new System.Drawing.Size(116, 23);
            this.rbConsultation.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConsultation.TabIndex = 25;
            this.rbConsultation.Values.Text = "Consultation";
            // 
            // cbTimeSlots
            // 
            this.cbTimeSlots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeSlots.DropDownWidth = 143;
            this.cbTimeSlots.IntegralHeight = false;
            this.cbTimeSlots.Location = new System.Drawing.Point(144, 255);
            this.cbTimeSlots.Name = "cbTimeSlots";
            this.cbTimeSlots.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbTimeSlots.Size = new System.Drawing.Size(214, 35);
            this.cbTimeSlots.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbTimeSlots.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbTimeSlots.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeSlots.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbTimeSlots.TabIndex = 22;
            this.cbTimeSlots.Visible = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(10, 261);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(59, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 23;
            this.kryptonLabel4.Values.Text = "Time :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(10, 184);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel3.Size = new System.Drawing.Size(57, 23);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 21;
            this.kryptonLabel3.Values.Text = "Date :";
            // 
            // cbSpecializations
            // 
            this.cbSpecializations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecializations.DropDownWidth = 143;
            this.cbSpecializations.IntegralHeight = false;
            this.cbSpecializations.Location = new System.Drawing.Point(144, 24);
            this.cbSpecializations.Name = "cbSpecializations";
            this.cbSpecializations.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbSpecializations.Size = new System.Drawing.Size(214, 35);
            this.cbSpecializations.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbSpecializations.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbSpecializations.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpecializations.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbSpecializations.TabIndex = 4;
            this.cbSpecializations.SelectedIndexChanged += new System.EventHandler(this.cbSpecializations_SelectedIndexChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(10, 30);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(128, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Specialization :";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(243, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTitle.Size = new System.Drawing.Size(438, 43);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Values.Text = "Schedule New Appointment";
            this.lblTitle.SizeChanged += new System.EventHandler(this.lblTitle_SizeChanged);
            // 
            // tcAddNewEditAppointment
            // 
            this.tcAddNewEditAppointment.Controls.Add(this.tpPatientData);
            this.tcAddNewEditAppointment.Controls.Add(this.tpAppointmentData);
            this.tcAddNewEditAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAddNewEditAppointment.Location = new System.Drawing.Point(0, 0);
            this.tcAddNewEditAppointment.Name = "tcAddNewEditAppointment";
            this.tcAddNewEditAppointment.SelectedIndex = 0;
            this.tcAddNewEditAppointment.Size = new System.Drawing.Size(933, 618);
            this.tcAddNewEditAppointment.TabIndex = 16;
            // 
            // tpPatientData
            // 
            this.tpPatientData.Controls.Add(this.btnNext);
            this.tpPatientData.Controls.Add(this.lblTitle);
            this.tpPatientData.Controls.Add(this.ctrlPatientDetailsSelector1);
            this.tpPatientData.Location = new System.Drawing.Point(4, 22);
            this.tpPatientData.Name = "tpPatientData";
            this.tpPatientData.Padding = new System.Windows.Forms.Padding(3);
            this.tpPatientData.Size = new System.Drawing.Size(925, 592);
            this.tpPatientData.TabIndex = 0;
            this.tpPatientData.Text = "tpPatientData";
            this.tpPatientData.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.CornerRoundingRadius = 20F;
            this.btnNext.Location = new System.Drawing.Point(821, 534);
            this.btnNext.Name = "btnNext";
            this.btnNext.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnNext.Size = new System.Drawing.Size(96, 55);
            this.btnNext.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateCommon.Border.Rounding = 20F;
            this.btnNext.TabIndex = 16;
            this.btnNext.Values.Image = global::HMS.Properties.Resources.Next_32;
            this.btnNext.Values.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpAppointmentData
            // 
            this.tpAppointmentData.Controls.Add(this.gbAppointmentData);
            this.tpAppointmentData.Location = new System.Drawing.Point(4, 22);
            this.tpAppointmentData.Name = "tpAppointmentData";
            this.tpAppointmentData.Padding = new System.Windows.Forms.Padding(3);
            this.tpAppointmentData.Size = new System.Drawing.Size(925, 592);
            this.tpAppointmentData.TabIndex = 1;
            this.tpAppointmentData.Text = "tpAppointmentData";
            this.tpAppointmentData.UseVisualStyleBackColor = true;
            // 
            // ctrlPatientDetailsSelector1
            // 
            this.ctrlPatientDetailsSelector1.Location = new System.Drawing.Point(5, 56);
            this.ctrlPatientDetailsSelector1.Name = "ctrlPatientDetailsSelector1";
            this.ctrlPatientDetailsSelector1.Size = new System.Drawing.Size(914, 475);
            this.ctrlPatientDetailsSelector1.TabIndex = 15;
            // 
            // frmAddNewEditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 618);
            this.Controls.Add(this.tcAddNewEditAppointment);
            this.Name = "frmAddNewEditAppointment";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "frmAddNewEditAppointment";
            this.Load += new System.EventHandler(this.frmAddNewEditAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbAppointmentData.Panel)).EndInit();
            this.gbAppointmentData.Panel.ResumeLayout(false);
            this.gbAppointmentData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbAppointmentData)).EndInit();
            this.gbAppointmentData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimeSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSpecializations)).EndInit();
            this.tcAddNewEditAppointment.ResumeLayout(false);
            this.tpPatientData.ResumeLayout(false);
            this.tpPatientData.PerformLayout();
            this.tpAppointmentData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbAppointmentData;
        private Krypton.Toolkit.KryptonComboBox cbSpecializations;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonComboBox cbTimeSlots;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonRadioButton rbExamination;
        private Krypton.Toolkit.KryptonRadioButton rbConsultation;
        private Patient.Control.ctrlPatientDetailsSelector ctrlPatientDetailsSelector1;
        private Krypton.Toolkit.KryptonComboBox cbDoctors;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private System.Windows.Forms.TabControl tcAddNewEditAppointment;
        private System.Windows.Forms.TabPage tpPatientData;
        private System.Windows.Forms.TabPage tpAppointmentData;
        private Krypton.Toolkit.KryptonButton btnBack;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnNext;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDate;
        private Krypton.Toolkit.KryptonLabel lblTime;
    }
}
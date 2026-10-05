namespace HMS.Patient_Charge
{
    partial class frmAddNewEditPatientCharge
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
            this.tcAddNewEditPatientCharge = new System.Windows.Forms.TabControl();
            this.tpAppointmentData = new System.Windows.Forms.TabPage();
            this.panelAppointmentData = new Krypton.Toolkit.KryptonPanel();
            this.btnNext = new Krypton.Toolkit.KryptonButton();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.tpPatientChargeData = new System.Windows.Forms.TabPage();
            this.gbPatientChargeData = new Krypton.Toolkit.KryptonGroupBox();
            this.cbTestTypes = new Krypton.Toolkit.KryptonComboBox();
            this.lblTestType = new Krypton.Toolkit.KryptonLabel();
            this.tbDiscountPercentage = new Youssef.WinForms.Controls.JOTextBox();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.lblFinalFees = new Krypton.Toolkit.KryptonLabel();
            this.lblOriginalFees = new Krypton.Toolkit.KryptonLabel();
            this.btnBack = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.cbChargeServices = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.ctrlAppointmentDetailsSelector1 = new HMS.Appointment.Control.ctrlAppointmentDetailsSelector();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.tcAddNewEditPatientCharge.SuspendLayout();
            this.tpAppointmentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAppointmentData)).BeginInit();
            this.panelAppointmentData.SuspendLayout();
            this.tpPatientChargeData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientChargeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientChargeData.Panel)).BeginInit();
            this.gbPatientChargeData.Panel.SuspendLayout();
            this.gbPatientChargeData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTestTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChargeServices)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAddNewEditPatientCharge
            // 
            this.tcAddNewEditPatientCharge.Controls.Add(this.tpAppointmentData);
            this.tcAddNewEditPatientCharge.Controls.Add(this.tpPatientChargeData);
            this.tcAddNewEditPatientCharge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAddNewEditPatientCharge.Location = new System.Drawing.Point(0, 0);
            this.tcAddNewEditPatientCharge.Name = "tcAddNewEditPatientCharge";
            this.tcAddNewEditPatientCharge.SelectedIndex = 0;
            this.tcAddNewEditPatientCharge.Size = new System.Drawing.Size(959, 484);
            this.tcAddNewEditPatientCharge.TabIndex = 17;
            // 
            // tpAppointmentData
            // 
            this.tpAppointmentData.Controls.Add(this.panelAppointmentData);
            this.tpAppointmentData.Controls.Add(this.btnNext);
            this.tpAppointmentData.Controls.Add(this.lblTitle);
            this.tpAppointmentData.Location = new System.Drawing.Point(4, 22);
            this.tpAppointmentData.Name = "tpAppointmentData";
            this.tpAppointmentData.Padding = new System.Windows.Forms.Padding(3);
            this.tpAppointmentData.Size = new System.Drawing.Size(951, 458);
            this.tpAppointmentData.TabIndex = 0;
            this.tpAppointmentData.Text = "tpAppointmentData";
            this.tpAppointmentData.UseVisualStyleBackColor = true;
            // 
            // panelAppointmentData
            // 
            this.panelAppointmentData.AutoScroll = true;
            this.panelAppointmentData.Controls.Add(this.ctrlAppointmentDetailsSelector1);
            this.panelAppointmentData.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelAppointmentData.Location = new System.Drawing.Point(6, 62);
            this.panelAppointmentData.Name = "panelAppointmentData";
            this.panelAppointmentData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.panelAppointmentData.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlCustom2;
            this.panelAppointmentData.Size = new System.Drawing.Size(935, 400);
            this.panelAppointmentData.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelAppointmentData.TabIndex = 58;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.CornerRoundingRadius = 20F;
            this.btnNext.Location = new System.Drawing.Point(893, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnNext.Size = new System.Drawing.Size(48, 48);
            this.btnNext.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateCommon.Border.Rounding = 20F;
            this.btnNext.TabIndex = 16;
            this.btnNext.Values.Image = global::HMS.Properties.Resources.Next_32;
            this.btnNext.Values.Text = "";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(280, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTitle.Size = new System.Drawing.Size(391, 43);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Values.Text = "Add New Patient Charge";
            // 
            // tpPatientChargeData
            // 
            this.tpPatientChargeData.Controls.Add(this.gbPatientChargeData);
            this.tpPatientChargeData.Location = new System.Drawing.Point(4, 22);
            this.tpPatientChargeData.Name = "tpPatientChargeData";
            this.tpPatientChargeData.Padding = new System.Windows.Forms.Padding(3);
            this.tpPatientChargeData.Size = new System.Drawing.Size(951, 458);
            this.tpPatientChargeData.TabIndex = 1;
            this.tpPatientChargeData.Text = "tpPatientChargeData";
            this.tpPatientChargeData.UseVisualStyleBackColor = true;
            // 
            // gbPatientChargeData
            // 
            this.gbPatientChargeData.CaptionOverlap = 1D;
            this.gbPatientChargeData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbPatientChargeData.Location = new System.Drawing.Point(8, 6);
            this.gbPatientChargeData.Name = "gbPatientChargeData";
            this.gbPatientChargeData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbPatientChargeData.Panel
            // 
            this.gbPatientChargeData.Panel.Controls.Add(this.cbTestTypes);
            this.gbPatientChargeData.Panel.Controls.Add(this.lblTestType);
            this.gbPatientChargeData.Panel.Controls.Add(this.tbDiscountPercentage);
            this.gbPatientChargeData.Panel.Controls.Add(this.btnClose);
            this.gbPatientChargeData.Panel.Controls.Add(this.btnSave);
            this.gbPatientChargeData.Panel.Controls.Add(this.lblFinalFees);
            this.gbPatientChargeData.Panel.Controls.Add(this.lblOriginalFees);
            this.gbPatientChargeData.Panel.Controls.Add(this.btnBack);
            this.gbPatientChargeData.Panel.Controls.Add(this.kryptonLabel6);
            this.gbPatientChargeData.Panel.Controls.Add(this.cbChargeServices);
            this.gbPatientChargeData.Panel.Controls.Add(this.kryptonLabel4);
            this.gbPatientChargeData.Panel.Controls.Add(this.kryptonLabel3);
            this.gbPatientChargeData.Panel.Controls.Add(this.kryptonLabel2);
            this.gbPatientChargeData.Size = new System.Drawing.Size(935, 444);
            this.gbPatientChargeData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbPatientChargeData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbPatientChargeData.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.gbPatientChargeData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientChargeData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientChargeData.TabIndex = 8;
            this.gbPatientChargeData.Values.Heading = "Patient Charge Data";
            // 
            // cbTestTypes
            // 
            this.cbTestTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTestTypes.DropDownWidth = 143;
            this.cbTestTypes.IntegralHeight = false;
            this.cbTestTypes.Location = new System.Drawing.Point(634, 147);
            this.cbTestTypes.Name = "cbTestTypes";
            this.cbTestTypes.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbTestTypes.Size = new System.Drawing.Size(181, 35);
            this.cbTestTypes.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbTestTypes.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbTestTypes.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTestTypes.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbTestTypes.TabIndex = 58;
            this.cbTestTypes.Visible = false;
            this.cbTestTypes.SelectedIndexChanged += new System.EventHandler(this.cbTestTypes_SelectedIndexChanged);
            // 
            // lblTestType
            // 
            this.lblTestType.Location = new System.Drawing.Point(448, 159);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTestType.Size = new System.Drawing.Size(97, 23);
            this.lblTestType.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestType.TabIndex = 57;
            this.lblTestType.Values.Text = "Test Type :";
            this.lblTestType.Visible = false;
            // 
            // tbDiscountPercentage
            // 
            this.tbDiscountPercentage.AllowLetters = false;
            this.tbDiscountPercentage.AllowSpecialCharacters = false;
            this.tbDiscountPercentage.CornerRoundingRadius = 20F;
            this.tbDiscountPercentage.Location = new System.Drawing.Point(634, 65);
            this.tbDiscountPercentage.MaxLength = 2;
            this.tbDiscountPercentage.Name = "tbDiscountPercentage";
            this.tbDiscountPercentage.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbDiscountPercentage.Size = new System.Drawing.Size(181, 35);
            this.tbDiscountPercentage.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbDiscountPercentage.StateCommon.Border.Rounding = 20F;
            this.tbDiscountPercentage.TabIndex = 56;
            this.tbDiscountPercentage.TextChanged += new System.EventHandler(this.tbDiscountPercentage_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CornerRoundingRadius = 20F;
            this.btnClose.Location = new System.Drawing.Point(664, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClose.Size = new System.Drawing.Size(255, 41);
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
            this.btnSave.Location = new System.Drawing.Point(664, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(255, 41);
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 20F;
            this.btnSave.TabIndex = 9;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFinalFees
            // 
            this.lblFinalFees.Location = new System.Drawing.Point(169, 247);
            this.lblFinalFees.Name = "lblFinalFees";
            this.lblFinalFees.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblFinalFees.Size = new System.Drawing.Size(21, 23);
            this.lblFinalFees.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblFinalFees.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalFees.TabIndex = 55;
            this.lblFinalFees.Values.Text = "0";
            // 
            // lblOriginalFees
            // 
            this.lblOriginalFees.Location = new System.Drawing.Point(169, 159);
            this.lblOriginalFees.Name = "lblOriginalFees";
            this.lblOriginalFees.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblOriginalFees.Size = new System.Drawing.Size(21, 23);
            this.lblOriginalFees.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblOriginalFees.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalFees.TabIndex = 52;
            this.lblOriginalFees.Values.Text = "0";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.CornerRoundingRadius = 20F;
            this.btnBack.Location = new System.Drawing.Point(3, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnBack.Size = new System.Drawing.Size(48, 48);
            this.btnBack.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StateCommon.Border.Rounding = 20F;
            this.btnBack.TabIndex = 11;
            this.btnBack.Values.Image = global::HMS.Properties.Resources.Prev_32;
            this.btnBack.Values.Text = "";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(24, 247);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel6.Size = new System.Drawing.Size(101, 23);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 27;
            this.kryptonLabel6.Values.Text = "Final Fees :";
            // 
            // cbChargeServices
            // 
            this.cbChargeServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChargeServices.DropDownWidth = 143;
            this.cbChargeServices.IntegralHeight = false;
            this.cbChargeServices.Location = new System.Drawing.Point(169, 65);
            this.cbChargeServices.Name = "cbChargeServices";
            this.cbChargeServices.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbChargeServices.Size = new System.Drawing.Size(181, 35);
            this.cbChargeServices.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbChargeServices.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbChargeServices.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChargeServices.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbChargeServices.TabIndex = 22;
            this.cbChargeServices.SelectedIndexChanged += new System.EventHandler(this.cbChargeServices_SelectedIndexChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(24, 71);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(139, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 23;
            this.kryptonLabel4.Values.Text = "Charge Service :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(24, 159);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(123, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Original Fees :";
            // 
            // ctrlAppointmentDetailsSelector1
            // 
            this.ctrlAppointmentDetailsSelector1.Location = new System.Drawing.Point(2, -6);
            this.ctrlAppointmentDetailsSelector1.Name = "ctrlAppointmentDetailsSelector1";
            this.ctrlAppointmentDetailsSelector1.Size = new System.Drawing.Size(914, 643);
            this.ctrlAppointmentDetailsSelector1.TabIndex = 17;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(448, 71);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel3.Size = new System.Drawing.Size(180, 23);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 21;
            this.kryptonLabel3.Values.Text = "Discount Percentage :";
            // 
            // frmAddNewEditPatientCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 484);
            this.Controls.Add(this.tcAddNewEditPatientCharge);
            this.Name = "frmAddNewEditPatientCharge";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "frmAddNewEditPatientCharge";
            this.Load += new System.EventHandler(this.frmAddNewEditPatientCharge_Load);
            this.tcAddNewEditPatientCharge.ResumeLayout(false);
            this.tpAppointmentData.ResumeLayout(false);
            this.tpAppointmentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAppointmentData)).EndInit();
            this.panelAppointmentData.ResumeLayout(false);
            this.tpPatientChargeData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientChargeData.Panel)).EndInit();
            this.gbPatientChargeData.Panel.ResumeLayout(false);
            this.gbPatientChargeData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPatientChargeData)).EndInit();
            this.gbPatientChargeData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbTestTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChargeServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAddNewEditPatientCharge;
        private System.Windows.Forms.TabPage tpAppointmentData;
        private Krypton.Toolkit.KryptonButton btnNext;
        private Appointment.Control.ctrlAppointmentDetailsSelector ctrlAppointmentDetailsSelector1;
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private System.Windows.Forms.TabPage tpPatientChargeData;
        private Krypton.Toolkit.KryptonGroupBox gbPatientChargeData;
        private Krypton.Toolkit.KryptonLabel lblOriginalFees;
        private Krypton.Toolkit.KryptonButton btnBack;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonComboBox cbChargeServices;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Youssef.WinForms.Controls.JOTextBox tbDiscountPercentage;
        private Krypton.Toolkit.KryptonLabel lblFinalFees;
        private Krypton.Toolkit.KryptonPanel panelAppointmentData;
        private Krypton.Toolkit.KryptonComboBox cbTestTypes;
        private Krypton.Toolkit.KryptonLabel lblTestType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}
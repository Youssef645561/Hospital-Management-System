namespace HMS.Medical_Visit
{
    partial class frmAddNewEditMedicalVisit
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
            this.gbMedicalVisitData = new Krypton.Toolkit.KryptonGroupBox();
            this.lblAddPrescription = new Krypton.Toolkit.KryptonLinkLabel();
            this.lblEditPrescription = new Krypton.Toolkit.KryptonLinkLabel();
            this.tbNotes = new Youssef.WinForms.Controls.JOTextBox();
            this.tbDiagnosis = new Youssef.WinForms.Controls.JOTextBox();
            this.tbSymptoms = new Youssef.WinForms.Controls.JOTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.lblRequestLabTest = new Krypton.Toolkit.KryptonLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gbMedicalVisitData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMedicalVisitData.Panel)).BeginInit();
            this.gbMedicalVisitData.Panel.SuspendLayout();
            this.gbMedicalVisitData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(195, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTitle.Size = new System.Drawing.Size(356, 43);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Values.Text = "Add New Medical Visit";
            this.lblTitle.SizeChanged += new System.EventHandler(this.lblTitle_SizeChanged);
            // 
            // gbMedicalVisitData
            // 
            this.gbMedicalVisitData.CaptionOverlap = 1D;
            this.gbMedicalVisitData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbMedicalVisitData.Location = new System.Drawing.Point(12, 61);
            this.gbMedicalVisitData.Name = "gbMedicalVisitData";
            this.gbMedicalVisitData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbMedicalVisitData.Panel
            // 
            this.gbMedicalVisitData.Panel.Controls.Add(this.lblRequestLabTest);
            this.gbMedicalVisitData.Panel.Controls.Add(this.lblAddPrescription);
            this.gbMedicalVisitData.Panel.Controls.Add(this.lblEditPrescription);
            this.gbMedicalVisitData.Panel.Controls.Add(this.tbNotes);
            this.gbMedicalVisitData.Panel.Controls.Add(this.tbDiagnosis);
            this.gbMedicalVisitData.Panel.Controls.Add(this.tbSymptoms);
            this.gbMedicalVisitData.Panel.Controls.Add(this.kryptonLabel1);
            this.gbMedicalVisitData.Panel.Controls.Add(this.kryptonButton1);
            this.gbMedicalVisitData.Panel.Controls.Add(this.kryptonLabel4);
            this.gbMedicalVisitData.Panel.Controls.Add(this.kryptonLabel2);
            this.gbMedicalVisitData.Size = new System.Drawing.Size(722, 295);
            this.gbMedicalVisitData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbMedicalVisitData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbMedicalVisitData.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.gbMedicalVisitData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedicalVisitData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedicalVisitData.TabIndex = 43;
            this.gbMedicalVisitData.Values.Description = "ID : ???";
            this.gbMedicalVisitData.Values.Heading = "Medical Visit Data";
            // 
            // lblAddPrescription
            // 
            this.lblAddPrescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddPrescription.Location = new System.Drawing.Point(586, 246);
            this.lblAddPrescription.Name = "lblAddPrescription";
            this.lblAddPrescription.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblAddPrescription.Size = new System.Drawing.Size(129, 21);
            this.lblAddPrescription.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPrescription.TabIndex = 47;
            this.lblAddPrescription.Values.Text = "Add Prescription";
            this.lblAddPrescription.LinkClicked += new System.EventHandler(this.lblAddPrescription_LinkClicked);
            // 
            // lblEditPrescription
            // 
            this.lblEditPrescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditPrescription.Location = new System.Drawing.Point(586, 246);
            this.lblEditPrescription.Name = "lblEditPrescription";
            this.lblEditPrescription.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblEditPrescription.Size = new System.Drawing.Size(129, 21);
            this.lblEditPrescription.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPrescription.TabIndex = 48;
            this.lblEditPrescription.Values.Text = "Edit Prescription";
            this.lblEditPrescription.LinkClicked += new System.EventHandler(this.lblEditPrescription_LinkClicked);
            // 
            // tbNotes
            // 
            this.tbNotes.CornerRoundingRadius = 20F;
            this.tbNotes.Location = new System.Drawing.Point(121, 178);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbNotes.Size = new System.Drawing.Size(380, 75);
            this.tbNotes.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbNotes.StateCommon.Border.Rounding = 20F;
            this.tbNotes.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNotes.TabIndex = 46;
            // 
            // tbDiagnosis
            // 
            this.tbDiagnosis.CornerRoundingRadius = 20F;
            this.tbDiagnosis.Location = new System.Drawing.Point(121, 97);
            this.tbDiagnosis.Multiline = true;
            this.tbDiagnosis.Name = "tbDiagnosis";
            this.tbDiagnosis.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbDiagnosis.Size = new System.Drawing.Size(380, 75);
            this.tbDiagnosis.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbDiagnosis.StateCommon.Border.Rounding = 20F;
            this.tbDiagnosis.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiagnosis.TabIndex = 45;
            // 
            // tbSymptoms
            // 
            this.tbSymptoms.CornerRoundingRadius = 20F;
            this.tbSymptoms.Location = new System.Drawing.Point(121, 16);
            this.tbSymptoms.Multiline = true;
            this.tbSymptoms.Name = "tbSymptoms";
            this.tbSymptoms.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbSymptoms.Size = new System.Drawing.Size(380, 75);
            this.tbSymptoms.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSymptoms.StateCommon.Border.Rounding = 20F;
            this.tbSymptoms.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSymptoms.TabIndex = 44;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 97);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(97, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 42;
            this.kryptonLabel1.Values.Text = "Diagnosis :";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.CornerRoundingRadius = 20F;
            this.kryptonButton1.Location = new System.Drawing.Point(1324, 10);
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
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(13, 178);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(66, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Notes :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(13, 16);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(102, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Symptoms :";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CornerRoundingRadius = 20F;
            this.btnSave.Location = new System.Drawing.Point(556, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(178, 35);
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 20F;
            this.btnSave.TabIndex = 45;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CornerRoundingRadius = 20F;
            this.btnClose.Location = new System.Drawing.Point(556, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClose.Size = new System.Drawing.Size(178, 35);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 20F;
            this.btnClose.TabIndex = 44;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRequestLabTest
            // 
            this.lblRequestLabTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequestLabTest.Location = new System.Drawing.Point(578, 3);
            this.lblRequestLabTest.Name = "lblRequestLabTest";
            this.lblRequestLabTest.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblRequestLabTest.Size = new System.Drawing.Size(137, 21);
            this.lblRequestLabTest.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestLabTest.TabIndex = 49;
            this.lblRequestLabTest.Values.Text = "Request Lab Test";
            this.lblRequestLabTest.LinkClicked += new System.EventHandler(this.lblRequestLabTest_LinkClicked);
            // 
            // frmAddNewEditMedicalVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbMedicalVisitData);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddNewEditMedicalVisit";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "frmAddNewEditMedicalVisit";
            this.Load += new System.EventHandler(this.frmAddNewEditMedicalVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbMedicalVisitData.Panel)).EndInit();
            this.gbMedicalVisitData.Panel.ResumeLayout(false);
            this.gbMedicalVisitData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbMedicalVisitData)).EndInit();
            this.gbMedicalVisitData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Krypton.Toolkit.KryptonGroupBox gbMedicalVisitData;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Youssef.WinForms.Controls.JOTextBox tbNotes;
        private Youssef.WinForms.Controls.JOTextBox tbDiagnosis;
        private Youssef.WinForms.Controls.JOTextBox tbSymptoms;
        private Krypton.Toolkit.KryptonLinkLabel lblAddPrescription;
        private Krypton.Toolkit.KryptonLinkLabel lblEditPrescription;
        private Krypton.Toolkit.KryptonLinkLabel lblRequestLabTest;
    }
}
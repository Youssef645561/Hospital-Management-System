namespace HMS.Medicine
{
    partial class frmAddNewEditMedicine
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
            this.gbMedicineData = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.cbDosageForms = new Krypton.Toolkit.KryptonComboBox();
            this.tbName = new Youssef.WinForms.Controls.JOTextBox();
            this.tbStrength = new Youssef.WinForms.Controls.JOTextBox();
            this.tbDescription = new Youssef.WinForms.Controls.JOTextBox();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.ckActive = new Krypton.Toolkit.KryptonCheckBox();
            this.lblCreatedBy = new Krypton.Toolkit.KryptonLabel();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gbMedicineData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMedicineData.Panel)).BeginInit();
            this.gbMedicineData.Panel.SuspendLayout();
            this.gbMedicineData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDosageForms)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMedicineData
            // 
            this.gbMedicineData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMedicineData.CaptionOverlap = 1D;
            this.gbMedicineData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbMedicineData.Location = new System.Drawing.Point(12, 61);
            this.gbMedicineData.Name = "gbMedicineData";
            this.gbMedicineData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbMedicineData.Panel
            // 
            this.gbMedicineData.Panel.Controls.Add(this.lblCreatedBy);
            this.gbMedicineData.Panel.Controls.Add(this.ckActive);
            this.gbMedicineData.Panel.Controls.Add(this.tbDescription);
            this.gbMedicineData.Panel.Controls.Add(this.tbStrength);
            this.gbMedicineData.Panel.Controls.Add(this.tbName);
            this.gbMedicineData.Panel.Controls.Add(this.kryptonLabel7);
            this.gbMedicineData.Panel.Controls.Add(this.cbDosageForms);
            this.gbMedicineData.Panel.Controls.Add(this.kryptonLabel5);
            this.gbMedicineData.Panel.Controls.Add(this.kryptonLabel3);
            this.gbMedicineData.Panel.Controls.Add(this.kryptonLabel4);
            this.gbMedicineData.Size = new System.Drawing.Size(642, 198);
            this.gbMedicineData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbMedicineData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbMedicineData.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.gbMedicineData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedicineData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedicineData.TabIndex = 0;
            this.gbMedicineData.Values.Description = "ID = ???";
            this.gbMedicineData.Values.Heading = "Medicine Data";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(16, 122);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel7.Size = new System.Drawing.Size(107, 23);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 38;
            this.kryptonLabel7.Values.Text = "Description :";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(336, 20);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel5.Size = new System.Drawing.Size(86, 23);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 36;
            this.kryptonLabel5.Values.Text = "Strength :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(16, 61);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel3.Size = new System.Drawing.Size(124, 23);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 34;
            this.kryptonLabel3.Values.Text = "Dosage Form :";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(16, 20);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(66, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Name :";
            // 
            // cbDosageForms
            // 
            this.cbDosageForms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDosageForms.DropDownWidth = 143;
            this.cbDosageForms.IntegralHeight = false;
            this.cbDosageForms.Location = new System.Drawing.Point(146, 55);
            this.cbDosageForms.Name = "cbDosageForms";
            this.cbDosageForms.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbDosageForms.Size = new System.Drawing.Size(155, 35);
            this.cbDosageForms.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbDosageForms.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbDosageForms.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDosageForms.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbDosageForms.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.AllowDigits = false;
            this.tbName.AllowSpecialCharacters = false;
            this.tbName.CornerRoundingRadius = 20F;
            this.tbName.Location = new System.Drawing.Point(146, 14);
            this.tbName.Name = "tbName";
            this.tbName.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbName.Size = new System.Drawing.Size(155, 35);
            this.tbName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbName.StateCommon.Border.Rounding = 20F;
            this.tbName.TabIndex = 1;
            // 
            // tbStrength
            // 
            this.tbStrength.AllowLetters = false;
            this.tbStrength.AllowSpecialCharacters = false;
            this.tbStrength.CornerRoundingRadius = 20F;
            this.tbStrength.Location = new System.Drawing.Point(428, 14);
            this.tbStrength.Name = "tbStrength";
            this.tbStrength.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbStrength.Size = new System.Drawing.Size(155, 35);
            this.tbStrength.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbStrength.StateCommon.Border.Rounding = 20F;
            this.tbStrength.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.AllowDigits = false;
            this.tbDescription.AllowSpecialCharacters = false;
            this.tbDescription.CornerRoundingRadius = 20F;
            this.tbDescription.Location = new System.Drawing.Point(146, 96);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbDescription.Size = new System.Drawing.Size(437, 74);
            this.tbDescription.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbDescription.StateCommon.Border.Rounding = 20F;
            this.tbDescription.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CornerRoundingRadius = 20F;
            this.btnSave.Location = new System.Drawing.Point(556, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(98, 35);
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 20F;
            this.btnSave.TabIndex = 6;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CornerRoundingRadius = 20F;
            this.btnClose.Location = new System.Drawing.Point(452, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClose.Size = new System.Drawing.Size(98, 35);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 20F;
            this.btnClose.TabIndex = 7;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ckActive
            // 
            this.ckActive.Checked = true;
            this.ckActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckActive.Location = new System.Drawing.Point(348, 65);
            this.ckActive.Name = "ckActive";
            this.ckActive.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.ckActive.Size = new System.Drawing.Size(62, 19);
            this.ckActive.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckActive.TabIndex = 4;
            this.ckActive.Values.Text = "Active";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.Location = new System.Drawing.Point(589, 20);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblCreatedBy.Size = new System.Drawing.Size(35, 23);
            this.lblCreatedBy.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblCreatedBy.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.TabIndex = 45;
            this.lblCreatedBy.Values.Text = "mg";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(183, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTitle.Size = new System.Drawing.Size(301, 43);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Values.Text = "Add New Medicine";
            this.lblTitle.SizeChanged += new System.EventHandler(this.lblTitle_SizeChanged);
            // 
            // frmAddNewEditMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 312);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbMedicineData);
            this.Name = "frmAddNewEditMedicine";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "frmAddNewEditMedicine";
            this.Load += new System.EventHandler(this.frmAddNewEditMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbMedicineData.Panel)).EndInit();
            this.gbMedicineData.Panel.ResumeLayout(false);
            this.gbMedicineData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbMedicineData)).EndInit();
            this.gbMedicineData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbDosageForms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbMedicineData;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonComboBox cbDosageForms;
        private Youssef.WinForms.Controls.JOTextBox tbDescription;
        private Youssef.WinForms.Controls.JOTextBox tbStrength;
        private Youssef.WinForms.Controls.JOTextBox tbName;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonCheckBox ckActive;
        private Krypton.Toolkit.KryptonLabel lblCreatedBy;
        private Krypton.Toolkit.KryptonLabel lblTitle;
    }
}
namespace HMS.Payment
{
    partial class frmAddNewEditPayment
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
            this.gbPaymentData = new Krypton.Toolkit.KryptonGroupBox();
            this.tbPaidAmount = new Youssef.WinForms.Controls.JOTextBox();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.cbPaymentMethods = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.ctrlPatientChargeDetailsSelector1 = new HMS.Patient_Charge.Control.ctrlPatientChargeDetailsSelector();
            ((System.ComponentModel.ISupportInitialize)(this.gbPaymentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPaymentData.Panel)).BeginInit();
            this.gbPaymentData.Panel.SuspendLayout();
            this.gbPaymentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentMethods)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(255, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTitle.Size = new System.Drawing.Size(298, 43);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Values.Text = "Add New Payment";
            // 
            // gbPaymentData
            // 
            this.gbPaymentData.CaptionOverlap = 1D;
            this.gbPaymentData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbPaymentData.Location = new System.Drawing.Point(12, 526);
            this.gbPaymentData.Name = "gbPaymentData";
            this.gbPaymentData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbPaymentData.Panel
            // 
            this.gbPaymentData.Panel.Controls.Add(this.tbPaidAmount);
            this.gbPaymentData.Panel.Controls.Add(this.kryptonButton1);
            this.gbPaymentData.Panel.Controls.Add(this.cbPaymentMethods);
            this.gbPaymentData.Panel.Controls.Add(this.kryptonLabel4);
            this.gbPaymentData.Panel.Controls.Add(this.kryptonLabel2);
            this.gbPaymentData.Size = new System.Drawing.Size(633, 80);
            this.gbPaymentData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbPaymentData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbPaymentData.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.gbPaymentData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaymentData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaymentData.TabIndex = 45;
            this.gbPaymentData.Values.Heading = "Payment Data";
            // 
            // tbPaidAmount
            // 
            this.tbPaidAmount.CornerRoundingRadius = 20F;
            this.tbPaidAmount.Location = new System.Drawing.Point(477, 10);
            this.tbPaidAmount.Name = "tbPaidAmount";
            this.tbPaidAmount.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbPaidAmount.Size = new System.Drawing.Size(128, 35);
            this.tbPaidAmount.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPaidAmount.StateCommon.Border.Rounding = 20F;
            this.tbPaidAmount.TabIndex = 38;
            this.tbPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPaidAmount_KeyPress);
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
            // cbPaymentMethods
            // 
            this.cbPaymentMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethods.DropDownWidth = 143;
            this.cbPaymentMethods.IntegralHeight = false;
            this.cbPaymentMethods.Location = new System.Drawing.Point(169, 10);
            this.cbPaymentMethods.Name = "cbPaymentMethods";
            this.cbPaymentMethods.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbPaymentMethods.Size = new System.Drawing.Size(128, 35);
            this.cbPaymentMethods.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbPaymentMethods.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbPaymentMethods.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethods.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbPaymentMethods.TabIndex = 2;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(352, 16);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(119, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Paid Amount :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(13, 16);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(150, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Payment Method :";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CornerRoundingRadius = 20F;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(651, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(146, 35);
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 20F;
            this.btnSave.TabIndex = 46;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CornerRoundingRadius = 20F;
            this.btnClose.Location = new System.Drawing.Point(651, 571);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClose.Size = new System.Drawing.Size(146, 35);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 20F;
            this.btnClose.TabIndex = 44;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlPatientChargeDetailsSelector1
            // 
            this.ctrlPatientChargeDetailsSelector1.Location = new System.Drawing.Point(5, 61);
            this.ctrlPatientChargeDetailsSelector1.Name = "ctrlPatientChargeDetailsSelector1";
            this.ctrlPatientChargeDetailsSelector1.Size = new System.Drawing.Size(799, 463);
            this.ctrlPatientChargeDetailsSelector1.TabIndex = 47;
            // 
            // frmAddNewEditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 613);
            this.Controls.Add(this.ctrlPatientChargeDetailsSelector1);
            this.Controls.Add(this.gbPaymentData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddNewEditPayment";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "frmAddNewEditPayment";
            this.Load += new System.EventHandler(this.frmAddNewEditPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbPaymentData.Panel)).EndInit();
            this.gbPaymentData.Panel.ResumeLayout(false);
            this.gbPaymentData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPaymentData)).EndInit();
            this.gbPaymentData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentMethods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Krypton.Toolkit.KryptonGroupBox gbPaymentData;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonComboBox cbPaymentMethods;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Youssef.WinForms.Controls.JOTextBox tbPaidAmount;
        private Patient_Charge.Control.ctrlPatientChargeDetailsSelector ctrlPatientChargeDetailsSelector1;
    }
}
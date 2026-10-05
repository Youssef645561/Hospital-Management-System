namespace HMS.Users
{
    partial class frmChangeUserPassword
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
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.lblPassword = new Krypton.Toolkit.KryptonLabel();
            this.gbChangePassword = new Krypton.Toolkit.KryptonGroupBox();
            this.tbNewPassword = new Youssef.WinForms.Controls.JOTextBox();
            this.tbConfirmPassword = new Youssef.WinForms.Controls.JOTextBox();
            this.tbCurrentPassword = new Youssef.WinForms.Controls.JOTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gbChangePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbChangePassword.Panel)).BeginInit();
            this.gbChangePassword.Panel.SuspendLayout();
            this.gbChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(135, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTitle.Size = new System.Drawing.Size(223, 33);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Values.Text = "Change Password";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CornerRoundingRadius = 20F;
            this.btnClose.Location = new System.Drawing.Point(278, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClose.Size = new System.Drawing.Size(98, 35);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 20F;
            this.btnClose.TabIndex = 4;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CornerRoundingRadius = 20F;
            this.btnSave.Location = new System.Drawing.Point(382, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(98, 35);
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 20F;
            this.btnSave.TabIndex = 5;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(49, 32);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(158, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Current Password :";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(49, 73);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(134, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "New Password :";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(49, 114);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblPassword.Size = new System.Drawing.Size(161, 23);
            this.lblPassword.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.TabIndex = 44;
            this.lblPassword.Values.Text = "Confirm Password :";
            // 
            // gbChangePassword
            // 
            this.gbChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbChangePassword.CaptionOverlap = 1D;
            this.gbChangePassword.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbChangePassword.Location = new System.Drawing.Point(12, 52);
            this.gbChangePassword.Name = "gbChangePassword";
            this.gbChangePassword.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbChangePassword.Panel
            // 
            this.gbChangePassword.Panel.Controls.Add(this.tbNewPassword);
            this.gbChangePassword.Panel.Controls.Add(this.lblPassword);
            this.gbChangePassword.Panel.Controls.Add(this.tbConfirmPassword);
            this.gbChangePassword.Panel.Controls.Add(this.tbCurrentPassword);
            this.gbChangePassword.Panel.Controls.Add(this.kryptonLabel4);
            this.gbChangePassword.Panel.Controls.Add(this.kryptonLabel2);
            this.gbChangePassword.Size = new System.Drawing.Size(468, 193);
            this.gbChangePassword.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbChangePassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbChangePassword.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChangePassword.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChangePassword.TabIndex = 0;
            this.gbChangePassword.Values.Description = "ID : ???";
            this.gbChangePassword.Values.Heading = "???";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.CornerRoundingRadius = 20F;
            this.tbNewPassword.Location = new System.Drawing.Point(216, 67);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbNewPassword.Size = new System.Drawing.Size(200, 35);
            this.tbNewPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbNewPassword.StateCommon.Border.Rounding = 20F;
            this.tbNewPassword.TabIndex = 2;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.CornerRoundingRadius = 20F;
            this.tbConfirmPassword.Location = new System.Drawing.Point(216, 108);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbConfirmPassword.Size = new System.Drawing.Size(200, 35);
            this.tbConfirmPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbConfirmPassword.StateCommon.Border.Rounding = 20F;
            this.tbConfirmPassword.TabIndex = 3;
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.CornerRoundingRadius = 20F;
            this.tbCurrentPassword.Location = new System.Drawing.Point(216, 26);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbCurrentPassword.Size = new System.Drawing.Size(200, 35);
            this.tbCurrentPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbCurrentPassword.StateCommon.Border.Rounding = 20F;
            this.tbCurrentPassword.TabIndex = 1;
            // 
            // frmChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 298);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbChangePassword);
            this.Controls.Add(this.btnSave);
            this.Name = "frmChangeUserPassword";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangeUserPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbChangePassword.Panel)).EndInit();
            this.gbChangePassword.Panel.ResumeLayout(false);
            this.gbChangePassword.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbChangePassword)).EndInit();
            this.gbChangePassword.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel lblPassword;
        private Krypton.Toolkit.KryptonGroupBox gbChangePassword;
        private Youssef.WinForms.Controls.JOTextBox tbNewPassword;
        private Youssef.WinForms.Controls.JOTextBox tbConfirmPassword;
        private Youssef.WinForms.Controls.JOTextBox tbCurrentPassword;
    }
}
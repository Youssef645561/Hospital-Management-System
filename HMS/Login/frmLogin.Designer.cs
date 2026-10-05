namespace HMS.Login
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.tbUsername = new Youssef.WinForms.Controls.JOTextBox();
            this.btnLogin = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.tbPassword = new Youssef.WinForms.Controls.JOTextBox();
            this.gbCredentials = new Krypton.Toolkit.KryptonGroupBox();
            this.ckRememberMe = new Krypton.Toolkit.KryptonCheckBox();
            this.errp1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gbCredentials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCredentials.Panel)).BeginInit();
            this.gbCredentials.Panel.SuspendLayout();
            this.gbCredentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errp1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.AllowSpecialCharacters = false;
            this.tbUsername.CornerRoundingRadius = 20F;
            this.tbUsername.Location = new System.Drawing.Point(185, 88);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbUsername.Size = new System.Drawing.Size(250, 35);
            this.tbUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUsername.StateCommon.Border.Rounding = 20F;
            this.tbUsername.TabIndex = 0;
            this.tbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress);
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.CornerRoundingRadius = 20F;
            this.btnLogin.Location = new System.Drawing.Point(185, 196);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnLogin.Size = new System.Drawing.Size(250, 35);
            this.btnLogin.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateCommon.Border.Rounding = 20F;
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Values.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(79, 94);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel7.Size = new System.Drawing.Size(100, 23);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 36;
            this.kryptonLabel7.Values.Text = "Username :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(79, 135);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(96, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 38;
            this.kryptonLabel1.Values.Text = "Password :";
            // 
            // tbPassword
            // 
            this.tbPassword.AllowSpecialCharacters = false;
            this.tbPassword.CornerRoundingRadius = 20F;
            this.tbPassword.Location = new System.Drawing.Point(185, 129);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(250, 35);
            this.tbPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPassword.StateCommon.Border.Rounding = 20F;
            this.tbPassword.TabIndex = 1;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress);
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // gbCredentials
            // 
            this.gbCredentials.CaptionOverlap = 1D;
            this.gbCredentials.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbCredentials.Location = new System.Drawing.Point(8, 10);
            this.gbCredentials.Name = "gbCredentials";
            this.gbCredentials.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbCredentials.Panel
            // 
            this.gbCredentials.Panel.Controls.Add(this.ckRememberMe);
            this.gbCredentials.Panel.Controls.Add(this.tbUsername);
            this.gbCredentials.Panel.Controls.Add(this.btnLogin);
            this.gbCredentials.Panel.Controls.Add(this.kryptonLabel1);
            this.gbCredentials.Panel.Controls.Add(this.kryptonLabel7);
            this.gbCredentials.Panel.Controls.Add(this.tbPassword);
            this.gbCredentials.Size = new System.Drawing.Size(519, 317);
            this.gbCredentials.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbCredentials.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbCredentials.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCredentials.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCredentials.TabIndex = 3;
            this.gbCredentials.Values.Heading = "User Login";
            // 
            // ckRememberMe
            // 
            this.ckRememberMe.Checked = true;
            this.ckRememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckRememberMe.Location = new System.Drawing.Point(185, 170);
            this.ckRememberMe.Name = "ckRememberMe";
            this.ckRememberMe.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.ckRememberMe.Size = new System.Drawing.Size(104, 20);
            this.ckRememberMe.TabIndex = 2;
            this.ckRememberMe.Values.Text = "Remember me";
            // 
            // errp1
            // 
            this.errp1.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 336);
            this.Controls.Add(this.gbCredentials);
            this.Name = "frmLogin";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbCredentials.Panel)).EndInit();
            this.gbCredentials.Panel.ResumeLayout(false);
            this.gbCredentials.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbCredentials)).EndInit();
            this.gbCredentials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errp1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Youssef.WinForms.Controls.JOTextBox tbUsername;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Youssef.WinForms.Controls.JOTextBox tbPassword;
        private Krypton.Toolkit.KryptonGroupBox gbCredentials;
        private System.Windows.Forms.ErrorProvider errp1;
        private Krypton.Toolkit.KryptonCheckBox ckRememberMe;
    }
}
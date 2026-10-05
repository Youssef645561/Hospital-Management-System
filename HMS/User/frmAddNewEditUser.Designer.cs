namespace HMS.Users
{
    partial class frmAddNewEditUser
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
            this.gbUserData = new Krypton.Toolkit.KryptonGroupBox();
            this.ckActive = new Krypton.Toolkit.KryptonCheckBox();
            this.lblResetPassword = new Krypton.Toolkit.KryptonLinkLabel();
            this.lblPassword = new Krypton.Toolkit.KryptonLabel();
            this.tbPassword = new Youssef.WinForms.Controls.JOTextBox();
            this.tbUsername = new Youssef.WinForms.Controls.JOTextBox();
            this.cbUserRoles = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.errp1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gbUserData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbUserData.Panel)).BeginInit();
            this.gbUserData.Panel.SuspendLayout();
            this.gbUserData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errp1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUserData
            // 
            this.gbUserData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUserData.CaptionOverlap = 1D;
            this.gbUserData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbUserData.Location = new System.Drawing.Point(12, 52);
            this.gbUserData.Name = "gbUserData";
            this.gbUserData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbUserData.Panel
            // 
            this.gbUserData.Panel.Controls.Add(this.ckActive);
            this.gbUserData.Panel.Controls.Add(this.lblResetPassword);
            this.gbUserData.Panel.Controls.Add(this.lblPassword);
            this.gbUserData.Panel.Controls.Add(this.tbPassword);
            this.gbUserData.Panel.Controls.Add(this.tbUsername);
            this.gbUserData.Panel.Controls.Add(this.cbUserRoles);
            this.gbUserData.Panel.Controls.Add(this.kryptonLabel4);
            this.gbUserData.Panel.Controls.Add(this.kryptonLabel2);
            this.gbUserData.Size = new System.Drawing.Size(348, 193);
            this.gbUserData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbUserData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbUserData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserData.TabIndex = 0;
            this.gbUserData.Values.Description = "ID : ???";
            this.gbUserData.Values.Heading = "User Data";
            // 
            // ckActive
            // 
            this.ckActive.Location = new System.Drawing.Point(37, 133);
            this.ckActive.Name = "ckActive";
            this.ckActive.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.ckActive.Size = new System.Drawing.Size(60, 19);
            this.ckActive.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckActive.TabIndex = 4;
            this.ckActive.Values.Text = "Active";
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.Location = new System.Drawing.Point(159, 104);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblResetPassword.Size = new System.Drawing.Size(132, 23);
            this.lblResetPassword.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPassword.TabIndex = 3;
            this.lblResetPassword.Values.Text = "Reset Password";
            this.lblResetPassword.Visible = false;
            this.lblResetPassword.LinkClicked += new System.EventHandler(this.lblResetPassword_LinkClicked);
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(19, 104);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblPassword.Size = new System.Drawing.Size(96, 23);
            this.lblPassword.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.TabIndex = 44;
            this.lblPassword.Values.Text = "Password :";
            // 
            // tbPassword
            // 
            this.tbPassword.CornerRoundingRadius = 20F;
            this.tbPassword.Location = new System.Drawing.Point(125, 98);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbPassword.Size = new System.Drawing.Size(200, 35);
            this.tbPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPassword.StateCommon.Border.Rounding = 20F;
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Visible = false;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // tbUsername
            // 
            this.tbUsername.CornerRoundingRadius = 20F;
            this.tbUsername.Location = new System.Drawing.Point(125, 16);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbUsername.Size = new System.Drawing.Size(200, 35);
            this.tbUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUsername.StateCommon.Border.Rounding = 20F;
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // cbUserRoles
            // 
            this.cbUserRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserRoles.DropDownWidth = 143;
            this.cbUserRoles.IntegralHeight = false;
            this.cbUserRoles.Location = new System.Drawing.Point(125, 57);
            this.cbUserRoles.Name = "cbUserRoles";
            this.cbUserRoles.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbUserRoles.Size = new System.Drawing.Size(200, 35);
            this.cbUserRoles.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbUserRoles.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbUserRoles.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserRoles.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbUserRoles.TabIndex = 2;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(19, 63);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(97, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "User Role :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(19, 22);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(100, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Username :";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CornerRoundingRadius = 20F;
            this.btnSave.Location = new System.Drawing.Point(262, 251);
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
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CornerRoundingRadius = 20F;
            this.btnClose.Location = new System.Drawing.Point(158, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClose.Size = new System.Drawing.Size(98, 35);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 20F;
            this.btnClose.TabIndex = 5;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(91, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTitle.Size = new System.Drawing.Size(178, 33);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Values.Text = "Add New User";
            this.lblTitle.SizeChanged += new System.EventHandler(this.lblTitle_SizeChanged);
            // 
            // errp1
            // 
            this.errp1.ContainerControl = this;
            // 
            // frmAddNewEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 298);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbUserData);
            this.Controls.Add(this.btnSave);
            this.Name = "frmAddNewEditUser";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "frmAddNewEditUser";
            this.Load += new System.EventHandler(this.frmAddNewEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbUserData.Panel)).EndInit();
            this.gbUserData.Panel.ResumeLayout(false);
            this.gbUserData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbUserData)).EndInit();
            this.gbUserData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbUserRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbUserData;
        private Krypton.Toolkit.KryptonCheckBox ckActive;
        private Krypton.Toolkit.KryptonLinkLabel lblResetPassword;
        private Krypton.Toolkit.KryptonLabel lblPassword;
        private Youssef.WinForms.Controls.JOTextBox tbPassword;
        private Youssef.WinForms.Controls.JOTextBox tbUsername;
        private Krypton.Toolkit.KryptonComboBox cbUserRoles;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private System.Windows.Forms.ErrorProvider errp1;
    }
}
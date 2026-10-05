namespace HMS.User_Roles
{
    partial class frmAddNewEditUserRole
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
            this.gbUserRoleData = new Krypton.Toolkit.KryptonGroupBox();
            this.lblPermissions = new Krypton.Toolkit.KryptonLabel();
            this.tbName = new Youssef.WinForms.Controls.JOTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.gbUserRoleData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbUserRoleData.Panel)).BeginInit();
            this.gbUserRoleData.Panel.SuspendLayout();
            this.gbUserRoleData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(95, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTitle.Size = new System.Drawing.Size(238, 33);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Values.Text = "Add New User Role";
            this.lblTitle.SizeChanged += new System.EventHandler(this.lblTitle_SizeChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CornerRoundingRadius = 20F;
            this.btnClose.Location = new System.Drawing.Point(214, 188);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClose.Size = new System.Drawing.Size(98, 35);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 20F;
            this.btnClose.TabIndex = 12;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbUserRoleData
            // 
            this.gbUserRoleData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUserRoleData.CaptionOverlap = 1D;
            this.gbUserRoleData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbUserRoleData.Location = new System.Drawing.Point(12, 51);
            this.gbUserRoleData.Name = "gbUserRoleData";
            this.gbUserRoleData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbUserRoleData.Panel
            // 
            this.gbUserRoleData.Panel.Controls.Add(this.lblPermissions);
            this.gbUserRoleData.Panel.Controls.Add(this.tbName);
            this.gbUserRoleData.Panel.Controls.Add(this.kryptonLabel4);
            this.gbUserRoleData.Panel.Controls.Add(this.kryptonLabel2);
            this.gbUserRoleData.Size = new System.Drawing.Size(404, 131);
            this.gbUserRoleData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbUserRoleData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbUserRoleData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserRoleData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserRoleData.TabIndex = 11;
            this.gbUserRoleData.Values.Description = "ID : ???";
            this.gbUserRoleData.Values.Heading = "User Role Data";
            // 
            // lblPermissions
            // 
            this.lblPermissions.Location = new System.Drawing.Point(140, 65);
            this.lblPermissions.Name = "lblPermissions";
            this.lblPermissions.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblPermissions.Size = new System.Drawing.Size(40, 23);
            this.lblPermissions.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblPermissions.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermissions.TabIndex = 37;
            this.lblPermissions.Values.Text = "???";
            // 
            // tbName
            // 
            this.tbName.CornerRoundingRadius = 20F;
            this.tbName.Location = new System.Drawing.Point(140, 18);
            this.tbName.Name = "tbName";
            this.tbName.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbName.Size = new System.Drawing.Size(200, 35);
            this.tbName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbName.StateCommon.Border.Rounding = 20F;
            this.tbName.TabIndex = 1;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(19, 65);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(115, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Permissions :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(19, 24);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(66, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Name :";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CornerRoundingRadius = 20F;
            this.btnSave.Location = new System.Drawing.Point(318, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(98, 35);
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 20F;
            this.btnSave.TabIndex = 13;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddNewEditUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 234);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbUserRoleData);
            this.Controls.Add(this.btnSave);
            this.Name = "frmAddNewEditUserRole";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "frmAddNewEditUserRole";
            this.Load += new System.EventHandler(this.frmAddNewEditUserRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbUserRoleData.Panel)).EndInit();
            this.gbUserRoleData.Panel.ResumeLayout(false);
            this.gbUserRoleData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbUserRoleData)).EndInit();
            this.gbUserRoleData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonGroupBox gbUserRoleData;
        private Youssef.WinForms.Controls.JOTextBox tbName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonLabel lblPermissions;
    }
}
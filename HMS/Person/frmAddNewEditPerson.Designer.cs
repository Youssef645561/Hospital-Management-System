namespace HMS.People
{
    partial class frmAddNewEditPerson
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
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.gbPersonData = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblRemove = new Krypton.Toolkit.KryptonLinkLabel();
            this.pbpPersonalImage = new Krypton.Toolkit.KryptonPictureBox();
            this.rbMale = new Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.tbEmail = new Youssef.WinForms.Controls.JOTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.tbSecondName = new Youssef.WinForms.Controls.JOTextBox();
            this.lblSetImage = new Krypton.Toolkit.KryptonLinkLabel();
            this.tbLastName = new Youssef.WinForms.Controls.JOTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.tbPhone = new Youssef.WinForms.Controls.JOTextBox();
            this.tbFirstName = new Youssef.WinForms.Controls.JOTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.rbFemale = new Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.dtpDateOfBirth = new Krypton.Toolkit.KryptonDateTimePicker();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.ofdPersonalImage = new System.Windows.Forms.OpenFileDialog();
            this.errp1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gbPersonData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPersonData.Panel)).BeginInit();
            this.gbPersonData.Panel.SuspendLayout();
            this.gbPersonData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpPersonalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errp1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(296, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTitle.Size = new System.Drawing.Size(272, 43);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Values.Text = "Add New Person";
            this.lblTitle.SizeChanged += new System.EventHandler(this.lblTitle_SizeChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CornerRoundingRadius = 20F;
            this.btnClose.Location = new System.Drawing.Point(654, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClose.Size = new System.Drawing.Size(98, 35);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 20F;
            this.btnClose.TabIndex = 11;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbPersonData
            // 
            this.gbPersonData.CaptionOverlap = 1D;
            this.gbPersonData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbPersonData.Location = new System.Drawing.Point(9, 61);
            this.gbPersonData.Name = "gbPersonData";
            this.gbPersonData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbPersonData.Panel
            // 
            this.gbPersonData.Panel.Controls.Add(this.kryptonLabel7);
            this.gbPersonData.Panel.Controls.Add(this.kryptonLabel1);
            this.gbPersonData.Panel.Controls.Add(this.lblRemove);
            this.gbPersonData.Panel.Controls.Add(this.pbpPersonalImage);
            this.gbPersonData.Panel.Controls.Add(this.rbMale);
            this.gbPersonData.Panel.Controls.Add(this.kryptonLabel3);
            this.gbPersonData.Panel.Controls.Add(this.tbEmail);
            this.gbPersonData.Panel.Controls.Add(this.kryptonLabel5);
            this.gbPersonData.Panel.Controls.Add(this.tbSecondName);
            this.gbPersonData.Panel.Controls.Add(this.lblSetImage);
            this.gbPersonData.Panel.Controls.Add(this.tbLastName);
            this.gbPersonData.Panel.Controls.Add(this.kryptonLabel4);
            this.gbPersonData.Panel.Controls.Add(this.tbPhone);
            this.gbPersonData.Panel.Controls.Add(this.tbFirstName);
            this.gbPersonData.Panel.Controls.Add(this.kryptonLabel6);
            this.gbPersonData.Panel.Controls.Add(this.rbFemale);
            this.gbPersonData.Panel.Controls.Add(this.kryptonLabel2);
            this.gbPersonData.Panel.Controls.Add(this.dtpDateOfBirth);
            this.gbPersonData.Size = new System.Drawing.Size(847, 300);
            this.gbPersonData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbPersonData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbPersonData.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.gbPersonData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonData.TabIndex = 0;
            this.gbPersonData.Values.Description = "ID = ???";
            this.gbPersonData.Values.Heading = "Person Data";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(283, 177);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel7.Size = new System.Drawing.Size(70, 23);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 23;
            this.kryptonLabel7.Values.Text = "Phone :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 15);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(105, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Text = "First Name :";
            // 
            // lblRemove
            // 
            this.lblRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemove.Location = new System.Drawing.Point(692, 245);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblRemove.Size = new System.Drawing.Size(69, 21);
            this.lblRemove.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.TabIndex = 9;
            this.lblRemove.Values.Text = "Remove";
            this.lblRemove.Visible = false;
            this.lblRemove.Click += new System.EventHandler(this.lblRemove_LinkClicked);
            // 
            // pbpPersonalImage
            // 
            this.pbpPersonalImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbpPersonalImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbpPersonalImage.Image = global::HMS.Properties.Resources.Male_512;
            this.pbpPersonalImage.Location = new System.Drawing.Point(626, 62);
            this.pbpPersonalImage.Name = "pbpPersonalImage";
            this.pbpPersonalImage.Size = new System.Drawing.Size(200, 150);
            this.pbpPersonalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpPersonalImage.TabIndex = 25;
            this.pbpPersonalImage.TabStop = false;
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(136, 178);
            this.rbMale.Name = "rbMale";
            this.rbMale.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.rbMale.Size = new System.Drawing.Size(49, 20);
            this.rbMale.TabIndex = 6;
            this.rbMale.Values.Text = "Male";
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbGender_CheckedChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(589, 15);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel3.Size = new System.Drawing.Size(103, 23);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 14;
            this.kryptonLabel3.Values.Text = "Last Name :";
            // 
            // tbEmail
            // 
            this.tbEmail.CornerRoundingRadius = 20F;
            this.tbEmail.Location = new System.Drawing.Point(417, 90);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbEmail.Size = new System.Drawing.Size(128, 35);
            this.tbEmail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbEmail.StateCommon.Border.Rounding = 20F;
            this.tbEmail.TabIndex = 5;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(5, 177);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel5.Size = new System.Drawing.Size(78, 23);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 19;
            this.kryptonLabel5.Values.Text = "Gender :";
            // 
            // tbSecondName
            // 
            this.tbSecondName.AllowDigits = false;
            this.tbSecondName.AllowSpecialCharacters = false;
            this.tbSecondName.CornerRoundingRadius = 20F;
            this.tbSecondName.Location = new System.Drawing.Point(417, 9);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbSecondName.Size = new System.Drawing.Size(128, 35);
            this.tbSecondName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSecondName.StateCommon.Border.Rounding = 20F;
            this.tbSecondName.TabIndex = 2;
            this.tbSecondName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // lblSetImage
            // 
            this.lblSetImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSetImage.Location = new System.Drawing.Point(684, 218);
            this.lblSetImage.Name = "lblSetImage";
            this.lblSetImage.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblSetImage.Size = new System.Drawing.Size(84, 21);
            this.lblSetImage.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetImage.TabIndex = 8;
            this.lblSetImage.Values.Text = "Set Image";
            this.lblSetImage.Click += new System.EventHandler(this.lblSetImage_LinkClicked);
            // 
            // tbLastName
            // 
            this.tbLastName.AllowDigits = false;
            this.tbLastName.AllowSpecialCharacters = false;
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.CornerRoundingRadius = 20F;
            this.tbLastName.Location = new System.Drawing.Point(698, 9);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbLastName.Size = new System.Drawing.Size(128, 35);
            this.tbLastName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbLastName.StateCommon.Border.Rounding = 20F;
            this.tbLastName.TabIndex = 3;
            this.tbLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(5, 96);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(120, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 17;
            this.kryptonLabel4.Values.Text = "Date Of Birth :";
            // 
            // tbPhone
            // 
            this.tbPhone.AllowLetters = false;
            this.tbPhone.AllowSpecialCharacters = false;
            this.tbPhone.CornerRoundingRadius = 20F;
            this.tbPhone.Location = new System.Drawing.Point(417, 171);
            this.tbPhone.MaxLength = 11;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbPhone.Size = new System.Drawing.Size(128, 35);
            this.tbPhone.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPhone.StateCommon.Border.Rounding = 20F;
            this.tbPhone.TabIndex = 7;
            this.tbPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // tbFirstName
            // 
            this.tbFirstName.AllowDigits = false;
            this.tbFirstName.AllowSpecialCharacters = false;
            this.tbFirstName.CornerRoundingRadius = 20F;
            this.tbFirstName.Location = new System.Drawing.Point(136, 9);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.tbFirstName.Size = new System.Drawing.Size(128, 35);
            this.tbFirstName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbFirstName.StateCommon.Border.Rounding = 20F;
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(283, 96);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel6.Size = new System.Drawing.Size(64, 23);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 21;
            this.kryptonLabel6.Values.Text = "Email :";
            // 
            // rbFemale
            // 
            this.rbFemale.Location = new System.Drawing.Point(203, 178);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.rbFemale.Size = new System.Drawing.Size(61, 20);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.Values.Text = "Female";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(283, 15);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(129, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Second Name :";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CornerRoundingRadius = 20F;
            this.dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(136, 90);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dtpDateOfBirth.Size = new System.Drawing.Size(128, 33);
            this.dtpDateOfBirth.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDateOfBirth.StateCommon.Border.Rounding = 20F;
            this.dtpDateOfBirth.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CornerRoundingRadius = 20F;
            this.btnSave.Location = new System.Drawing.Point(758, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(98, 35);
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 20F;
            this.btnSave.TabIndex = 10;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ofdPersonalImage
            // 
            this.ofdPersonalImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // errp1
            // 
            this.errp1.ContainerControl = this;
            // 
            // frmAddNewEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 414);
            this.Controls.Add(this.gbPersonData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddNewEditPerson";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.StateCommon.Header.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.Text = "Title";
            this.Load += new System.EventHandler(this.frmAddNewEditPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbPersonData.Panel)).EndInit();
            this.gbPersonData.Panel.ResumeLayout(false);
            this.gbPersonData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPersonData)).EndInit();
            this.gbPersonData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbpPersonalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonGroupBox gbPersonData;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLinkLabel lblRemove;
        private Krypton.Toolkit.KryptonPictureBox pbpPersonalImage;
        private Krypton.Toolkit.KryptonRadioButton rbMale;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Youssef.WinForms.Controls.JOTextBox tbEmail;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Youssef.WinForms.Controls.JOTextBox tbSecondName;
        private Krypton.Toolkit.KryptonLinkLabel lblSetImage;
        private Youssef.WinForms.Controls.JOTextBox tbLastName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Youssef.WinForms.Controls.JOTextBox tbPhone;
        private Youssef.WinForms.Controls.JOTextBox tbFirstName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonRadioButton rbFemale;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDateOfBirth;
        private Krypton.Toolkit.KryptonButton btnSave;
        private System.Windows.Forms.OpenFileDialog ofdPersonalImage;
        private System.Windows.Forms.ErrorProvider errp1;
    }
}
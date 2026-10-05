namespace HMS.Prescription
{
    partial class frmAddNewEditPrescription
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
            this.gbPrescriptionData = new Krypton.Toolkit.KryptonGroupBox();
            this.dtpExpirationDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.cbStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.tcAddNewEditPrescription = new System.Windows.Forms.TabControl();
            this.tpMedicalVisitData = new System.Windows.Forms.TabPage();
            this.btnNext = new Krypton.Toolkit.KryptonButton();
            this.tpMedicinesData = new System.Windows.Forms.TabPage();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.gbMedicinesData = new Krypton.Toolkit.KryptonGroupBox();
            this.btnBack = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.dgvMedicines = new Youssef.WinForms.Controls.JODataGridView();
            this.lblRowCount = new Krypton.Toolkit.KryptonLabel();
            this.ctrlMedicalVisitDetailsSelector1 = new HMS.Medical_Visit.Control.ctrlMedicalVisitDetailsSelector();
            this.ctrlMedicineSelector1 = new HMS.Medicine.Control.ctrlMedicineSelector();
            this.cmsMedicines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemovetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gbPrescriptionData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPrescriptionData.Panel)).BeginInit();
            this.gbPrescriptionData.Panel.SuspendLayout();
            this.gbPrescriptionData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.tcAddNewEditPrescription.SuspendLayout();
            this.tpMedicalVisitData.SuspendLayout();
            this.tpMedicinesData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbMedicinesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMedicinesData.Panel)).BeginInit();
            this.gbMedicinesData.Panel.SuspendLayout();
            this.gbMedicinesData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.cmsMedicines.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(299, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lblTitle.Size = new System.Drawing.Size(345, 43);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Values.Text = "Add New Prescription";
            this.lblTitle.SizeChanged += new System.EventHandler(this.lblTitle_SizeChanged);
            // 
            // gbPrescriptionData
            // 
            this.gbPrescriptionData.CaptionOverlap = 1D;
            this.gbPrescriptionData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbPrescriptionData.Location = new System.Drawing.Point(8, 551);
            this.gbPrescriptionData.Name = "gbPrescriptionData";
            this.gbPrescriptionData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbPrescriptionData.Panel
            // 
            this.gbPrescriptionData.Panel.Controls.Add(this.dtpExpirationDate);
            this.gbPrescriptionData.Panel.Controls.Add(this.cbStatus);
            this.gbPrescriptionData.Panel.Controls.Add(this.kryptonLabel1);
            this.gbPrescriptionData.Panel.Controls.Add(this.kryptonLabel2);
            this.gbPrescriptionData.Size = new System.Drawing.Size(565, 81);
            this.gbPrescriptionData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbPrescriptionData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbPrescriptionData.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.gbPrescriptionData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrescriptionData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrescriptionData.TabIndex = 48;
            this.gbPrescriptionData.Values.Description = "ID = ???";
            this.gbPrescriptionData.Values.Heading = "Prescription Data";
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.CalendarTodayDate = new System.DateTime(2026, 9, 15, 0, 0, 0, 0);
            this.dtpExpirationDate.CornerRoundingRadius = 20F;
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDate.Location = new System.Drawing.Point(392, 11);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dtpExpirationDate.Size = new System.Drawing.Size(155, 35);
            this.dtpExpirationDate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpExpirationDate.StateCommon.Border.Rounding = 20F;
            this.dtpExpirationDate.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirationDate.TabIndex = 52;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.DropDownWidth = 143;
            this.cbStatus.Enabled = false;
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "Expired",
            "Cancelled"});
            this.cbStatus.Location = new System.Drawing.Point(89, 11);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbStatus.Size = new System.Drawing.Size(155, 35);
            this.cbStatus.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbStatus.StateCommon.ComboBox.Border.Rounding = 20F;
            this.cbStatus.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbStatus.TabIndex = 3;
            this.cbStatus.Text = "Active";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 17);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(70, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Text = "Status :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(250, 17);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(136, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Expiration date :";
            // 
            // tcAddNewEditPrescription
            // 
            this.tcAddNewEditPrescription.Controls.Add(this.tpMedicalVisitData);
            this.tcAddNewEditPrescription.Controls.Add(this.tpMedicinesData);
            this.tcAddNewEditPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAddNewEditPrescription.Location = new System.Drawing.Point(0, 0);
            this.tcAddNewEditPrescription.Name = "tcAddNewEditPrescription";
            this.tcAddNewEditPrescription.SelectedIndex = 0;
            this.tcAddNewEditPrescription.Size = new System.Drawing.Size(950, 664);
            this.tcAddNewEditPrescription.TabIndex = 49;
            // 
            // tpMedicalVisitData
            // 
            this.tpMedicalVisitData.Controls.Add(this.btnNext);
            this.tpMedicalVisitData.Controls.Add(this.gbPrescriptionData);
            this.tpMedicalVisitData.Controls.Add(this.lblTitle);
            this.tpMedicalVisitData.Controls.Add(this.ctrlMedicalVisitDetailsSelector1);
            this.tpMedicalVisitData.Location = new System.Drawing.Point(4, 22);
            this.tpMedicalVisitData.Name = "tpMedicalVisitData";
            this.tpMedicalVisitData.Padding = new System.Windows.Forms.Padding(3);
            this.tpMedicalVisitData.Size = new System.Drawing.Size(942, 638);
            this.tpMedicalVisitData.TabIndex = 0;
            this.tpMedicalVisitData.Text = "tpMedicalVisitData";
            this.tpMedicalVisitData.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.CornerRoundingRadius = 20F;
            this.btnNext.Location = new System.Drawing.Point(838, 577);
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
            // tpMedicinesData
            // 
            this.tpMedicinesData.Controls.Add(this.btnClose);
            this.tpMedicinesData.Controls.Add(this.btnBack);
            this.tpMedicinesData.Controls.Add(this.btnSave);
            this.tpMedicinesData.Controls.Add(this.gbMedicinesData);
            this.tpMedicinesData.Location = new System.Drawing.Point(4, 22);
            this.tpMedicinesData.Name = "tpMedicinesData";
            this.tpMedicinesData.Padding = new System.Windows.Forms.Padding(3);
            this.tpMedicinesData.Size = new System.Drawing.Size(942, 638);
            this.tpMedicinesData.TabIndex = 1;
            this.tpMedicinesData.Text = "tpMedicinesData";
            this.tpMedicinesData.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CornerRoundingRadius = 20F;
            this.btnClose.Location = new System.Drawing.Point(784, 586);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClose.Size = new System.Drawing.Size(150, 44);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 20F;
            this.btnClose.TabIndex = 46;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CornerRoundingRadius = 20F;
            this.btnSave.Location = new System.Drawing.Point(784, 536);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(150, 44);
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 20F;
            this.btnSave.TabIndex = 47;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbMedicinesData
            // 
            this.gbMedicinesData.CaptionOverlap = 1D;
            this.gbMedicinesData.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.gbMedicinesData.Location = new System.Drawing.Point(8, 3);
            this.gbMedicinesData.Name = "gbMedicinesData";
            this.gbMedicinesData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbMedicinesData.Panel
            // 
            this.gbMedicinesData.Panel.Controls.Add(this.lblRowCount);
            this.gbMedicinesData.Panel.Controls.Add(this.dgvMedicines);
            this.gbMedicinesData.Panel.Controls.Add(this.kryptonLabel4);
            this.gbMedicinesData.Panel.Controls.Add(this.kryptonLabel3);
            this.gbMedicinesData.Panel.Controls.Add(this.ctrlMedicineSelector1);
            this.gbMedicinesData.Size = new System.Drawing.Size(927, 527);
            this.gbMedicinesData.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.gbMedicinesData.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbMedicinesData.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.gbMedicinesData.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedicinesData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedicinesData.TabIndex = 8;
            this.gbMedicinesData.Values.Heading = "Medicines Data";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.CornerRoundingRadius = 20F;
            this.btnBack.Location = new System.Drawing.Point(8, 577);
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
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(567, 8);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel3.Size = new System.Drawing.Size(220, 36);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 37;
            this.kryptonLabel3.Values.Text = "Select Medicine";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(63, 8);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(307, 36);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 38;
            this.kryptonLabel4.Values.Text = "Prescription Medicines";
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.AllowUserToAddRows = false;
            this.dgvMedicines.AllowUserToDeleteRows = false;
            this.dgvMedicines.AllowUserToOrderColumns = true;
            this.dgvMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicines.ColumnHeadersHeight = 30;
            this.dgvMedicines.ContextMenuStrip = this.cmsMedicines;
            this.dgvMedicines.Location = new System.Drawing.Point(3, 142);
            this.dgvMedicines.MultiSelect = false;
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgvMedicines.ReadOnly = true;
            this.dgvMedicines.RowHeadersVisible = false;
            this.dgvMedicines.RowHeadersWidth = 40;
            this.dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicines.Size = new System.Drawing.Size(426, 337);
            this.dgvMedicines.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvMedicines.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvMedicines.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMedicines.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dgvMedicines.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMedicines.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvMedicines.TabIndex = 39;
            this.dgvMedicines.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMedicines_CellFormatting);
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowCount.Location = new System.Drawing.Point(3, 482);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(24, 20);
            this.lblRowCount.TabIndex = 40;
            this.lblRowCount.Values.Text = "#0";
            // 
            // ctrlMedicalVisitDetailsSelector1
            // 
            this.ctrlMedicalVisitDetailsSelector1.Location = new System.Drawing.Point(8, 65);
            this.ctrlMedicalVisitDetailsSelector1.Name = "ctrlMedicalVisitDetailsSelector1";
            this.ctrlMedicalVisitDetailsSelector1.Size = new System.Drawing.Size(926, 480);
            this.ctrlMedicalVisitDetailsSelector1.TabIndex = 47;
            // 
            // ctrlMedicineSelector1
            // 
            this.ctrlMedicineSelector1.Location = new System.Drawing.Point(435, 50);
            this.ctrlMedicineSelector1.MinimumSize = new System.Drawing.Size(485, 200);
            this.ctrlMedicineSelector1.Name = "ctrlMedicineSelector1";
            this.ctrlMedicineSelector1.Size = new System.Drawing.Size(485, 454);
            this.ctrlMedicineSelector1.TabIndex = 12;
            // 
            // cmsMedicines
            // 
            this.cmsMedicines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsMedicines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemovetoolStripMenuItem});
            this.cmsMedicines.Name = "cmsPeople";
            this.cmsMedicines.Size = new System.Drawing.Size(197, 64);
            // 
            // RemovetoolStripMenuItem
            // 
            this.RemovetoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovetoolStripMenuItem.Image = global::HMS.Properties.Resources.Delete_Medicine_32;
            this.RemovetoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RemovetoolStripMenuItem.Name = "RemovetoolStripMenuItem";
            this.RemovetoolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.RemovetoolStripMenuItem.Text = "Remove";
            this.RemovetoolStripMenuItem.Click += new System.EventHandler(this.RemovetoolStripMenuItem_Click);
            // 
            // frmAddNewEditPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 664);
            this.Controls.Add(this.tcAddNewEditPrescription);
            this.Name = "frmAddNewEditPrescription";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "frmAddNewEditPrescription";
            this.Load += new System.EventHandler(this.frmAddNewEditPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbPrescriptionData.Panel)).EndInit();
            this.gbPrescriptionData.Panel.ResumeLayout(false);
            this.gbPrescriptionData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPrescriptionData)).EndInit();
            this.gbPrescriptionData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.tcAddNewEditPrescription.ResumeLayout(false);
            this.tpMedicalVisitData.ResumeLayout(false);
            this.tpMedicalVisitData.PerformLayout();
            this.tpMedicinesData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbMedicinesData.Panel)).EndInit();
            this.gbMedicinesData.Panel.ResumeLayout(false);
            this.gbMedicinesData.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbMedicinesData)).EndInit();
            this.gbMedicinesData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.cmsMedicines.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Medical_Visit.Control.ctrlMedicalVisitDetailsSelector ctrlMedicalVisitDetailsSelector1;
        private Krypton.Toolkit.KryptonGroupBox gbPrescriptionData;
        private Krypton.Toolkit.KryptonComboBox cbStatus;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonDateTimePicker dtpExpirationDate;
        private System.Windows.Forms.TabControl tcAddNewEditPrescription;
        private System.Windows.Forms.TabPage tpMedicalVisitData;
        private Krypton.Toolkit.KryptonButton btnNext;
        private System.Windows.Forms.TabPage tpMedicinesData;
        private Krypton.Toolkit.KryptonGroupBox gbMedicinesData;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnBack;
        private Medicine.Control.ctrlMedicineSelector ctrlMedicineSelector1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Youssef.WinForms.Controls.JODataGridView dgvMedicines;
        private Krypton.Toolkit.KryptonLabel lblRowCount;
        private System.Windows.Forms.ContextMenuStrip cmsMedicines;
        private System.Windows.Forms.ToolStripMenuItem RemovetoolStripMenuItem;
    }
}
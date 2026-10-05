namespace HMS.Appointment
{
    partial class frmPatientAppointmentsHistory
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
            this.ctrlPatientAppointmentsHistory1 = new HMS.Appointment.Control.ctrlPatientAppointmentsHistory();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // ctrlPatientAppointmentsHistory1
            // 
            this.ctrlPatientAppointmentsHistory1.Location = new System.Drawing.Point(14, 10);
            this.ctrlPatientAppointmentsHistory1.Name = "ctrlPatientAppointmentsHistory1";
            this.ctrlPatientAppointmentsHistory1.Size = new System.Drawing.Size(750, 350);
            this.ctrlPatientAppointmentsHistory1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CornerRoundingRadius = 20F;
            this.btnClose.Location = new System.Drawing.Point(666, 337);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClose.Size = new System.Drawing.Size(98, 35);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 20F;
            this.btnClose.TabIndex = 15;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPatientAppointmentsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 384);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPatientAppointmentsHistory1);
            this.Name = "frmPatientAppointmentsHistory";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.Text = "Patient Appointments History";
            this.Load += new System.EventHandler(this.frmPatientAppointmentsHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.ctrlPatientAppointmentsHistory ctrlPatientAppointmentsHistory1;
        private Krypton.Toolkit.KryptonButton btnClose;
    }
}
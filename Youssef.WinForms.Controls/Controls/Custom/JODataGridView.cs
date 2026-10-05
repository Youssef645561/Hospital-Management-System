using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youssef.WinForms.Controls
{
    public partial class JODataGridView : KryptonDataGridView
    {
        public JODataGridView()
        {
            InitializeComponent();

            // User Interaction
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.AllowUserToResizeColumns = true;
            this.AllowUserToResizeRows = true;
            this.MultiSelect = false;
            this.ReadOnly = true;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            // Auto Sizing
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Headers
            this.ColumnHeadersHeight = 30;
            this.RowHeadersVisible = false;
            this.RowHeadersWidth = 40;


            // Appearance
            this.StateCommon.Background.Color1 = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;


            // Data Cell Style
            this.StateCommon.DataCell.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.StateCommon.DataCell.Content.TextH = PaletteRelativeAlign.Near;


            // Header Style
            this.StateCommon.HeaderColumn.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.StateCommon.HeaderColumn.Content.TextH = PaletteRelativeAlign.Center;
        }
    }
}

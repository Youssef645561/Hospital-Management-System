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
    public partial class JOTextBox : KryptonTextBox
    {
        public JOTextBox()
        {
            InitializeComponent();

            this.CornerRoundingRadius = this.StateCommon.Border.Rounding = 20F;
            this.PaletteMode = PaletteMode.Office2007Blue;

            this.KeyPress += tb_KeyPress;
        }

        [Category("Behavior")]
        [DefaultValue(true)]
        public bool AllowDigits { get; set; } = true;

        [Category("Behavior")]
        [DefaultValue(true)]
        public bool AllowSpecialCharacters { get; set; } = true;

        [Category("Behavior")]
        [DefaultValue(true)]
        public bool AllowLetters { get; set; } = true;

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = !AllowDigits;
            else if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = !AllowSpecialCharacters;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = !AllowLetters;
        }
    }
}

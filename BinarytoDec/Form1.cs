using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BinarytoDec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BinaryNumberBox_TextChanged(object sender, EventArgs e)
        {
            string binaryNumberString = BinaryNumberBox.Text.Trim();

            DecimalReturnLabel.Text = string.IsNullOrEmpty(binaryNumberString) ? "0" : Convert.ToInt32(binaryNumberString, 2).ToString();
        }

        private void BinaryNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validKeys = new[] { Keys.Back, Keys.Delete, Keys.D0, Keys.D1 };

            e.Handled = !validKeys.Contains((Keys)e.KeyChar);
        }
    }
}

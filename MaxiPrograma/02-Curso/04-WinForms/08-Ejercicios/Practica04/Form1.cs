using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            if (txtbName.Text == "")
                txtbName.BackColor = Color.Red;
            else
                txtbName.BackColor = System.Drawing.SystemColors.Control;
        
        }

        private void btnName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 48 || e.KeyChar >59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtb2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtb2.Text.Length + " caracteres.");
        }
    }
}

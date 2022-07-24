using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_MouseMove(object sender, MouseEventArgs e)
        {
            lblName.BackColor = Color.Cyan;
            lblName.Cursor = Cursors.Hand;
        }

        private void lblName_MouseLeave(object sender, EventArgs e)
        {
            lblName.BackColor = System.Drawing.SystemColors.Window;
            lblName.Cursor = Cursors.Arrow;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha01;
            fecha01 = dtp1.Value;
            MessageBox.Show("La fecha seleccionada es: " +fecha01.ToString("dd/MM/yyy"));
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            DateTime fecha02 = mc1.SelectionStart;
            MessageBox.Show("La fecha seleccionada es: " + fecha02.ToString("dd/MM/yyy"));
        }
    }
}

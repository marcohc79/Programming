using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Al momento de abrir la venta
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show( "Te doy la bienvenida...");
        }

        // Esto es un evento.
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola Mundo!!");
            String texto = txtName.Text;
            lblTxt.Text = "Hola "+ texto;
        }
    }
}

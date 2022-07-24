using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstAplication
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Your welcome to C#!");
        }

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Good by good by...");
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparo el evento Click", "Atención");
            //this.BackColor = Color.Blue;

            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Preciono el boton Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo02_controlesVarios_OperadoresTernarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            lwElementos.Items.Add(elemento);
        }

        private void lwElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Azul");
            cboColorFavorito.Items.Add("Amarillo");
            cboColorFavorito.Items.Add("Purpura");
            cboColorFavorito.Items.Add("Cielo");
        }

        private void rbtWizard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboColorFavorito_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = dtmFechaNacimiento.Value;
            string colorFavorito = cboColorFavorito.SelectedItem.ToString();

            MessageBox.Show("Nombre: " + nombre + " Fecha de nacimiento: " + fechaNacimiento + " Color Favorito: " +
                            colorFavorito);
        }
    }
}

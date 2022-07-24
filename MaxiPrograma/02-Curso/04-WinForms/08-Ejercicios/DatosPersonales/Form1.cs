using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosPersonales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string edad = numEdad.Text;
            string direccion = txtDireccion.Text;
            
            Color colorError = Color.FromArgb(255,184,108);

            if (apellido != "" && nombre != "" && edad != "" && direccion != "")
            {
                lvResultado.Items.Add("Apellido y Nombre: " + apellido + " " + nombre);
                lvResultado.Items.Add("Edad: " + edad);
                lvResultado.Items.Add("Dirección: " + direccion);
                txtApellido.Clear();
                txtNombre.Clear();
                numEdad.Clear();
                txtDireccion.Clear();
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
                numEdad.BackColor = System.Drawing.SystemColors.Control;
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                if (apellido == "")
                    txtApellido.BackColor = colorError;
                if(nombre == "")
                    txtNombre.BackColor = colorError;
                if (edad == "")
                    numEdad.BackColor = colorError;
                if (direccion == "")
                    txtDireccion.BackColor = colorError;
            }
         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros.Comprobacion(e);
        }

       
    }
}

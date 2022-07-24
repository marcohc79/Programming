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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                    return;
            }
            Form1 ventana = new Form1();
            
            ventana.MdiParent = this;

            ventana.Show();
            // Si quiero pasar a la otra ventana no puedo hasta cerrar esta ventana.
            //ventana.ShowDialog();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(Form1))
                    return;
            }

            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
            // Si quiero pasar a la otra ventana no puedo hasta cerrar esta ventana.
            //ventana.ShowDialog();


        }
    }
}

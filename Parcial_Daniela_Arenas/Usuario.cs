using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Daniela_Arenas
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbRegistro.Text = "datos del cliente \n" + "nombre: " + TxtNombre.Text + "\n" + "Cedula: " + TxtCedula.Text + "\n" + "Pan aliñado: " + TxtAliñado.Text + "\n" + " Pan no Aliñado: " + TxtNoAliñado.Text + "\n" + "Pan especial: " + TxtEspecial.Text + "\n" + "valor total de la venta: " + TxtValor.Text;
        }
    }
}

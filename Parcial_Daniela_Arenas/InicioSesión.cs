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

    public partial class btnInicio : Form
    {
        string Admin = "DanielaArenas";
        string contraseñaAdmin = "daniela12";
        string Usario_1 = "PepitoMendez";
        string contraseñaUsario_1 = "pepito123";
        string Usario_2 = "EmiliaPerez";
        string contraseñaUsario_2 = "Emilia123";
        public btnInicio()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPanaderia_Click(object sender, EventArgs e)
        {

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {

            if (TxtUsuario.Text == Admin && TxtContraseña.Text == contraseñaAdmin)
            {
                TxtUsuario.Clear();
                TxtContraseña.Clear();
                Admin Main = new Admin();
                Main.ShowDialog();
            }
            else
            {
                if (TxtUsuario.Text == Usario_1 && TxtContraseña.Text == contraseñaUsario_1)
                {
                    TxtUsuario.Clear();
                    TxtContraseña.Clear();
                    Usuario Main = new Usuario();
                    Main.ShowDialog();
                }
                else
                {
                    if (TxtUsuario.Text == Usario_2 && TxtContraseña.Text == contraseñaUsario_2)
                    {
                        TxtUsuario.Clear();
                        TxtContraseña.Clear();
                        Usuario Main = new Usuario();
                        Main.ShowDialog();
                    }

                }
            }

        }
    }
}

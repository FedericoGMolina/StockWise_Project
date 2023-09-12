using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StockWise_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalirLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            txtUsuarioLogin.Text = "";
            txtContraseñaLogin.Text = "";
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionó");
        }
    }
}

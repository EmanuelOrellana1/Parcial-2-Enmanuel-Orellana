using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2_Enmanuel_Orellana.Vista
{
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
        }

        private void frmLoguin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEntar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "master" && txtContraseña.Text == "123")
            {
                MessageBox.Show("Bienvenido/a");
                frmRegistro R = new frmRegistro();
                R.Show();
                this.Hide();
            }
        }
    }
}

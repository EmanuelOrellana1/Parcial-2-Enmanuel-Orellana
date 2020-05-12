using Parcial_2_Enmanuel_Orellana.Model;
using Parcial_2_Enmanuel_Orellana.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2_Enmanuel_Orellana
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

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            frmLoguin logn = new frmLoguin();
            logn.Show();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (gobiernoEntities db = new gobiernoEntities())
            {
                {
                    var lista = from usua in db.Usuario
                                where usua.DUI == txtConsultar.Text
                                select new
                                {
                                    nombre = usua.Nombre
                                };
                    if (lista.Count() > 0)
                    {
                        foreach (var iterardatos in lista)
                        {
                            lblNombrepersona.Visible = true;
                            lblConsultar.Visible = true;
                            lblNombrepersona.Text = iterardatos.nombre;
                        }

                    }
                    else
                    {
                        lblNombrepersona.Visible = false;
                        lblbeneficiario.Visible = true;
                        lblbeneficiario.Text = "No es beneficiario";
                    }
                }
            }
        }
    }}

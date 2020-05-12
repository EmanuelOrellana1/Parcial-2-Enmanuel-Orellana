using Parcial_2_Enmanuel_Orellana.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial_2_Enmanuel_Orellana.Model;
using Parcial_2_Enmanuel_Orellana.Vista;

namespace Parcial_2_Enmanuel_Orellana.Vista
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        Usuario usu = new Usuario();


        void cargardatos()
        {
            using (gobiernoEntities db = new gobiernoEntities())
            {
                var usuarios = db.Usuario;
                foreach (var iterardatosUsuarios in usuarios)
                {
                    dtvUsuario.Rows.Add(
                     iterardatosUsuarios.id,iterardatosUsuarios.Nombre, iterardatosUsuarios.DUI);
                }

            }

        }
        void limpiardatos()
        {
            txtNombre.Text = "";
            txtDUI.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (gobiernoEntities db = new gobiernoEntities())
            {


                usu.Nombre = txtNombre.Text;
                usu.DUI = txtDUI.Text;

                db.Usuario.Add(usu);
                db.SaveChanges();

            }
            dtvUsuario.Rows.Clear();
            cargardatos();
            limpiardatos();
        }
    

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (gobiernoEntities db = new gobiernoEntities())
            {
                String Id = dtvUsuario.CurrentRow.Cells[0].Value.ToString();

                usu = db.Usuario.Find(int.Parse(Id));
                db.Usuario.Remove(usu);
                db.SaveChanges();
            }
            dtvUsuario.Rows.Clear();
            cargardatos();
            limpiardatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (gobiernoEntities db = new gobiernoEntities())
            {
                String Id = dtvUsuario.CurrentRow.Cells[0].Value.ToString();
                int Idc = int.Parse(Id);
                usu = db.Usuario.Where(Verificarid => Verificarid.id == Idc).First();
                usu.Nombre = txtNombre.Text;
                usu.DUI= txtDUI.Text;
                db.Entry(usu).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            dtvUsuario.Rows.Clear();
            cargardatos();
            limpiardatos();
            
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void dtvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = dtvUsuario.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtvUsuario.CurrentRow.Cells[1].Value.ToString();
            String DUI = dtvUsuario.CurrentRow.Cells[2].Value.ToString();
            txtID.Text = ID;
            txtNombre.Text = Nombre;
            txtDUI.Text = DUI;
        }

        private void dtvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dtvUsuario.CurrentRow.Cells[0].Value.ToString();
            string nombre =dtvUsuario.CurrentRow.Cells[1].Value.ToString();
            string DUI = dtvUsuario.CurrentRow.Cells[2].Value.ToString();

            txtID.Text = id;
            txtNombre.Text = nombre;
            txtDUI.Text = DUI;
        }
    }

   
}

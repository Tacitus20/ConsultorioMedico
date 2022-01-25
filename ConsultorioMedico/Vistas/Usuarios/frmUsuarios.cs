using ConsultorioMedico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico.Vistas.NUsuarios
{
    public partial class frmUsuarios : Form
    {
        private int Indice;
        private int activo;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            using (var db = new ConsultorioMedicoEntities())
            {
                var roles = db.rol.SqlQuery("Select Id, Nombre from rol ").ToList();
                cmbRol.DataSource = roles;
                cmbRol.DisplayMember = "Nombre";
                cmbRol.ValueMember = "Id";
                var Usuar = db.Usuarios.SqlQuery("select * from usuarios").ToList();
                dgvUsuarios.DataSource = Usuar;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db = new ConsultorioMedicoEntities())
            {
                Usuarios oTable = new Usuarios();
                oTable.Nombre = txtNombre.Text;
                oTable.Password = txtContraseña.Text;
                oTable.Usuario = txtUsuario.Text;
                oTable.Fecha = DateTime.Now;
                oTable.email = txtEmail.Text;
                oTable.idRol = Indice;
                oTable.State = activo;

                db.Usuarios.Add(oTable);
                db.SaveChanges();

                MessageBox.Show("Usuario se guardo correctamente");
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
              Indice = cmbRol.SelectedIndex;
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivo.Checked == true)
                activo = 1;
            else
                activo = 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}

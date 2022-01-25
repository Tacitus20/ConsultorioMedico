using ConsultorioMedico.Datos;
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

namespace ConsultorioMedico.Vistas
{
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            InsertarFilas();
        }

        private void InsertarFilas()
        {
            using (ConsultorioMedicoEntities db = new ConsultorioMedicoEntities())
            {

                var oPaciente = db.Database.SqlQuery<Paciente>("SELECT * from Paciente").ToList();
                dgvPacientes.DataSource = oPaciente;
            }
        }
        private void limpiar()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            txtnombre.Focus();
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                txtid.Text = dgvPacientes.CurrentRow.Cells["id"].Value.ToString();
                txtnombre.Text = dgvPacientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtEdad.Text = dgvPacientes.CurrentRow.Cells["Edad"].Value.ToString();
                txtDomicilio.Text = dgvPacientes.CurrentRow.Cells["Domicilio"].Value.ToString();
                txtColonia.Text = dgvPacientes.CurrentRow.Cells["Colonia"].Value.ToString();
                txtCodPos.Text = dgvPacientes.CurrentRow.Cells["CodPost"].Value.ToString();
                txtTelefono.Text = dgvPacientes.CurrentRow.Cells["telefono"].Value.ToString();
            }
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPacientes.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar =
                    (DataGridViewCheckBoxCell)dgvPacientes.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using(ConsultorioMedicoEntities db = new ConsultorioMedicoEntities())
            {
                Paciente oPaciente = new Paciente();
                oPaciente.Nombre = txtnombre.Text;
                oPaciente.Edad = Convert.ToInt32( txtEdad.Text);
                oPaciente.Domicilio = txtDomicilio.Text;
                oPaciente.Colonia = txtColonia.Text;
                oPaciente.CodPost = txtCodPos.Text;
                oPaciente.Telefono = txtTelefono.Text;

                db.Paciente.Add(oPaciente);
                db.SaveChanges();

                MessageBox.Show("Datos insertados correctamente");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar los Pacientes seleccionados?", "Eliminación de Paciente",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvPacientes.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            sPaciente opaciente = new sPaciente();
                            opaciente.id = Convert.ToInt32(row.Cells["id"].Value);
                            if (DUsuario.EliminarPaciente(opaciente) != 1)
                            {
                                MessageBox.Show("El Paciente no pudo ser eliminado", "Eliminación de Paciente",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (ConsultorioMedicoEntities db = new ConsultorioMedicoEntities())
            {
                Int32 id = Convert.ToInt32(txtid.Text);
                var oTable = new Paciente();
                oTable.Nombre = txtnombre.Text.ToUpper();
                oTable.Edad = Convert.ToInt32( txtEdad.Text);
                oTable.Domicilio = txtDomicilio.Text.ToUpper();
                oTable.Colonia = txtColonia.Text;
                oTable.CodPost =   txtCodPos.Text;
                oTable.Telefono = txtTelefono.Text;

                db.Entry(oTable).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Se Actualizo correctamente el Paciente...");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

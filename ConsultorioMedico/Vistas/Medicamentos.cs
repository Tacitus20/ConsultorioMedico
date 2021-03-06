using ConsultorioMedico.Datos;
using ConsultorioMedico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico.Vistas
{
    
    public partial class Medicamentos : Form
    {
        DataTable dt = new DataTable("medicamento");
        public Medicamentos()
        {
            InitializeComponent();
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {

            InsertarFilas();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                using (ConsultorioMedicoEntities db = new ConsultorioMedicoEntities())
                {
                    dgvMedicamentos.DataSource = db.Medicamento.Where(p => p.Nombre.Contains(txtBuscar.Text)).ToList();
                }

        }

        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMedicamentos.CurrentRow != null)
            {
                txtid.Text = dgvMedicamentos.CurrentRow.Cells["id"].Value.ToString();
                if (dgvMedicamentos.CurrentRow.Cells["Nombre"].Value == null)
                {
                    txtnombre.Text = "";
                }
                else
                {
                    txtnombre.Text = dgvMedicamentos.CurrentRow.Cells["Nombre"].Value.ToString();
                }
                txtnombre.Text = dgvMedicamentos.CurrentRow.Cells["Nombre"].Value.ToString();
                if (dgvMedicamentos.CurrentRow.Cells["Compuesto"].Value == null)
                {
                    Txtcompuesto.Text = "";
                }
                else
                {
                    Txtcompuesto.Text = dgvMedicamentos.CurrentRow.Cells["Compuesto"].Value.ToString();
                }
                if (dgvMedicamentos.CurrentRow.Cells["Presentacion"].Value == null)
                {
                    txtPresentacion.Text = "";
                }
                else
                {
                    txtPresentacion.Text = dgvMedicamentos.CurrentRow.Cells["Presentacion"].Value.ToString();
                }
                if (dgvMedicamentos.CurrentRow.Cells["Gramaje"].Value == null)
                {
                    txtgramaje.Text = "";
                }
                else
                {
                    txtgramaje.Text = dgvMedicamentos.CurrentRow.Cells["Gramaje"].Value.ToString();
                }


                txtdescripcion.Text = dgvMedicamentos.CurrentRow.Cells["Descripcion"].Value.ToString();
                if (dgvMedicamentos.CurrentRow.Cells["Laboratorio"].Value == null)
                {
                    txtLaboratorio.Text = "";
                }
                else
                {
                    txtLaboratorio.Text = dgvMedicamentos.CurrentRow.Cells["Laboratorio"].Value.ToString();
                }

                txtPrecio.Text = dgvMedicamentos.CurrentRow.Cells["Precio"].Value.ToString();
                DTPFechaCompra.Value = Convert.ToDateTime(dgvMedicamentos.CurrentRow.Cells["FechaCompra"].Value.ToString());

                txtCosto.Text = dgvMedicamentos.CurrentRow.Cells["Costo"].Value.ToString();
                if (dgvMedicamentos.CurrentRow.Cells["Lote"].Value == null)
                {
                    txtLote.Text = "";
                }
                else
                {
                    txtLote.Text = dgvMedicamentos.CurrentRow.Cells["Lote"].Value.ToString();
                }
                if (dgvMedicamentos.CurrentRow.Cells["Caducidad"].Value == null)
                {
                    txtcaducidad.Text = "";
                }
                else
                {
                    txtcaducidad.Text = dgvMedicamentos.CurrentRow.Cells["Caducidad"].Value.ToString();
                }
                if (dgvMedicamentos.CurrentRow.Cells["Stock"].Value == null)
                {
                    txtStock.Text = "";
                }
                else
                {
                    txtStock.Text = dgvMedicamentos.CurrentRow.Cells["Stock"].Value.ToString();
                }
                if (dgvMedicamentos.CurrentRow.Cells["CodigoBarra"].Value == null)
                {
                    txtCodBarra.Text = "";
                }
                else
                {
                    txtCodBarra.Text = dgvMedicamentos.CurrentRow.Cells["CodigoBarra"].Value.ToString();
                }

            }
        }

        private void dgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvMedicamentos.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar =
                    (DataGridViewCheckBoxCell)dgvMedicamentos.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (ConsultorioMedicoEntities db = new ConsultorioMedicoEntities())
            {
                Medicamento med = new Medicamento();
                med.Nombre = txtnombre.Text.ToUpper();
                med.Compuesto = Txtcompuesto.Text.ToUpper();
                med.Presentacion = txtPresentacion.Text.ToUpper();
                med.Gramaje = txtgramaje.Text;
                med.Descripcion = txtdescripcion.Text.ToUpper();
                med.Laboratorio = txtLaboratorio.Text.ToUpper();
                med.Precio = Convert.ToDouble(txtPrecio.Text);
                med.FechaCompra = DTPFechaCompra.Value;
                med.Costo = Convert.ToDouble(txtCosto.Text);
                med.Lote = txtLote.Text;
                med.Caducidad = txtcaducidad.Text;
                med.Stock = Convert.ToInt32(txtStock.Text);
                med.CodigoBarra = Convert.ToDecimal(txtCodBarra.Text);
                db.Medicamento.Add(med);

                db.SaveChanges();

                MessageBox.Show("Datos insertados correctamente");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (ConsultorioMedicoEntities db = new ConsultorioMedicoEntities())
            {
                Int32 id = Convert.ToInt32(txtid.Text);
                var oTable = db.Medicamento.FirstOrDefault(b => b.Id == id);
                //var oTable = new Medicamento();
                oTable.Nombre = txtnombre.Text.ToUpper();
                oTable.Compuesto = Txtcompuesto.Text.ToUpper();
                oTable.Presentacion = txtPresentacion.Text.ToUpper();
                oTable.Gramaje = txtgramaje.Text;
                oTable.Descripcion = txtdescripcion.Text.ToUpper();
                oTable.Laboratorio = txtLaboratorio.Text.ToUpper();
                oTable.Precio = Convert.ToDouble(txtPrecio.Text);
                oTable.FechaCompra = DTPFechaCompra.Value;
                oTable.Costo = Convert.ToDouble(txtCosto.Text);
                oTable.Lote = txtLote.Text;
                if (txtStock.Text == "")
                    oTable.Stock = 0;
                else
                    oTable.Stock = Convert.ToInt32(txtStock.Text);
                if (txtCodBarra.Text == "")
                    oTable.CodigoBarra = 0;
                else
                    oTable.CodigoBarra = Convert.ToInt32(txtCodBarra.Text);

                db.Entry(oTable).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Se Actualizo correctamente el Medicamento...");
            }
            InsertarFilas();
        }

        private void InsertarFilas()
        {
            using (ConsultorioMedicoEntities db = new ConsultorioMedicoEntities())
            {
                dgvMedicamentos.DataSource = db.Medicamento.ToList();
                AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
                foreach (Medicamento m in dgvMedicamentos.DataSource as List<Medicamento>)
                    ac.Add(m.Nombre);
                txtBuscar.AutoCompleteCustomSource = ac;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar los Medicamentos seleccionados?", "Eliminación de Medicamento",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvMedicamentos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            sMedicamento medicam = new sMedicamento();
                            medicam.Id = Convert.ToInt32(row.Cells["id"].Value);
                            if (DUsuario.EliminarMedicamento(medicam) != 1)
                            {
                                MessageBox.Show("El Medicamento no pudo ser eliminado", "Eliminación de Medicamento",
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

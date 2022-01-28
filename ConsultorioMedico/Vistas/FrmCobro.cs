using ConsultorioMedico.Utils;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ConsultorioMedico.Entidades;
using ConsultorioMedico.Datos;
using iTextSharp.text;
using System.IO;

namespace ConsultorioMedico.Vistas
{
    public partial class FrmCobro : Form
    {

        private static DataTable dt = new DataTable();
        private static DataTable dtf = new DataTable();
        AutoCompleteStringCollection fuente = new AutoCompleteStringCollection();
        AutoCompleteStringCollection fuente1 = new AutoCompleteStringCollection();
        AutoCompleteStringCollection fuente2 = new AutoCompleteStringCollection();
        private static ConverNumLetra oLetra = new ConverNumLetra();
        public Int32 idMedicamento;
        public static Int32 idconcepto = 0;
        public static string IdCobro;
        public Int32 IdCobranza;
        public Int32 idPaciente;
        BaseFont f_cn = BaseFont.CreateFont("c:\\windows\\fonts\\calibri.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

        public FrmCobro()
        {
            InitializeComponent();
        }



        private void Fuente()
        {
            DataSet ds = DUsuario.GetAllnombres();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                fuente.Add(Convert.ToString(row["Nombre"]));
            }

        }

        private void FrmCobro_Load(object sender, EventArgs e)
        {
            CbDoctor.DisplayMember = "Nombre";
            CbDoctor.ValueMember = "id";
            CbDoctor.DataSource = DUsuario.GetAllDoctores().Tables[0];
            //using(var db = new ConsultorioMedicoEntities())
            //{
            //    var nPacientes = db.Paciente.ToList();
            //  AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            //    foreach (Paciente p in nPacientes as List<Paciente>)
            //        ac.Add(p.Nombre);
            //    txtnombre.AutoCompleteCustomSource = ac;
            //}
            

            //Fuente();
            //FuenteConcepto();
            Folios();
        }

        private void Folios()
        {
          
            int xfolio = DUsuario.TraerFolioVenta(NUsuario.Id);
            lblfolio.Text = Convert.ToString(xfolio + 1);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            idconcepto += 1;
            Int32 Id = idconcepto;
     
            string Nombre = txtdescrip.Text.Trim();
            string Importe = txtimporte.Text;
            string Cantidad = txtcantidad.Text;
            string Subtotal = txtsubtotal.Text;

            dgvConceptos.Rows.Add(new object[] { Id, idMedicamento, Nombre,  Importe, Cantidad, Subtotal, "Eliminar" });
            txtCodigoBarra.Focus();
            txtdescrip.Text = "";
            txtimporte.Text = "";
            txtcantidad.Text = "";
            txtsubtotal.Text = "";
            Calculartotal();
        }
        private void Calculartotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow dr in dgvConceptos.Rows)
            {
                decimal importe = decimal.Parse(dr.Cells[5].Value.ToString());
                total += importe;
            }
            lblTotal.Text = total.ToString();

        }
        private void FuenteConcepto()
        {
            DataSet ds = DUsuario.getAllMedicamentos();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                fuente1.Add(Convert.ToString(row["Nombre"]));
            }
        }

        private void txtdescrip_TextChanged(object sender, EventArgs e)
        {
            txtdescrip.AutoCompleteCustomSource = fuente1;
            txtdescrip.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtdescrip.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void txtcantidad_Leave(object sender, EventArgs e)
        {
            if (txtimporte.Text == "" || txtcantidad.Text == "") { }
            else
            {
                decimal sutot = Convert.ToDecimal(txtimporte.Text) * Convert.ToDecimal(txtcantidad.Text);
                txtsubtotal.Text = sutot.ToString();
            }
        }
        private void txtdescrip_Leave(object sender, EventArgs e)
        {
            txtdescrip.Text = txtdescrip.Text.ToUpper();
            if (txtdescrip.Text == "") { }
            else
            {
                using (var db = new ConsultorioMedicoEntities())
                {
                    var medicamentos = db.Database.SqlQuery<Medicamento>("Select * from Medicamentos where nombre like '%" + txtdescrip.Text.Trim() + "%'").ToList();
                    txtimporte.Text = medicamentos[0].Precio.ToString();
                    idMedicamento = medicamentos[0].Id;
                }
            }
        }

      

        private void btngrddatos_Click(object sender, EventArgs e)
        {

            using (ConsultorioMedicoEntities db = new ConsultorioMedicoEntities())
            {
                Cobranza oCobro = new Cobranza();
                oCobro.Fecha = DateTime.Now;
                oCobro.Nombre = txtnombre.Text.ToString().ToUpper();
                oCobro.Domicilio = txtdomicilio.Text.ToString().ToUpper();
                oCobro.Concepto = txtconcepto.Text.ToString().ToUpper();
                oCobro.Total = decimal.Parse(lblTotal.Text);
                oCobro.TotalenLetra = oLetra.enletras(Convert.ToString(oCobro.Total));
                oCobro.StatusCancel = 0;
                oCobro.id_usuario = NUsuario.Id;
                oCobro.id_paciente = idPaciente;
                oCobro.id_doctor = Convert.ToInt32(CbDoctor.SelectedValue);

                db.Cobranza.Add(oCobro);
                db.SaveChanges();
                IdCobranza = oCobro.id;

                foreach (DataGridViewRow dr in dgvConceptos.Rows)
                {
                    DetalleCobro odetcobro = new DetalleCobro();

                    odetcobro.id_cobranza = oCobro.id;           
                    odetcobro.Importe = double.Parse(dr.Cells[3].Value.ToString());
                    odetcobro.Cantidad = int.Parse(dr.Cells[4].Value.ToString());
                    odetcobro.Subtotal = double.Parse(dr.Cells[5].Value.ToString()); 

                    db.DetalleCobro.Add(odetcobro);
                    db.SaveChanges();
                }

                MessageBox.Show("Se grabo correctamente el cobro");
                //btnImprimir.Enabled = true;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            using (var db = new ConsultorioMedicoEntities())
            {
                DataSet ds = DUsuario.GetCobros(IdCobranza);
                //DataSet ds = DUsuario.GetCobros(1);
                using (System.IO.FileStream fs = new FileStream(@"C:\ConsultorioMedico\Recibo" + lblfolio.Text + ".pdf", FileMode.Create))
                {
                    dt = ds.Tables[0];
                    foreach (DataRow row in dt.Rows)
                    {
                        Document document = new Document(PageSize.LETTER, 25, 25, 30, 30);
                        PdfWriter writer = PdfWriter.GetInstance(document, fs);

                        // Open the document to enable you to write to the document
                        document.Open();

                        PdfContentByte cb = writer.DirectContent;
                        cb.SetFontAndSize(f_cn, 9);
                        // First we must activate writing
                        cb.BeginText();

                        
                        //Hacer el codigo para el folio
                        cb.SetTextMatrix(163, 781);
                        cb.ShowText(Convert.ToString(row["Folio"]));

                        //Nombre del Doctor
                        cb.SetTextMatrix(35, 757);
                        cb.ShowText(Convert.ToString(row["Doctor"]));
                        //Nombre
                        cb.SetTextMatrix(35, 747);
                        cb.ShowText(Convert.ToString(row["Nombre"]));

                        //Domicilio
                        cb.SetTextMatrix(35, 733);
                        cb.ShowText(Convert.ToString(row["Domicilio"]));


                        cb.SetTextMatrix(35, 700);
                        cb.ShowText(oLetra.enletras(Convert.ToString(row["Total"])));

                        cb.SetTextMatrix(35, 679);
                        cb.ShowText(Convert.ToString(row["Concepto"]));
                        document.Add(Chunk.NEWLINE);
                        // prcedimiento para los detalles de cobro
                        DataSet ds1 = DUsuario.DetalleCobros(IdCobranza);
                        //DataSet ds1 = DUsuario.DetalleCobros(1);
                        dtf = ds1.Tables[0];
                        Int32 n = 0;
                        foreach (DataRow row1 in dtf.Rows)
                        {
                            cb.SetTextMatrix(35, 600 + n);
                            cb.ShowText(Convert.ToString(row1["Cantidad"]));
                            cb.SetTextMatrix(55, 600 + n);
                            cb.ShowText(Convert.ToString(row1["Nombre"]));
                            cb.SetTextMatrix(233, 600 + n);
                            cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, string.Format("{0:###,#00.00}", Convert.ToString(row1["SubTotal"])), 233, 600 + n, 0);
                            //cb.ShowText(Convert.ToString(row1["SubTotal"]));
                            //document.Add(new Paragraph("\n\n"));
                            //document.Add(Chunk.NEWLINE);
                            n = 10;
                        }
                        cb.SetTextMatrix(235, 541);
                        //cb.ShowText("$ " + string.Format("{0:###,#00.00}", Total));
                        cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, string.Format("{0:###,#00.00}", Convert.ToString(row["Total"])), 235, 541, 0);

                        cb.SetTextMatrix(110, 481);
                        cb.ShowText(string.Format("{0:dddd, dd MMMM yyyy} ", (Convert.ToString(row["Fecha"]))));

                        //cb.SetTextMatrix(240, 433);
                        //cb.ShowText("pesos");

                        cb.EndText();
                        string codigoQr = lblfolio.Text + lblTotal.Text;
                        BarcodeQRCode barcodeQR = new BarcodeQRCode(codigoQr, 300, 300, null);
                        iTextSharp.text.Image codeQRimage = barcodeQR.GetImage();
                        codeQRimage.ScaleAbsolute(200, 200);
                        document.Add(codeQRimage);
                        // Close the document
                        document.Close();
                        writer.Close();
                        fs.Close();

                        //esto es para abrir el documento y verlo inmediatamente después de su creación
                        System.Diagnostics.Process.Start("AcroRd32.exe", @"C:\ConsultorioMedico\Recibo" + lblfolio.Text + ".pdf");
                    }
                }
                Limpiar();
            }
        }

        private void dgvConceptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvConceptos.Columns["Op"].Index)
                return;

            dgvConceptos.Rows.RemoveAt(e.RowIndex);

            Calculartotal();
        }
        private void Limpiar()
        {
            txtnombre.Text = "";
            txtdomicilio.Text = "";
            txtconcepto.Text = "";
            txtdescrip.Text = "";
            txtimporte.Text = "";
            txtcantidad.Text = "";
            txtsubtotal.Text = "";
            lblTotal.Text = "";
            txtCodigoBarra.Text = "";
            dgvConceptos.Rows.Clear();
            txtnombre.Focus();
        }

        private void LimpiarNuevo()
        {
           
            txtconcepto.Text = "";
            txtdescrip.Text = "";
            txtimporte.Text = "";
            txtcantidad.Text = "";
            txtsubtotal.Text = "";
            txtCodigoBarra.Text = "";
            txtCodigoBarra.Focus();
        }
        private void txtdomicilio_Leave(object sender, EventArgs e)
        {
            txtdomicilio.Text = txtdomicilio.Text.ToUpper();
        }

        private void txtconcepto_Leave_1(object sender, EventArgs e)
        {
            txtconcepto.Text = txtconcepto.Text.ToUpper();
            txtCodigoBarra.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                using (var db = new ConsultorioMedicoEntities())
                {
                    var xNombre = db.Paciente.Where(p => p.Nombre.Contains(txtnombre.Text)).ToList();
                    txtdomicilio.Text = xNombre[0].Domicilio.ToString();
                    idPaciente = xNombre[0].id;

                }
        }

        private void txtCodigoBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                using (var db = new ConsultorioMedicoEntities())
                {
                    var codigo = db.Medicamento.Where(m => m.CodigoBarra.ToString().Contains(txtCodigoBarra.Text)).ToList();
          
                    txtdescrip.Text = codigo[0].Nombre.ToString();
                    txtimporte.Text = codigo[0].Precio.ToString();
                    idMedicamento = codigo[0].Id;
                    txtcantidad.Text = "1";
                    txtsubtotal.Text = txtimporte.Text;
                    btnagregar_Click(null, null);
                    LimpiarNuevo();
                }
            }
        }
    }
}

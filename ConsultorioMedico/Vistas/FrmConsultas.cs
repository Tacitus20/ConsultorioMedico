using ConsultorioMedico.Datos;
using ConsultorioMedico.Entidades;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico.Vistas
{
    public partial class FrmConsultas : Form
    {
        private static DataTable dt = new DataTable();
        private static DataTable dtf = new DataTable();
        public Int32 Idpaciente;
        AutoCompleteStringCollection fuente = new AutoCompleteStringCollection();
        BaseFont f_cn = BaseFont.CreateFont("c:\\windows\\fonts\\calibri.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        string Imagen = @"C:\Proyecto2020\ConsultorioMedico\ConsultorioMedico\Imagenes\logoCMR.png";

        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            CbDoctor.DisplayMember = "Nombre";
            CbDoctor.ValueMember = "id";
            CbDoctor.DataSource = DUsuario.GetAllDoctores().Tables[0];
            Fuente();
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

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            txtnombre.AutoCompleteCustomSource = fuente;
            txtnombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtnombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btngrddatos_Click(object sender, EventArgs e)
        {
            using (var db = new ConsultorioMedicoEntities())
            {
                Consulta oConsulta = new Consulta();
                oConsulta.id_doctor = Convert.ToInt32(CbDoctor.SelectedValue);
                oConsulta.id_paciente = Idpaciente;
                oConsulta.Edad = Convert.ToInt32(txtEdad.Text);
                oConsulta.Peso = Convert.ToInt32(txtPeso.Text);
                oConsulta.Talla = Convert.ToDouble(txtTalla.Text);
                oConsulta.TenArt = txtPresion.Text;
                oConsulta.Pulso = Convert.ToInt32(txtPulso.Text);
                oConsulta.FreCardiaca = Convert.ToInt32(txtFreCard.Text);
                oConsulta.FrecResp = Convert.ToInt32(txtFreResp.Text);
                oConsulta.Temperatura = Convert.ToInt32(txtTemp.Text);
                oConsulta.Alergias = txtAlergias.Text.ToUpper();
                oConsulta.PbDx = txtPbDx.Text;
                oConsulta.Medicamentos = txtMedicamentos.Text;
                oConsulta.Cita = dateTimePicker1.Text;

                db.Consulta.Add(oConsulta);
                db.SaveChanges();

                MessageBox.Show("Se grabo correctamente la Consulta");
            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "") { }
            else
            {
                using (var db = new ConsultorioMedicoEntities())
                {
                    var opaciente = db.Database.SqlQuery<Paciente>("Select * from paciente where nombre = '" + txtnombre.Text.Trim() + "'").ToList();
                    if (opaciente.Count != 0)
                    {
                        txtEdad.Text = opaciente[0].Edad.ToString();
                        Idpaciente = opaciente[0].id;
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            Font font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font font2 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            int width = 200;
            int y = 20;
            Image img = Image.FromFile(Imagen);
            e.Graphics.DrawImage(img, new Rectangle(0, 0, 120, 120));
            e.Graphics.DrawString("CENTRO MÉDICO ROMÁN", font1, Brushes.SaddleBrown, new RectangleF(100, y  , width +=400,20));
            e.Graphics.DrawString("Hora: " + DateTime.Now.Hour.ToString() +" Fecha Folio:", font2, Brushes.Gray, new RectangleF(400, y , width, 20));
        
            e.Graphics.DrawString("Villa de las Flores, Rayón No.      Nombre del Paciente:", font2, Brushes.Gray, new RectangleF(100, y += 20, width, 20));
 
            e.Graphics.DrawString("242 Barrio 2, Col. Rubén", font2, Brushes.Gray, new RectangleF(100, y +=12, width, 20));
            e.Graphics.DrawString("Jaramillo, Temixco. Morelos", font2, Brushes.Gray, new RectangleF(100, y += 12, width, 20));
        }
    }
}

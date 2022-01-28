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
using System.Globalization;

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
        string Imagen1 = @"C:\Proyecto2020\ConsultorioMedico\ConsultorioMedico\Imagenes\UAGro1.png";

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
        private void Folios()
        {

            int xfolio = DUsuario.TraerFolioconsulta( );
            lblfolio.Text = Convert.ToString(xfolio + 1);
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

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var db = new ConsultorioMedicoEntities())
            {
                var xNombre = db.Tomasignos.Where(p => p.nombre.Contains(txtnombre.Text)).ToList();
                txtnombre.Text= xNombre[0].nombre.ToString();
                txtEdad.Text = xNombre[0].edad.ToString();
                txtTalla.Text = xNombre[0].talla.ToString();
                txtPresion.Text= xNombre[0].tensionArterial.ToString();
                txtPulso.Text= xNombre[0].pulso.ToString();
                txtFreCard.Text = xNombre[0].fCardiaca.ToString();
                txtFreResp.Text = xNombre[0].frespiratoria.ToString();
                txtTemp.Text = xNombre[0].temperatura.ToString();
                txtAlergias.Text = xNombre[0].alergias.ToString();
                txtPbDx.Text = xNombre[0].pbdx.ToString();

            }
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

            DateTime fechaActual = DateTime.Now;
            fechaActual = fechaActual.AddDays(3);
            string dia1 = fechaActual.ToString("dddd");

            DateTime fechahoy = dateTimePicker1.Value;
            string dia2 = fechahoy.ToString("dddd");

            Font font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            Font font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font font2 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
            Font font3 = new Font("Arial", 6, FontStyle.Regular, GraphicsUnit.Point);
            int width = 200;
            int y = 20;
            Image img = Image.FromFile(Imagen);
            Image img1 = Image.FromFile(Imagen1);
            e.Graphics.DrawImage(img, new Rectangle(0, 0, 100, 100));
            e.Graphics.DrawString("CENTRO MÉDICO ROMÁN", font1, Brushes.SaddleBrown, new RectangleF(100, y, width += 400, 20));
            e.Graphics.DrawString("Hora: " + dtFechaCon.Value.ToShortTimeString(), font2, Brushes.Gray, new RectangleF(300, y, width + 200, 20));
            e.Graphics.DrawString("Fecha: " + dtFechaCon.Value.ToShortDateString(), font2, Brushes.Gray, new RectangleF(395, y, width, 20));
            e.Graphics.DrawString("Folio: " + 460, font2, Brushes.Gray, new RectangleF(565, y, width, 20));

            e.Graphics.DrawString("Villa de las Flores, Rayón No.                 Nombre del Paciente: " + txtnombre.Text.ToUpper(), font2, Brushes.Gray, new RectangleF(100, y += 20, width + 200, 20));
            e.Graphics.DrawString("242 Barrio 2, Col. Rubén", font2, Brushes.Gray, new RectangleF(100, y += 12, width, 20));
            e.Graphics.DrawString("Jaramillo, Temixco. Morelos", font2, Brushes.Gray, new RectangleF(100, y += 12, width, 20));
            e.Graphics.DrawString("Cel. 777 387 23 82", font, Brushes.SaddleBrown, new RectangleF(100, y += 12, width, 20));
            e.Graphics.DrawString("Tel. 777 326 91 53", font, Brushes.SaddleBrown, new RectangleF(100, y += 14, width, 20));

            
            Pen blackPen = new Pen(Color.SaddleBrown, 1);   
            PointF point1 = new PointF(10.0F, 110.0F);
            PointF point2 = new PointF(500.0F, 110.0F);
            e.Graphics.DrawLine(blackPen, point1, point2);

            e.Graphics.DrawString(txtMedicamentos.Text.ToUpper(), font2, Brushes.Black, new RectangleF(30, y += 20, width+800, 220));

            e.Graphics.DrawString("Peso: " + txtPeso.Text + " Kg", font2, Brushes.Gray, new RectangleF(565, y , width, 20));
            e.Graphics.DrawString("Talla: " + txtTalla.Text + " cm", font2, Brushes.Gray, new RectangleF(565, y += 15, width, 20));
            e.Graphics.DrawString("Tensión arterial: " + txtPresion.Text + " mmHg", font2, Brushes.Gray, new RectangleF(565, y += 15, width, 20));
            e.Graphics.DrawString("Pulso: " + txtPulso.Text + " lxm", font2, Brushes.Gray, new RectangleF(565, y += 15, width, 20));
            e.Graphics.DrawString("Frecuencia cardiaca: " + txtFreCard.Text + " lxm", font2, Brushes.Gray, new RectangleF(565, y += 15, width, 20));
            e.Graphics.DrawString("Frecuencia Respiratoria: " + txtFreResp.Text + " rxm", font2, Brushes.Gray, new RectangleF(565, y += 15, width, 20));
            e.Graphics.DrawString("Temperatura: " + txtTemp.Text + " °", font2, Brushes.Gray, new RectangleF(565, y += 15, width, 20));
            e.Graphics.DrawString("Alergias: " + txtAlergias.Text.ToUpper(), font2, Brushes.Gray, new RectangleF(565, y += 15, width, 20));
            e.Graphics.DrawString("Problable Diag.: " + txtPbDx.Text.ToUpper(), font2, Brushes.Gray, new RectangleF(565, y += 15, width, 20));
            e.Graphics.DrawString("Cita.: " + dia2 , font2, Brushes.Gray, new RectangleF(565, y += 25, width, 20));
            e.Graphics.DrawString("**NO ALTERAR ESTA RECETA MÉDICA SIN AUTORIZACIÓN DE SU MÉDICO TARTANTE " + txtPbDx.Text.ToUpper(), font2, Brushes.SaddleBrown, new RectangleF(10, y += 15, width, 20));

            e.Graphics.DrawImage(img1, new Rectangle(5, y += 15, 100, 100));
            e.Graphics.DrawString("___________________", font2, Brushes.Gray, new RectangleF(110, y +=10, width, 20));
            e.Graphics.DrawString("___________________", font2, Brushes.Gray, new RectangleF(250, y , width, 20));
            e.Graphics.DrawString("___________________", font2, Brushes.Gray, new RectangleF(400, y, width, 20));

            e.Graphics.DrawString("Horario de revisión de ", font3, Brushes.Gray, new RectangleF(565, y, width, 20));
            e.Graphics.DrawString("  9:00hrs a 13:00hrs ", font3, Brushes.Gray, new RectangleF(565, y += 10, width, 20));

            e.Graphics.DrawString("Dr. Jose Luis Román Colín", font3, Brushes.SaddleBrown, new RectangleF(120, y+=5, width, 20));
            e.Graphics.DrawString("Dra. Karina Ramírez Rebollar", font3, Brushes.SaddleBrown, new RectangleF(252, y, width, 20));
            e.Graphics.DrawString("Dr. Jesús Esteves Correa", font3, Brushes.SaddleBrown, new RectangleF(413, y, width, 20));

            e.Graphics.DrawString("Médico Cirujano General", font3, Brushes.SaddleBrown, new RectangleF(120, y += 10, width, 20));
            e.Graphics.DrawString("Médico Cirujano General", font3, Brushes.SaddleBrown, new RectangleF(252, y , width, 20));
            e.Graphics.DrawString("Médico Cirujano General", font3, Brushes.SaddleBrown, new RectangleF(413, y, width, 20));

            e.Graphics.DrawString("Ced. Prof 4519249", font3, Brushes.SaddleBrown, new RectangleF(122, y+=10, width, 20));
            e.Graphics.DrawString("Ced. Prof 5186306", font3, Brushes.SaddleBrown, new RectangleF(255, y , width, 20));
            e.Graphics.DrawString("Ced. Prof 12032626", font3, Brushes.SaddleBrown, new RectangleF(415, y , width, 20));

            e.Graphics.DrawString("Universidad Autónoma de Guerrero", font3, Brushes.SaddleBrown, new RectangleF(100, y+=10, width, 20));
            e.Graphics.DrawString("Universidad Autónoma de Guerrero", font3, Brushes.SaddleBrown, new RectangleF(240, y, width, 20));
            e.Graphics.DrawString("Universidad Autónoma de Guerrero", font3, Brushes.SaddleBrown, new RectangleF(395, y, width, 20));

            e.Graphics.DrawString("Quejas y/o sugerencias  777 188 11 49", font2, Brushes.Gray, new RectangleF(200, y += 15, width, 20));
            e.Graphics.DrawString("Facturación: medicosmorelos@hotmail.com", font2, Brushes.Gray, new RectangleF(170, y += 15, width, 20));
      
        }

        private void Autocompletar()
        {

            using (var db = new ConsultorioMedicoEntities())
            {
                var nPacientes = db.Paciente.ToList();

                foreach (Paciente p in nPacientes as List<Paciente>)
                    ac.Add(p.Nombre);
                txtnombre.AutoCompleteCustomSource = ac;
            }

        }
    }


}

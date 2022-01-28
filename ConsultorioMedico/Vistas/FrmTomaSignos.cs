using ConsultorioMedico.Datos;
using ConsultorioMedico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico.Vistas
{
    public partial class FrmTomaSignos : Form
    {
        string Imagen = @"C:\Proyecto2020\ConsultorioMedico\ConsultorioMedico\Imagenes\logoCMR.png";
        private static DataTable dt = new DataTable();
        AutoCompleteStringCollection ac = new AutoCompleteStringCollection();

        public FrmTomaSignos()
        {
            InitializeComponent();
            Autocompletar();
        }

        private void btngrddatos_Click(object sender, EventArgs e)
        {
            using (var db = new ConsultorioMedicoEntities())
            {
               Tomasignos  oToma = new Tomasignos();
                oToma.nombre = txtnombre.Text;
                oToma.edad = Convert.ToInt32(txtEdad.Text);
                oToma.peso = Convert.ToInt32(txtPeso.Text);
                oToma.talla = Convert.ToInt32(txtTalla.Text);
                oToma.tensionArterial = txtPresion.Text;
                oToma.pulso = Convert.ToInt32(txtPulso.Text);
                oToma.fCardiaca = Convert.ToInt32(txtFreCard.Text);
                oToma.frespiratoria = Convert.ToInt32(txtFreResp.Text);
                oToma.temperatura = Convert.ToInt32(txtTemp.Text);
                oToma.alergias = txtAlergias.Text.ToUpper();
                oToma.pbdx = txtPbDx.Text;
                oToma.fecha = dateTimePicker1.Value;

                db.Tomasignos.Add(oToma);
                db.SaveChanges();

                MessageBox.Show("Se grabo correctamente la la toma de signos");
            }
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
            //DataSet ds = DUsuario.getTomasignos(txtnombre.Text ,dateTimePicker1.Value);
            //dt = ds.Tables[0];
            //foreach (DataRow row in dt.Rows)
            //{                 
            e.Graphics.DrawImage(img, new Rectangle(0, 0, 110, 110));
            e.Graphics.DrawString("CENTRO MÉDICO ROMÁN", font1, Brushes.SaddleBrown, new RectangleF(120, y, width += 400, 20));
            e.Graphics.DrawString("Fecha: " + dateTimePicker1.Value, font2, Brushes.Gray, new RectangleF(120, y+=20, width, 20));
            e.Graphics.DrawString("Nombre del Paciente: " + txtnombre.Text.ToUpper(), font2, Brushes.Gray, new RectangleF(120, y += 20, width, 20));
            e.Graphics.DrawString("Edad: " +txtEdad.Text +" años", font2, Brushes.Gray, new RectangleF(120, y += 20, width, 20));
            e.Graphics.DrawString("Peso: "+ txtPeso.Text +" Kg", font2, Brushes.Gray, new RectangleF(120, y += 15, width, 20));
            e.Graphics.DrawString("Talla: "+ txtTalla.Text + " cm", font2, Brushes.Gray, new RectangleF(120, y += 15, width, 20));
            e.Graphics.DrawString("Tensión arterial: " + txtPresion.Text +" mmHg", font2, Brushes.Gray, new RectangleF(120, y += 15, width, 20));
            e.Graphics.DrawString("Pulso: " + txtPulso.Text + " lxm", font2, Brushes.Gray, new RectangleF(120, y += 15, width, 20));
            e.Graphics.DrawString("Frecuencia cardiaca: " + txtFreCard.Text +" lxm", font2, Brushes.Gray, new RectangleF(120, y += 15, width, 20));
            e.Graphics.DrawString("Frecuencia Respiratoria: " + txtFreResp.Text + " rxm", font2, Brushes.Gray, new RectangleF(120, y += 15, width, 20));
            e.Graphics.DrawString("Temperatura: " + txtTemp.Text + " °", font2, Brushes.Gray, new RectangleF(120, y += 15, width, 20));
            e.Graphics.DrawString("Alergias: " + txtAlergias.Text.ToUpper(), font2, Brushes.Gray, new RectangleF(120, y += 15, width, 20));
            e.Graphics.DrawString("Problable Diag.: " + txtPbDx.Text.ToUpper(), font2, Brushes.Gray, new RectangleF(120, y += 15, width, 20));

            //}

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
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

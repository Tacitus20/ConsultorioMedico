using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
 


namespace ConsultorioMedico.Vistas
{
    public partial class FrmCodigodebarras : Form
    {
        public FrmCodigodebarras()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            panelResultado.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtcodigo.Text, Color.Black, Color.White, 400, 100);
            btngusrdar.Enabled = true;
        }

        private void btngusrdar_Click(object sender, EventArgs e)
        {
            Image imagenfinal = (Image)panelResultado.BackgroundImage.Clone();
            SaveFileDialog cajadeialogo = new SaveFileDialog();
            cajadeialogo.Filter = "Image PNG  (*.png)|*.png";
            cajadeialogo.ShowDialog();
            if(!string.IsNullOrEmpty(cajadeialogo.FileName))
            {
                imagenfinal.Save(cajadeialogo.FileName, ImageFormat.Png);
            }
            imagenfinal.Dispose();
            txtcodigo.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

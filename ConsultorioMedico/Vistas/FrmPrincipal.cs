using ConsultorioMedico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioMedico.Vistas.NUsuarios;

namespace ConsultorioMedico.Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        int LX, LY, SW, SH;
        private void BtnMedica_Click(object sender, EventArgs e)
        {
            //FrmMedicamentos frm = new FrmMedicamentos();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            //AbrirFormInPanel(frm);
            Medicamentos frm = new Medicamentos();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void mostrarlogo()
        {
            AbrirFormInPanel(new FrmLogo());
        }
        private void mostrarlogoAlCerrarForm(object sender, FormClosedEventArgs e)
        {
            mostrarlogo();
        }
        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 157)
            {
                MenuVertical.Width = 250;
            }
            else

                MenuVertical.Width = 157;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblNombres.Text = NUsuario.Nombre;
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FrmPacientes frm = new FrmPacientes();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsultas frm = new FrmConsultas();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnEMPLEADOS_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCodigodebarras frm = new FrmCodigodebarras();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
             
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            iconmaximizar.Visible = true;
            iconrestaurar.Visible = false;
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            FrmCobro frm = new FrmCobro();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }
    }
}

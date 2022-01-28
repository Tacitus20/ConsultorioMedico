
using ConsultorioMedico.Datos;
using ConsultorioMedico.Entidades;
using ConsultorioMedico.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico.Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtuser.Focus();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        public void logear(string usuario, string contrasena)
        {

            //DataSet ds = DLogin.ValidarLogin(usuario, contrasena);
            DataSet ds = DLogin.ValidarLogin(usuario, CryptorEngine.Encrypt(contrasena, true));

            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                NUsuario.Nombre = dt.Rows[0]["Nombre"].ToString();
                NUsuario.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                NUsuario.Contraseña = dt.Rows[0]["Password"].ToString();
                NUsuario.Usuario = dt.Rows[0]["Usuario"].ToString();
             
                
                this.Hide();
                //FrmPrincipal ObjFP = new FrmPrincipal();
                MDIPrincipal ObjFP = new MDIPrincipal();
                ObjFP.Show();
                
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos");
                txtuser.Text = "";
                txtpass.Text = "";
                txtuser.Focus();
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            logear(txtuser.Text, txtpass.Text);          
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
            txtuser.Focus();
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                logear(txtuser.Text, txtpass.Text);
            }
        }
    }
}

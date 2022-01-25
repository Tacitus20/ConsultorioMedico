using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsultorioMedico.Datos;


namespace Negocio
{
   public class nUsuario
    {
        //Encapsular variables
        private dUsuario objDato = new dUsuario();//instancia a la capa datos de usuario
        //Variables
        private String _Usuario;//Este variable tendra el valor de no ha ingresado usuario........tendra el valor del texbox enviado del fomrilario
        private String _Contraseña;
        //todas las demas...
        //METODOS GET Y SET -->para el manejo de variables
        public String Usuario
        {
            set
            {
                if (value == "Usuario") { _Usuario = "no ha ingresado usuario"; }
                else { _Usuario = value; }
            }
            get { return _Usuario; }
        }
        public String Contraseña
        {
            set
            {
                if (value == "Contraseña") _Contraseña = "Ingrese su contraseña";
                else _Contraseña = value;
            }
            get { return _Contraseña; }
        }
        //CONTRUCTOR 
        public nUsuario() { }
        //FUNCIONES O METODOS
        public SqlDataReader IniciarSesion()
        {

            SqlDataReader Loguear;
            Loguear = objDato.iniciarSesion(Usuario, Contraseña);
            return Loguear;
        }

        public SqlDataAdapter getAllnombres()
        {

            SqlDataAdapter traernombre;
            traernombre = objDato.GetAllnombres();
            return traernombre;
        }

        public SqlDataAdapter getAllMedicamentos()
        {

            SqlDataAdapter traernombre;
            traernombre = objDato.GetAllmedicamentos();
            return traernombre;
        } 
    }
}

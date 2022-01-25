using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedico.Entidades
{
    public class NUsuario
    {
        private static int _id;
        private static string _usuario;
        private static string _contraseña;
        private static string _nombreUsuario;
        private static Int32 _folioinicial;
        private static Int32 _foliofinal;
        private static Int32 _idPerfil;
        private static Int32 _idPerfilusuario;
        private static string _sistema;
        private static string _idsesion;
        private static Int32 _idState;
        public static string[] ReglasUsuarios { get; set; }

        public static Int32 Perfil
        {
            get { return _idPerfil; }
            set { _idPerfil = value; }
        }

        public static Int32 Perfilusuario
        {
            get { return _idPerfilusuario; }
            set { _idPerfilusuario = value; }
        }
        public static Int32 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public static Int32 Folioinicial
        {
            get { return _folioinicial; }
            set { _folioinicial = value; }
        }
        public static Int32 FolioFinal
        {
            get { return _foliofinal; }
            set { _foliofinal = value; }
        }

        public static string Nombre
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        public static string Sistema
        {
            get { return _sistema; }
            set { _sistema = value; }
        }

        public static string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public static string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }

        public static string IDSesion
        {
            get { return _idsesion; }
            set { _idsesion = value; }
        }
        public static Int32 IdState
        {
            get { return _idState; }
            set { _idState = value; }
        }

    }
}

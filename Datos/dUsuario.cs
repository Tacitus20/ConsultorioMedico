using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsultorioMedico.Datos
{
   public class dUsuario
    {
        private Conexion conecta = new Conexion();
        private SqlDataReader Leer;
        public SqlDataReader iniciarSesion(string user, string pass)
        {

            SqlCommand comando = new SqlCommand("sp_autenticarUsuario", conecta.AbriConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", user);
            comando.Parameters.AddWithValue("@Password", pass);

            Leer = comando.ExecuteReader();
            return Leer;
        }
        public SqlDataAdapter GetAllnombres()
        {
             Conexion conecta = new Conexion();
             DataSet ds = new DataSet();
             SqlCommand comando = new SqlCommand("sp_pacientes_getall", conecta.AbriConexion());
             comando.CommandType = CommandType.StoredProcedure;

             SqlDataAdapter da = new SqlDataAdapter(comando);
             
             da.Fill(ds);
              
             return da;

        }
        public SqlDataAdapter GetAllmedicamentos()
        {
             Conexion conecta = new Conexion();
             DataSet ds = new DataSet();
             SqlCommand comando = new SqlCommand("sp_medicamentos_getall", conecta.AbriConexion());
             comando.CommandType = CommandType.StoredProcedure;

             SqlDataAdapter da = new SqlDataAdapter(comando);
             
             da.Fill(ds);
              
             return da;

        }
       
        
    }
}

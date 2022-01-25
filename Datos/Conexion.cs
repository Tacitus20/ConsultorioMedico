using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedico.Datos
{
   
    public class Conexion
    {
        private SqlConnection Conexionsql = new SqlConnection("Server=JORGEPC\\SQLEXPRESS;DataBase=ConsultorioMedico;Integrated Security=true");

        public SqlConnection AbriConexion()
        {
            if (Conexionsql.State == ConnectionState.Closed)
                Conexionsql.Open();
            return Conexionsql;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexionsql.State == ConnectionState.Open)
                Conexionsql.Close();
            return Conexionsql;
        }
    }
}

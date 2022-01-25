using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedico.Datos
{
  public  class DLogin
    {
        public static DataSet ValidarLogin(string sUsuario, string sPassword)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DbHelper.MakeParam("@Usuario", SqlDbType.VarChar, 0, sUsuario),
                    DbHelper.MakeParam("@Password", SqlDbType.VarChar, 0, sPassword),

                };
            return DbHelper.ExecuteDataSet("sp_autenticarUsuario", dbParams);

        }
    }
}

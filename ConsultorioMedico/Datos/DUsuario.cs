using ConsultorioMedico.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedico.Datos
{
   public class DUsuario
    {
        public static DataSet GetAllnombres()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return DbHelper.ExecuteDataSet("sp_pacientes_getall", dbParams);

        }

        public static DataSet GetAllDoctores()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return DbHelper.ExecuteDataSet("sp_doctores_getall", dbParams);

        }
        public static DataSet getAllMedicamentos()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return DbHelper.ExecuteDataSet("sp_medicamentos_getall", dbParams);

        }

        public static DataSet GetCobros(Int32 folio)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DbHelper.MakeParam("@idcobro", SqlDbType.Int, 0, folio),
                };
            return DbHelper.ExecuteDataSet("sp_detallecobro", dbParams);
        }

        public static DataSet DetalleCobros(Int32 folio)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DbHelper.MakeParam("@idcobro", SqlDbType.Int, 0, folio),
                };
            return DbHelper.ExecuteDataSet("sp_detalledecobro", dbParams);
        }


        public static int EliminarMedicamento(sMedicamento med)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DbHelper.MakeParam("@Id", SqlDbType.Int, 0, med.Id),

                };
            return Convert.ToInt32(DbHelper.ExecuteScalar("sp_Medicamento_Eliminar", dbParams));

        }

        public static int EliminarPaciente(sPaciente oPas)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DbHelper.MakeParam("@Id", SqlDbType.Int, 0, oPas.id),

                };
            return Convert.ToInt32(DbHelper.ExecuteScalar("sp_Paciente_Eliminar", dbParams));

        }
        public static int TraerFolioVenta(int xid)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DbHelper.MakeParam("@Id", SqlDbType.Int, 0, xid),
             };
            return Convert.ToInt32(DbHelper.ExecuteScalar("sp_traer_folioventa", dbParams));
        }
        
    }
}

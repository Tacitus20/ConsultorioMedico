using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedico.Entidades
{
   public class eMedicamentos
    {
        public static Int32 id { get; set; }
        public static string Nombre { get; set; }
        public static string Compuesto { get; set; }
        public static string Presentacion { get; set; }
        public static string Gramaje { get; set; }
        public static string Descripcion { get; set; }
        public static string Laboratorio { get; set; }
        public static float Precio { get; set; }
        public static DateTime FechaCompra { get; set; }
        public static float Costo { get; set; }
        public static string Lote { get; set; }
        public static string Caducidad { get; set; }
        public static Int32 Stock { get; set; }
    }
}

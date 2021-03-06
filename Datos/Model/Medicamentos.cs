//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medicamentos
    {
        public Medicamentos()
        {
            this.DetalleCobro = new HashSet<DetalleCobro>();
        }
    
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Compuesto { get; set; }
        public string Presentacion { get; set; }
        public string Gramaje { get; set; }
        public string Descripcion { get; set; }
        public string Laboratorio { get; set; }
        public double Precio { get; set; }
        public Nullable<System.DateTime> FechaCompra { get; set; }
        public double Costo { get; set; }
        public string Lote { get; set; }
        public string Caducidad { get; set; }
        public Nullable<int> Stock { get; set; }
    
        public virtual ICollection<DetalleCobro> DetalleCobro { get; set; }
    }
}

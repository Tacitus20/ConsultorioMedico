//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsultorioMedico.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public Nullable<double> PrecioUnitario { get; set; }
        public Nullable<double> PrecioVenta { get; set; }
        public Nullable<decimal> Dia { get; set; }
        public Nullable<decimal> Noche { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<int> Stock { get; set; }
    
        public virtual Categoria Categoria { get; set; }
    }
}

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
    
    public partial class FolioVenta
    {
        public int Id { get; set; }
        public Nullable<int> folio { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> idusuario { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}

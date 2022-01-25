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
    
    public partial class Cobranza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cobranza()
        {
            this.DetalleCobro = new HashSet<DetalleCobro>();
        }
    
        public int id { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public decimal Total { get; set; }
        public string TotalenLetra { get; set; }
        public int id_usuario { get; set; }
        public int StatusCancel { get; set; }
        public int id_paciente { get; set; }
        public Nullable<int> Folio { get; set; }
        public int id_doctor { get; set; }
    
        public virtual Doctores Doctores { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCobro> DetalleCobro { get; set; }
    }
}

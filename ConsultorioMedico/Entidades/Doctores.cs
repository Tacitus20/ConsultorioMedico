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
    
    public partial class Doctores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctores()
        {
            this.Cobranza = new HashSet<Cobranza>();
            this.Consulta = new HashSet<Consulta>();
        }
    
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public int CedProfesional { get; set; }
        public string Estudio { get; set; }
        public string activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cobranza> Cobranza { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}

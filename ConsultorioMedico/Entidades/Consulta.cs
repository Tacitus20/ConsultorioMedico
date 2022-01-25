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
    
    public partial class Consulta
    {
        public int id { get; set; }
        public int id_doctor { get; set; }
        public int id_paciente { get; set; }
        public System.DateTime fecha { get; set; }
        public Nullable<int> Edad { get; set; }
        public Nullable<int> Peso { get; set; }
        public Nullable<double> Talla { get; set; }
        public string TenArt { get; set; }
        public Nullable<int> Pulso { get; set; }
        public Nullable<int> FreCardiaca { get; set; }
        public Nullable<int> FrecResp { get; set; }
        public Nullable<int> Temperatura { get; set; }
        public string Alergias { get; set; }
        public string PbDx { get; set; }
        public string Medicamentos { get; set; }
        public string Cita { get; set; }
    
        public virtual Doctores Doctores { get; set; }
    }
}

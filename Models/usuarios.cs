//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace asistencia.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuarios()
        {
            this.asistencia = new HashSet<asistencia>();
        }
    
        public int USU_ID { get; set; }
        public string USU_NOMBRES { get; set; }
        public string USU_USUARIO { get; set; }
        public string USU_PASSWORD { get; set; }
        public string USU_PERFIL { get; set; }
        public Nullable<int> USU_ESTADO { get; set; }
        public Nullable<System.DateTime> USU_FECHA { get; set; }
        public Nullable<int> USU_DIA { get; set; }
        public Nullable<int> USU_HORA { get; set; }
        public Nullable<int> USU_MIN { get; set; }
        public Nullable<int> USU_TOTAL_ATRASOS_MES { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<asistencia> asistencia { get; set; }
    }
}

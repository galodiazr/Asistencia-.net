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
    
    public partial class asistencia
    {
        public int ASI_ID { get; set; }
        public int USU_ID { get; set; }
        public System.DateTime ASI_FECHA { get; set; }
        public System.TimeSpan ASI_HORA_INGRESO { get; set; }
        public System.TimeSpan ASI_HORA_SALIDA { get; set; }
        public Nullable<int> ASI_ESTADO { get; set; }
        public string ASI_OBSERVACION { get; set; }
        public Nullable<int> ASI_ATRASO { get; set; }
    
        public virtual usuarios usuarios { get; set; }
    }
}
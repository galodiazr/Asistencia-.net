using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace asistencia.Models
{
    public class AsistenciaCLS
    {
        [Display(Name = "ID Asistencia")]
        public int idAsistencia { get; set; }

        [Display(Name = "ID Usuario")]
        public int idUsuario { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm:ss}", ApplyFormatInEditMode = true)]
        public TimeSpan horaIngreso { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm:ss}", ApplyFormatInEditMode = true)]
        public TimeSpan horaSalida { get; set; }

        [Display(Name = "Estado")]
        public int estadoAsistencia { get; set; }

        [Display(Name = "Observación")]
        public string observacion { get; set; }

        public int atrasos { get; set; }


        //propiedades adicionales
        [Display(Name = "Empleado")]
        public string empleadoAsistencia { get; set; }
        public string termino { get; set; }
        
        [Required]
        public string justificar { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaJustificar { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace asistencia.Models
{
    public class UsuariosCLS
    {
        [Display (Name = "ID Usuario")]
        public int idUsuario { get; set; }

        [StringLength(200, ErrorMessage = "Nombres, Longitud maxima 200")]
        [Display(Name = "Nombres Empleado")]
        [Required]
        public string nombres { get; set; }

        
        [MaxLength(10, ErrorMessage = "Cédula, Longitud 10 digitos")]
        [MinLength(10, ErrorMessage = "Cédula, Logitud 10 digitos")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Solo se acepta numeros")]
        [Display(Name = "Usuario")]
        [Required]
        public string usuario { get; set; }

        public string password { get; set; }

        [Display(Name = "Perfil")]
        [Required]
        public string perfil { get; set; }

        [Display(Name = "ID Usuario")]
        public int estado { get; set; }

        public int dia { get; set; }
        public int hora { get; set; }
        public int min { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha { get; set; }

        // Propiedades adicionales
        public string termino { get; set; }
        public int totalAtrasosMes { get; set; }
    }
}
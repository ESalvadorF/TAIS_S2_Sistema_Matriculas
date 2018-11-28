using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TAIS_S2_Sistema_Matriculas.Models
{
    public class Matricula
    {
        [Key]
        [DisplayName("DNI")]
        public int idMatricula { get; set; }

        [DisplayName("Codigo de Mátricula")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        public int CodigoMatricula { get; set; }

        [DisplayName("Fecha de de Matricula")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaMatricula { get; set; }

        [DisplayName("Seccion")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        public int IdSeccion { get; set; }
        public virtual Seccion Seccion { get; set; }

        [DisplayName("Monto Pago")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        public double MontoPago { get; set; }

        [DisplayName("Periodo")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        public int IdPeriodo { get; set; }

        [DisplayName("Alumno")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        public int Codigo { get; set; }

        public virtual Alumno Alumno { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TAIS_S2_Sistema_Matriculas.Models
{
    public class Alumno
    {
        [Key]
        [DisplayName("Código Alumno")]
        public int Codigo { get; set; }

        [DisplayName("DNI")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        public string Dni { get; set; }

        [DisplayName("Apellido Paterno")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        public string ApePaterno { get; set; }

        [DisplayName("Apellido Materno")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        public string ApeMaterno { get; set; }

        [DisplayName("Primer Nombre")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        public string PriNombre { get; set; }

        [DisplayName("Otro Nombre")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        public string OtroNombre { get; set; }

        [DisplayName("Sexo")]
        public string Sexo { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }

        //[DisplayName("Pais")]
        //public string Pais { get; set; }

        //[DisplayName("Departamento")]
        //public string Departamento { get; set; }

        //[DisplayName("Provincia")]
        //public string Provincia { get; set; }
        public int IdDistrito { get; set; }

        public virtual Distrito Distrito { get; set; }

        [DisplayName("Domicilio")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        public string Domicilio { get; set; }


        public virtual ICollection<Grado> Matriculas { get; set; }


    }
}
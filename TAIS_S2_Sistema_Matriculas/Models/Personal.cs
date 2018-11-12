using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TAIS_S2_Sistema_Matriculas.Models
{
    public class Personal
    {
        [Key]
        public string codigo { get; set; }
        public string apeNombres { get; set; }
        public string dni { get; set; }
        public string direccion { get; set; }
        public string estadoCivil { get; set; }
        public string telefono { get; set; }
        public string seguroSocial { get; set; }
        public string Departamento { get; set; }
        public string fechaIngreso { get; set; }
    }
}
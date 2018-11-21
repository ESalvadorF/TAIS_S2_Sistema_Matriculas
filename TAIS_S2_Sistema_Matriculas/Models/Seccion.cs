using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TAIS_S2_Sistema_Matriculas.Models
{
    public class Seccion
    {
        [Key]
        public int IdSeccion { get; set; }

        public string Descripcion { get; set; }

        public int IdGrado { get; set; }

        public Grado Grado { get; set; }
    }
}
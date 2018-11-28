using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TAIS_S2_Sistema_Matriculas.Models
{
    public class Distrito
    {
        [Key]
        public int IdDistrito { get; set; }

        public string Descripcion { get; set; }

        public int IdProvincia { get; set; }

        public virtual Provincia Provincia { get; set; }

        public virtual ICollection<Alumno> Alumnoes { get; set; }

    }
}
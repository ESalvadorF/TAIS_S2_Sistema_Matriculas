using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TAIS_S2_Sistema_Matriculas.Models
{
    public class Grado
    {
        [Key]
        public int IdGrado { get; set; }

        public string Descripcion { get; set; }

        public int IdNivel { get; set; }

        public virtual Nivel Nivel { get; set; }


        public virtual ICollection<Seccion> Seccions { get; set; }

        
    }
}
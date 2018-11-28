using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TAIS_S2_Sistema_Matriculas.Models
{
    public class Nivel
    {
        [Key]
        public int IdNivel { get; set; }

        public string Descripcion { get; set; }
       
        public virtual ICollection<Grado> Grados { get; set; }
    }
}
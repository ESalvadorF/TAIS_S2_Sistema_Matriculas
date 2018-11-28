using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TAIS_S2_Sistema_Matriculas.Models
{
    public class Pais
    {
        [Key]
        public int IdPais { get; set; }

        public string Descripcion { get; set; }

        public virtual ICollection<Departamento> Departamentos { get; set; }

    }
}
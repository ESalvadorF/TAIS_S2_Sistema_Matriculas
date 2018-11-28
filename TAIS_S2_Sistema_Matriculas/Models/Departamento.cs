using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TAIS_S2_Sistema_Matriculas.Models
{
    public class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }

        public string Descripcion { get; set; }

        public int IdPais { get; set; }

        public virtual Pais Pais { get; set; }

        public virtual ICollection<Provincia> Provincias { get; set; }

    }
}
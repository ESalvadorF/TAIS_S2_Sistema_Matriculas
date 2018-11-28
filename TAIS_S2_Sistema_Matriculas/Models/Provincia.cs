using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TAIS_S2_Sistema_Matriculas.Models
{
    public class Provincia
    {
        [Key]
        public int IdProvincia { get; set; }

        public string Descripcion { get; set; }

        public int IdDepartamento { get; set; }

        public virtual Departamento Departamento { get; set; }

        public virtual ICollection<Distrito> Distritos { get; set; }


    }
}
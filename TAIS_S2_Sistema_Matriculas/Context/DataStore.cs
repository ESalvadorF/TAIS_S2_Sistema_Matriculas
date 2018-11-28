using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TAIS_S2_Sistema_Matriculas.Models;

namespace TAIS_S2_Sistema_Matriculas.Context
{
    public class DataStore:DbContext
    {
        public DbSet<Personal>  Personal { set; get; }

        public DbSet<Alumno> Alumnos { set; get; }

        public System.Data.Entity.DbSet<TAIS_S2_Sistema_Matriculas.Models.Nivel> Nivels { get; set; }
        public DbSet<Grado> Gradoes { get; internal set; }

        public System.Data.Entity.DbSet<TAIS_S2_Sistema_Matriculas.Models.Distrito> Distritoes { get; set; }

        public System.Data.Entity.DbSet<TAIS_S2_Sistema_Matriculas.Models.Pais> Pais { get; set; }

        public System.Data.Entity.DbSet<TAIS_S2_Sistema_Matriculas.Models.Departamento> Departamentoes { get; set; }

        public System.Data.Entity.DbSet<TAIS_S2_Sistema_Matriculas.Models.Provincia> Provincias { get; set; }

        public System.Data.Entity.DbSet<TAIS_S2_Sistema_Matriculas.Models.Matricula> Matriculas { get; set; }

        public System.Data.Entity.DbSet<TAIS_S2_Sistema_Matriculas.Models.Seccion> Seccions { get; set; }
    }
}
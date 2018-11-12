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

    }
}
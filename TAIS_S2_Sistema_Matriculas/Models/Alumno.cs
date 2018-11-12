using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TAIS_S2_Sistema_Matriculas.Models
{
    public class Alumno
    {
        [Key]
        [DisplayName("Codigo Educando")]
        public string codEducando { get; set; }

        [DisplayName("Número de matricula")]
        public string nroMatricula { get; set; }

        [DisplayName("DNI")]
        public string dni { get; set; }

        [DisplayName("Apellido Paterno")]
        public string apePaterno { get; set; }

        [DisplayName("Apellido Materno")]
        public string apeMaterno { get; set; }

        [DisplayName("Primer Nombre")]
        public string priNombre { get; set; }

        [DisplayName("Otro Nombre")]
        public string otroNombre { get; set; }

        [DisplayName("Sexo")]
        public string sexo { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        public string fechaNacimiento { get; set; }

        [DisplayName("Pais")]
        public string pais { get; set; }

        [DisplayName("Escala")]
        public string escala { get; set; }

        [DisplayName("Añi de Ingreso")]
        public int añoIngreso { get; set; }

        [DisplayName("Departamento")]
        public string departamento { get; set; }

        [DisplayName("Provincia")]
        public string provincia { get; set; }

        [DisplayName("Lenguaje Materno")]
        public string lenguaMaterno { get; set; }

        [DisplayName("Estado Civil")]
        public string estadoCivil { get; set; }

        [DisplayName("Religion")]
        public string religion { get; set; }

        [DisplayName("Colegio de Procedencia")]
        public string colegioProcedencia { get; set; }

        [DisplayName("Domicilio")]
        public string domicilio { get; set; }

        [DisplayName("Departamento")]
        public string dDepartamento { get; set; }

        [DisplayName("Provincia")]
        public string dProvincia { get; set; }

        [DisplayName("Distrito")]
        public string dDistrito { get; set; }

        [DisplayName("Medio de Transporte")]
        public string medioTransporte { get; set; }

        [DisplayName("Demora en Llegar")]
        public string demoraLlegar { get; set; }

        [DisplayName("Material")]
        public string material { get; set; }

        [DisplayName("Energia Eléctrica")]
        public string energiaElectrica { get; set; }

        [DisplayName("Instalación de Agua")]
        public string instalacionAgua { get; set; }

        [DisplayName("Desague")]
        public string desague { get; set; }

        [DisplayName("Servicios Higienicos")]
        public string sshh { get; set; }

        [DisplayName("Número de Habitaciones")]
        public int nroHabitaciones { get; set; }

        [DisplayName("Número de Habitantes")]
        public int nroHabitantes { get; set; }

        [DisplayName("Situacion")]
        public string situacion { get; set; }

    }
}
namespace TAIS_S2_Sistema_Matriculas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        codEducando = c.String(nullable: false, maxLength: 128),
                        nroMatricula = c.String(),
                        dni = c.String(),
                        apePaterno = c.String(),
                        apeMaterno = c.String(),
                        priNombre = c.String(),
                        otroNombre = c.String(),
                        sexo = c.String(),
                        fechaNacimiento = c.String(),
                        pais = c.String(),
                        escala = c.String(),
                        añoIngreso = c.Int(nullable: false),
                        departamento = c.String(),
                        provincia = c.String(),
                        lenguaMaterno = c.String(),
                        estadoCivil = c.String(),
                        religion = c.String(),
                        colegioProcedencia = c.String(),
                        domicilio = c.String(),
                        dDepartamento = c.String(),
                        dProvincia = c.String(),
                        dDistrito = c.String(),
                        medioTransporte = c.String(),
                        demoraLlegar = c.String(),
                        material = c.String(),
                        energiaElectrica = c.String(),
                        instalacionAgua = c.String(),
                        desague = c.String(),
                        sshh = c.String(),
                        nroHabitaciones = c.Int(nullable: false),
                        nroHabitantes = c.Int(nullable: false),
                        situacion = c.String(),
                    })
                .PrimaryKey(t => t.codEducando);
            
            CreateTable(
                "dbo.Personals",
                c => new
                    {
                        codigo = c.String(nullable: false, maxLength: 128),
                        apeNombres = c.String(),
                        dni = c.String(),
                        direccion = c.String(),
                        estadoCivil = c.String(),
                        telefono = c.String(),
                        seguroSocial = c.String(),
                        Departamento = c.String(),
                        fechaIngreso = c.String(),
                    })
                .PrimaryKey(t => t.codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personals");
            DropTable("dbo.Alumnoes");
        }
    }
}

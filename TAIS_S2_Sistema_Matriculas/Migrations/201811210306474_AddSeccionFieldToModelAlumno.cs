namespace TAIS_S2_Sistema_Matriculas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSeccionFieldToModelAlumno : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seccions",
                c => new
                    {
                        IdSeccion = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        IdGrado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdSeccion)
                .ForeignKey("dbo.Gradoes", t => t.IdGrado, cascadeDelete: true)
                .Index(t => t.IdGrado);
            
            CreateTable(
                "dbo.Gradoes",
                c => new
                    {
                        IdGrado = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        IdNivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdGrado)
                .ForeignKey("dbo.Nivels", t => t.IdNivel, cascadeDelete: true)
                .Index(t => t.IdNivel);
            
            CreateTable(
                "dbo.Nivels",
                c => new
                    {
                        IdNivel = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.IdNivel);
            
            AddColumn("dbo.Alumnoes", "Seccion_IdSeccion", c => c.Int());
            CreateIndex("dbo.Alumnoes", "Seccion_IdSeccion");
            AddForeignKey("dbo.Alumnoes", "Seccion_IdSeccion", "dbo.Seccions", "IdSeccion");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumnoes", "Seccion_IdSeccion", "dbo.Seccions");
            DropForeignKey("dbo.Seccions", "IdGrado", "dbo.Gradoes");
            DropForeignKey("dbo.Gradoes", "IdNivel", "dbo.Nivels");
            DropIndex("dbo.Gradoes", new[] { "IdNivel" });
            DropIndex("dbo.Seccions", new[] { "IdGrado" });
            DropIndex("dbo.Alumnoes", new[] { "Seccion_IdSeccion" });
            DropColumn("dbo.Alumnoes", "Seccion_IdSeccion");
            DropTable("dbo.Nivels");
            DropTable("dbo.Gradoes");
            DropTable("dbo.Seccions");
        }
    }
}

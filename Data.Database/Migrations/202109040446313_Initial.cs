namespace Data.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlumnoInscripcion",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Condicion = c.Int(nullable: false),
                    Nota = c.Int(),
                    AlumnoId = c.Int(nullable: false),
                    CursoId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Persona", t => t.AlumnoId)
                .ForeignKey("dbo.Curso", t => t.CursoId)
                .Index(t => t.AlumnoId)
                .Index(t => t.CursoId);

            CreateTable(
                "dbo.Persona",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Nombre = c.String(nullable: false),
                    Apellido = c.String(nullable: false),
                    Legajo = c.Int(),
                    EMail = c.String(nullable: false),
                    Direccion = c.String(nullable: false),
                    Telefono = c.String(nullable: false),
                    FechaNacimiento = c.DateTime(nullable: false),
                    Tipo = c.Int(nullable: false),
                    PlanId = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Plan", t => t.PlanId)
                .Index(t => t.PlanId);

            CreateTable(
                "dbo.Plan",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Descripcion = c.String(nullable: false),
                    EspecialidadId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Especialidad", t => t.EspecialidadId)
                .Index(t => t.EspecialidadId);

            CreateTable(
                "dbo.Especialidad",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Descripcion = c.String(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Curso",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    AnioCalendario = c.Int(nullable: false),
                    Cupo = c.Int(nullable: false),
                    MateriaId = c.Int(nullable: false),
                    ComisionId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Comision", t => t.ComisionId)
                .ForeignKey("dbo.Materia", t => t.MateriaId)
                .Index(t => t.MateriaId)
                .Index(t => t.ComisionId);

            CreateTable(
                "dbo.Comision",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Descripcion = c.String(nullable: false),
                    AnioEspecialidad = c.Int(nullable: false),
                    PlanId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Plan", t => t.PlanId)
                .Index(t => t.PlanId);

            CreateTable(
                "dbo.Materia",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Descripcion = c.String(nullable: false),
                    HorasSemanales = c.Int(nullable: false),
                    HorasTotales = c.Int(nullable: false),
                    PlanId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Plan", t => t.PlanId)
                .Index(t => t.PlanId);

            CreateTable(
                "dbo.DocenteCurso",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Cargo = c.Int(nullable: false),
                    CursoId = c.Int(nullable: false),
                    DocenteId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Curso", t => t.CursoId)
                .ForeignKey("dbo.Persona", t => t.DocenteId)
                .Index(t => t.CursoId)
                .Index(t => t.DocenteId);

            CreateTable(
                "dbo.Usuario",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    NombreUsuario = c.String(nullable: false),
                    Clave = c.String(nullable: false),
                    Habilitado = c.Boolean(nullable: false),
                    PersonaId = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Persona", t => t.PersonaId)
                .Index(t => t.PersonaId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "PersonaId", "dbo.Persona");
            DropForeignKey("dbo.DocenteCurso", "DocenteId", "dbo.Persona");
            DropForeignKey("dbo.DocenteCurso", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.AlumnoInscripcion", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.Curso", "MateriaId", "dbo.Materia");
            DropForeignKey("dbo.Materia", "PlanId", "dbo.Plan");
            DropForeignKey("dbo.Curso", "ComisionId", "dbo.Comision");
            DropForeignKey("dbo.Comision", "PlanId", "dbo.Plan");
            DropForeignKey("dbo.AlumnoInscripcion", "AlumnoId", "dbo.Persona");
            DropForeignKey("dbo.Persona", "PlanId", "dbo.Plan");
            DropForeignKey("dbo.Plan", "EspecialidadId", "dbo.Especialidad");
            DropIndex("dbo.Usuario", new[] { "PersonaId" });
            DropIndex("dbo.DocenteCurso", new[] { "DocenteId" });
            DropIndex("dbo.DocenteCurso", new[] { "CursoId" });
            DropIndex("dbo.Materia", new[] { "PlanId" });
            DropIndex("dbo.Comision", new[] { "PlanId" });
            DropIndex("dbo.Curso", new[] { "ComisionId" });
            DropIndex("dbo.Curso", new[] { "MateriaId" });
            DropIndex("dbo.Plan", new[] { "EspecialidadId" });
            DropIndex("dbo.Persona", new[] { "PlanId" });
            DropIndex("dbo.AlumnoInscripcion", new[] { "CursoId" });
            DropIndex("dbo.AlumnoInscripcion", new[] { "AlumnoId" });
            DropTable("dbo.Usuario");
            DropTable("dbo.DocenteCurso");
            DropTable("dbo.Materia");
            DropTable("dbo.Comision");
            DropTable("dbo.Curso");
            DropTable("dbo.Especialidad");
            DropTable("dbo.Plan");
            DropTable("dbo.Persona");
            DropTable("dbo.AlumnoInscripcion");
        }
    }
}

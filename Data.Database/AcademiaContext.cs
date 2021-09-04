using Business.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Data.Database
{
    public class AcademiaContext : DbContext
    {
        public AcademiaContext() : base("name=AcademiaContext") { }

        public virtual DbSet<AlumnoInscripcion> AlumnoInscripcion { get; set; }
        public virtual DbSet<Comision> Comision { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<DocenteCurso> DocenteCurso { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            #region Required Properties
            modelBuilder.Entity<Usuario>().Property(e => e.NombreUsuario).IsRequired();
            modelBuilder.Entity<Usuario>().Property(e => e.Clave).IsRequired();

            modelBuilder.Entity<Plan>().Property(e => e.Descripcion).IsRequired();

            modelBuilder.Entity<Persona>().Property(e => e.Nombre).IsRequired();
            modelBuilder.Entity<Persona>().Property(e => e.Apellido).IsRequired();
            modelBuilder.Entity<Persona>().Property(e => e.EMail).IsRequired();
            modelBuilder.Entity<Persona>().Property(e => e.Direccion).IsRequired();
            modelBuilder.Entity<Persona>().Property(e => e.Telefono).IsRequired();
            modelBuilder.Entity<Persona>().Property(e => e.FechaNacimiento).IsRequired();

            modelBuilder.Entity<Materia>().Property(e => e.Descripcion).IsRequired();

            modelBuilder.Entity<Especialidad>().Property(e => e.Descripcion).IsRequired();

            modelBuilder.Entity<Comision>().Property(e => e.Descripcion).IsRequired();
            #endregion
        }
    }
}
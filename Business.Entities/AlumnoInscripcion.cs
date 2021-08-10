namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        public Persona MiAlumno { get; set; }

        public Curso MiCurso { get; set; }

        public string Condicion { get; set; }

        public int? Nota { get; set; }

        public enum Condiciones
        {
            Inscripto,
            Regular,
            Aprobado,
        }

        // Bind a dgvInscripciones
        public string DescripcionMateria
        {
            get
            {
                return MiCurso.MiMateria.Descripcion;
            }
        }

        public string DescripcionComision
        {
            get
            {
                return MiCurso.MiComision.Descripcion;
            }
        }
    }
}

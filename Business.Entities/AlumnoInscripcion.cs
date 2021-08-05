namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        public Persona MiAlumno { get; set; }

        public Curso MiCurso { get; set; }

        public string Condicion { get; set; }

        public float? Nota { get; set; }

        public enum Condiciones
        {
            Inscripto,
            Regular,
            Aprobado,
        }
    }
}

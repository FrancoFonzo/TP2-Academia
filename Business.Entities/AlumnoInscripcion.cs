namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        public AlumnoInscripcion()
        {
            Condicion = Condiciones.Inscripto;
        }

        public Condiciones Condicion { get; set; }
        public int? Nota { get; set; }

        #region Propiedades de Navegacion
        public int AlumnoId { get; set; }
        public virtual Persona Alumno { get; set; }
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
        #endregion

        #region Propiedades Auxiliares/DataPropertyName
        public string DescripcionMateria
        {
            get
            {
                return $"{Curso.Materia}";
            }
        }

        public int? Legajo {
            get
            {
                return MiAlumno.Legajo;
            }
        }
        public string Nombre {
            get
            {
                return MiAlumno.Nombre;
            }
        }
        public string Apellido {
            get
            {
                return MiAlumno.Apellido;
            }
        }

        public string DescripcionComision
        {
            get
            {
                return $"{Curso.Comision}";
            }
        }
        #endregion

        public enum Condiciones
        {
            Inscripto,
            Regular,
            Aprobado,
        }
    }
}

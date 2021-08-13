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
        public virtual Persona MiAlumno { get; set; }
        public virtual Curso MiCurso { get; set; }
        #endregion

        #region Propiedades Auxiliares/DataPropertyName
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
        #endregion

        public enum Condiciones
        {
            Inscripto,
            Regular,
            Aprobado,
        }
    }
}

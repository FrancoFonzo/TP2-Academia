namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        public TiposCargos Cargo { get; set; }

        #region Propiedade de Navegacion
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
        public int DocenteId { get; set; }
        public virtual Persona Docente { get; set; }
        #endregion

        public enum TiposCargos
        {
            Profesor,
            JefeDeCatedra,
            Auxiliar
        }
    }
}

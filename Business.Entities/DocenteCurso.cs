namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        public TiposCargos Cargo { get; set; }

        #region Propiedade de Navegacion
        public Curso MiCurso { get; set; }
        public Persona MiDocente { get; set; } 
        #endregion
        
        public enum TiposCargos
        {
            Profesor,
            JefeDeCatedra,
            Auxiliar
        }
    }
}

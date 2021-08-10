namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        public enum TiposCargos
        {
            Profesor,
            JefeDeCatedra,
            Auxiliar
        }
        public Curso MiCurso { get; set; }
        public Persona MiDocente { get; set; }
        public TiposCargos Cargo { get; set; }
    }
}

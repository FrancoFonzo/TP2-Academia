namespace Data.Database
{
    public class Adapter
    {
        protected Adapter() { }

        protected static readonly PersonaAdapter personaData = new PersonaAdapter();
        protected static readonly AlumnoInscripcionAdapter inscripcionData = new AlumnoInscripcionAdapter();
        protected static readonly CursoAdapter cursoData = new CursoAdapter();
        protected static readonly MateriaAdapter materiaData = new MateriaAdapter();
        protected static readonly ComisionAdapter comisionData = new ComisionAdapter();
        protected static readonly PlanAdapter planData = new PlanAdapter();
        protected static readonly EspecialidadAdapter especialidadData = new EspecialidadAdapter();
        protected static readonly DocenteCursoAdapter dictadoAdapter = new DocenteCursoAdapter();
    }
}

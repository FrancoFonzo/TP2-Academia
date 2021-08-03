using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class Adapter
    {

        protected static PersonaAdapter personaData = new PersonaAdapter();
        //protected static AlumnoInscripcionAdapter inscripcionData = new AlumnoInscripcionAdapter();
        //protected static CursoAdapter cursoData = new CursoAdapter();
        protected static MateriaAdapter materiaData = new MateriaAdapter();
        //protected static ComisionAdapter comisionData = new ComisionAdapter();
        protected static PlanAdapter planData = new PlanAdapter();
        //protected static ModuloAdapter moduloData = new ModuloAdapter();
        protected static EspecialidadAdapter especialidadData = new EspecialidadAdapter();
        //protected static DocenteCursoAdapter dictadoAdapter = new DocenteCursoAdapter();
        //protected static ModuloUsuarioAdapter moduloUsuarioData = new ModuloUsuarioAdapter();
    }
}

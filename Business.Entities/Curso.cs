using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
   public class Curso: BusinessEntity
    {
        public string Descripcion 
        { 
            get
            {
                return $"{MiMateria.Descripcion} - {MiComision.Descripcion} - {AnioCalendario}";
            }
        }
        public int AnioCalendario { get; set; }
        public int Cupo { get; set; }

        #region Propiedades de Navegacion
        public Materia MiMateria { get; set; }
        public Comision MiComision { get; set; }
        #endregion

        public override string ToString()
        {
            return Descripcion;
        }
    }
}

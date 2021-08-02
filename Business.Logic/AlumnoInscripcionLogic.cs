using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    class AlumnoInscripcionLogic : BusinessLogic
    {
        public AlumnoInscripcionAdapter InscripcionData { get; set; }

        public AlumnoInscripcionLogic()
        {
            this.InscripcionData = new AlumnoInscripcionAdapter();
        }

        public AlumnoInscripcion GetOne(int id)
        {
            return InscripcionData.GetOne(id);
        }

        public List<Usuario> GetAll()
        {
            return InscripcionData.GetAll();
        }

        public void Save(Usuario usuario)
        {
            InscripcionData.Save(usuario);
        }

        public void Delete(int id)
        {
            InscripcionData.Delete(id);
        }

    }
}

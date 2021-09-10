using Business.Entities;
using Data.Database;
using System.Collections.Generic;

namespace Business.Logic
{
    public class PersonaLogic : BusinessLogic
    {
        public PersonaAdapter PersonaData { get; set; }

        public PersonaLogic()
        {
            PersonaData = new PersonaAdapter();
        }

        public List<Persona> GetAll()
        {
            return PersonaData.GetAll();
        }

        public List<Persona> GetAllSinUsuario()
        {
            return PersonaData.GetAllSinUsuario();
        }

        public List<Persona> GetAllTipo(Persona.TiposPersonas tipo)
        {
            return PersonaData.GetAllByTipo(tipo);
        }

        public Persona GetOne(int id)
        {
            return PersonaData.GetOne(id);
        }

        public void Save(Persona persona)
        {
            PersonaData.Save(persona);
        }
    }
}

using Business.Entities;
using Data.Database;
using System;
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

        public Persona GetOne(int id)
        {
            return PersonaData.GetOne(id);
        }

        public List<Persona> GetAll()
        {
            return PersonaData.GetAll();
        }

        public List<String> GetTipos()
        {
            return PersonaData.GetTipos();
        }

        public List<Persona> GetPersonasSinUsuario()
        {
            return PersonaData.GetPersonasSinUsuario();
        }

        public void Save(Persona persona)
        {
            PersonaData.Save(persona);
        }

        public void Delete(int id)
        {
            PersonaData.Delete(id);
        }
    }
}

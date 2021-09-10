using System.Collections.Generic;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        public UsuarioAdapter UsuarioData { get; set; }

        public UsuarioLogic()
        {
            UsuarioData = new UsuarioAdapter();
        }

        public List<Entities.Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        }

        public Entities.Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }

        public Entities.Usuario GetOneNombreUsuario(string user)
        {
            return UsuarioData.GetOneByNombreUsuario(user);
        }

        public void Save(Entities.Usuario usuario)
        {
            UsuarioData.Save(usuario);
        }
    }
}

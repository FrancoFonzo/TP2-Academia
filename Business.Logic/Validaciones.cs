using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Logic
{
    public static class Validaciones
    {
        public static bool ValidarEmail(string email)
        {
            String patron = @"^[a-z0-9!#$%&'""*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'""*+/=?^_`{|}~-]+)*" +
                    @"@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
            if (!Regex.IsMatch(email, patron)) return false;
            return true;
        }

        public static bool ValidarClave(string clave)
        {
            string patron = ".{4,50}";
            if (!Regex.IsMatch(clave, patron)) return false;
            return true;
        }

        public static bool ValidarClaveConfirmada(string clave, string conf)
        {
            if (!clave.Equals(conf)) return false;
            return true;
        }

        public static bool ValidarNyA(string texto)
        {
            String patron = @"^[A-Za-zÀ-ú]+([-' ][A-Za-zÀ-ú]+)*$";
            if (!Regex.IsMatch(texto, patron)) return false;
            return true;
        }

        public static bool FormularioCompleto(List<string> txts)
        {
            bool rta=true;
            txts.ForEach(t => { if(t.Equals(String.Empty)) rta=false; });
            return rta;
        }
    }
}

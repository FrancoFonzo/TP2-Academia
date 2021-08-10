using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Business.Logic
{
    public static class Validaciones
    {
        public static bool ValidarRegexEmail(string email)
        {
            String patron = @"^[a-z0-9!#$%&'""*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'""*+/=?^_`{|}~-]+)*" +
                    @"@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
            return Regex.IsMatch(email, patron);
        }

        public static bool ValidarRegexClave(string clave)
        {
            string patron = ".{4,50}";
            return Regex.IsMatch(clave, patron);
        }

        public static bool ValidarClaveConfirmada(string clave, string conf)
        {
            return clave.Equals(conf);
        }

        public static bool ValidarRegexNyA(string texto)
        {
            String patron = @"^[A-Za-zÀ-ú]+([-' ][A-Za-zÀ-ú]+)*$";
            return Regex.IsMatch(texto, patron);
        }

        public static bool FormularioCompleto(List<string> txts)
        {
            bool rta = true;
            txts.ForEach(t =>
            {
                if (string.IsNullOrEmpty(t)) 
                {
                    rta = false; 
                }
            });
            return rta;
        }

        public static bool ValidarClave(string clave_usr, string txt_clave)
        {
            if (string.IsNullOrEmpty(clave_usr) || !clave_usr.Equals(txt_clave))
            {
                return false;
            }
            return true;
        }
    }
}

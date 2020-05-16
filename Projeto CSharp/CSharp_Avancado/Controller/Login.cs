using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Avancado.Controller
{
    public static class Login
    {
        public static string usuario { get; set; }
        public static string senha { get; set; }

        public static bool testaLogin()
        {
            if (!String.IsNullOrEmpty(Login.usuario) && !String.IsNullOrEmpty(Login.senha))
            {
                if (new DBC().RecuperaLogin(usuario, senha) != null)
                    return true;
            }

            return false;
        }
    }
}

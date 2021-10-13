using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_tareas
{
    public class Login
    {
        public static List<Login> usuario;

        public string user { get; set; }

        public string pass { get; set; }

        public Login()
        {
            if(usuario == null)
            {
                usuario = new List<Login>();
                Login usuarios = new Login();
                usuarios.user = "admin";
                usuarios.pass = "1234";
                usuario.Add(usuarios);
            }

        }

        public bool login()
        {
            try
            {
                foreach (var item in usuario)
                {
                    if (item.user.Equals(this.user) && item.pass.Equals(this.pass))
                    {
                        return true;
                    }

                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error agregando: " + ex.Message);
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP.Utilisateur
{
    public class Utilisateur : User
    {
        public Utilisateur(string login)
        {
            this.Login = login;
        }
    }
}

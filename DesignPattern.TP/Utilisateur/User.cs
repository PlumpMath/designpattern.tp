using DesignPattern.TP.Utilisateur.Pattern.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP.Utilisateur
{
    public abstract class User
    {
        private string _login;
        private EtatUser _etat;

        public string Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
            }
        }

        public EtatUser Etat
        {
            get
            {
                return _etat;
            }

            set
            {
                _etat = value;
            }
        }
    }
}

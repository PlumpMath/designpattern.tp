using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP.Utilisateur.Pattern.State
{
    public abstract class EtatUser
    {
        protected abstract void setEtat(User u, EtatUser e);
        public abstract void present(User u);
        public abstract void absent(User u);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP.Utilisateur.Pattern.State
{
    public class Absent : EtatUser
    {
        public override void absent(User u)
        {
            throw new NotImplementedException();
        }

        public override void present(User u)
        {
            throw new NotImplementedException();
        }

        protected override void setEtat(User u, EtatUser e)
        {
            throw new NotImplementedException();
        }
    }
}

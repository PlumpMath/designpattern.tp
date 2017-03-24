using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP.Pattern.Singleton
{
    public class ConnexionBDD
    {
        private ConnexionBDD instance = null;
        private ConnexionBDD()
        {
            if (this.instance == null)
            {
                this.instance = new ConnexionBDD();
            }
        }
        public ConnexionBDD getInstance()
        {
            return this.instance;
        }

    }
}

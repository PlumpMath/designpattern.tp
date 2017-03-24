using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP.Pattern.Memento
{
    public class Gardien
    {
        private List<Memento> _lstMemento;

        internal List<Memento> LstMemento
        {
            get
            {
                return _lstMemento;
            }

            set
            {
                _lstMemento = value;
            }
        }

        public void ajouterMemento(Memento m)
        {
            this.LstMemento.Add(m);
        }

        public List<Memento> getMemento()
        {
            return this.LstMemento;
        }
    }
}

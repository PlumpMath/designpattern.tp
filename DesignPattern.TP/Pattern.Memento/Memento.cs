using DesignPattern.TP.Pattern.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP.Pattern.Memento
{
    public class Memento
    {
        private List<Message> _lstMessageEtat;

        public List<Message> getEtat()
        {
            return this._lstMessageEtat;
        }

        public void ajouterEtat(Message m)
        {
            this._lstMessageEtat.Add(m);
        }

    }
}

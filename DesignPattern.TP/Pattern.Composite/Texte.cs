using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.TP.Pattern.Visitor;
using DesignPattern.TP.Pattern.Flyweight;

namespace DesignPattern.TP.Pattern.Composite
{
    public class Texte : Message, IStyleMessage
    {
        protected string contenu;
        protected int etat = 2; //Si 1 = intrinsèque, si 2 extrinseque
        public Texte(Horodatage h, Texte t, Lien l, Couleur c) : base(h, t, l, c)
        {
        }
        public Texte(string s)
        {
            this.contenu = s;
        }

        public Texte()
        {
        }

        public override void add(Message m)
        {
            Console.WriteLine("Impossible, c'est une feuille");
        }
        public new void filter(IMessageFilter f)
        {
            throw new NotImplementedException();
        }
        public override void remove(Message m)
        {
            Console.WriteLine("Impossible, c'est une feuille");
        }

        public int operationFlyWeight()
        {
            return etat;
        }
    }
}

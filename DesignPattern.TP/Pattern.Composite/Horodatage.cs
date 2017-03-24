using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.TP.Pattern.Visitor;
using DesignPattern.TP.Pattern.Flyweight;

namespace DesignPattern.TP.Pattern.Composite
{
    public class Horodatage : Message, IStyleMessage
    {
        protected DateTime horodatage;
        protected int etat = 2; //Si 1 = intrinsèque, si 2 extrinseque
        public Horodatage(Horodatage h, Texte t, Lien l, Couleur c) : base(h, t, l, c)
        {
        }
        public Horodatage(DateTime d)
        {
            this.horodatage = d;
        }

        public Horodatage()
        {
        }

        public override void add(Message m)
        {
            Console.WriteLine("Impossible, c'est une feuille");
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

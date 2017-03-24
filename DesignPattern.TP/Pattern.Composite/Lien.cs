using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.TP.Pattern.Visitor;
using DesignPattern.TP.Pattern.Flyweight;

namespace DesignPattern.TP.Pattern.Composite
{
    public class Lien : Message, IStyleMessage
    {
        protected string lien;
        protected int etat = 1; //Si 1 = intrinsèque, si 2 extrinseque
        public Lien(Horodatage h, Texte t, Lien l, Couleur c) : base(h, t, l, c)
        {
        }
        public Lien(string l)
        {
            this.lien = l;
        }

        public Lien()
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

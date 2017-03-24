using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.TP.Pattern.Visitor;
using DesignPattern.TP.Pattern.Flyweight;

namespace DesignPattern.TP.Pattern.Composite
{
    public class Couleur : Message, IStyleMessage
    {
        protected string couleur;
        protected int etat = 1; //Si 1 = intrinsèque, si 2 extrinseque
        public Couleur(Horodatage h, Texte t, Lien l, Couleur c) : base(h, t, l, c)
        {
        }
        public Couleur(string c)
        {
            this.couleur = c;
        }

        public Couleur()
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

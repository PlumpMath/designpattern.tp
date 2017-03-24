using DesignPattern.TP.Pattern.Composite;
using DesignPattern.TP.Pattern.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP
{
    class Program
    {
        static void Main(string[] args)
        {
            Texte texte = new Texte("fefzefezfefzf");
            Lien lien = new Lien("fzefezfezfze");
            Couleur couleur = new Couleur("jkjnkjnkjn");
            Horodatage horodatage = new Horodatage(DateTime.Now);

            MessageComposite root = new MessageComposite(horodatage, texte, lien, couleur);

            IMessageFilter filter = new MessageGrasFilter();
            filter.appliquer(root);


        }
    }
}

using DesignPattern.TP.Pattern.Composite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP.Pattern.Flyweight
{
    public class StyleFactory_Flyweight
    {
        public Hashtable listeDesFLyWights;

        public IStyleMessage getFlyWeight(int key)
        {
            if (listeDesFLyWights == null)
            {
                this.listeDesFLyWights = new Hashtable();
            }
            if (this.listeDesFLyWights.ContainsKey(key))
            {
                return (IStyleMessage)listeDesFLyWights[key];
            }
            switch (key)
            {
                case 1:
                    listeDesFLyWights.Add(key, new Couleur());
                    break;
                case 2:
                    listeDesFLyWights.Add(key, new Horodatage());
                    break;
                case 3:
                    listeDesFLyWights.Add(key, new Lien());
                    break;
                case 4:
                    listeDesFLyWights.Add(key, new Texte());
                    break;
            }
            return (IStyleMessage)listeDesFLyWights[key];
        }
    }
}

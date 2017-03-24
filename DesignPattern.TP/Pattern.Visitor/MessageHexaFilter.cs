using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.TP.Pattern.Composite;
using System.IO;

namespace DesignPattern.TP.Pattern.Visitor
{
    public class MessageHexaFilter : IMessageFilter
    {
        /// <summary>
        /// Remplacement des # en couleurs
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public string appliquer(Message m)
        {
            int dieze = 0;
            int espace = 0;
            int index = 0;
            char[] tableauTexte = m.Texte.ToString().ToCharArray();
            using (StringReader sr = new StringReader(m.Texte.ToString()))
            {
                if (sr.Read().ToString() == "#")
                {
                    dieze = index;
                }
                else if (sr.Read().ToString() == " ")
                {
                    espace = index;
                }
                index++;
            }
            return m.Texte.ToString();
        }
    }
}

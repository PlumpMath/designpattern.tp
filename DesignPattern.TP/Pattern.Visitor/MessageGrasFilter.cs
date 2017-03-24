using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.TP.Pattern.Composite;
using System.IO;

namespace DesignPattern.TP.Pattern.Visitor
{
    public class MessageGrasFilter : IMessageFilter
    {
        /// <summary>
        /// Remplacement des * en gras
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public string appliquer(Message m)
        {
            int i = 2;
            char[] tableauTexte = m.Texte.ToString().ToCharArray();
            using (StringReader sr = new StringReader(m.Texte.ToString()))
            { 
                if (sr.Read().ToString() == "*" && i % 2 == 0)
                {
                    m.Texte.ToString().Replace("*", "<b>");
                    i++;
                }
                else if (sr.Read().ToString() == "*" && i % 2 != 0)
                {
                    m.Texte.ToString().Replace("*", "</b>");
                    i++;
                }
            }
            return m.Texte.ToString();
        }
    }
}

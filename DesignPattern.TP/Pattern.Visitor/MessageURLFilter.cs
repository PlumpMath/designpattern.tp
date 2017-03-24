using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.TP.Pattern.Composite;
using System.IO;

namespace DesignPattern.TP.Pattern.Visitor
{
    public class MessageURLFilter : IMessageFilter
    {
        /// <summary>
        /// Remplacement des liens en URL cliquable.
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public string appliquer(Message m)
        {
            return m.Texte.ToString().Replace("http://","<a href>http://");
        }
    }
}

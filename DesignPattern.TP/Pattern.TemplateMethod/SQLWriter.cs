using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP.Pattern.TemplateMethod
{
    public class SQLWriter : Writer
    {
        public override void sauvegarder()
        {
            throw new NotImplementedException();
        }
    }
}

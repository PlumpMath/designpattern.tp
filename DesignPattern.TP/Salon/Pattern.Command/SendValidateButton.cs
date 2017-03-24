using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.TP.Pattern.Composite;

namespace DesignPattern.TP.Salon.Pattern.Command
{
    public class SendValidateButton : EnvoiMessage
    {
        public override Message send(Message m)
        {
            throw new NotImplementedException();
        }
    }
}

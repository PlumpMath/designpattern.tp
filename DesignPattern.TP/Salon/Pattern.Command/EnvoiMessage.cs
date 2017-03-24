using DesignPattern.TP.Pattern.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP.Salon.Pattern.Command
{
    public abstract class EnvoiMessage
    {
        public abstract Message send(Message m);

    }
}

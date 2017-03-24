using DesignPattern.TP.Pattern.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP.Pattern.Visitor
{
    public interface IMessageFilter
    {
        string appliquer(Message m);
    }
}

using DesignPattern.TP.Pattern.Composite;
using DesignPattern.TP.Utilisateur.Pattern.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP.Salon
{
    public class SalonDiscussion : Mediator, IObservable<Message>, IObserver<Message>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Message value)
        {
            throw new NotImplementedException();
        }

        public IDisposable Subscribe(IObserver<Message> observer)
        {
            throw new NotImplementedException();
        }
    }
}

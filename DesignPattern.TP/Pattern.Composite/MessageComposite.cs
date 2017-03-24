using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.TP.Pattern.Visitor;

namespace DesignPattern.TP.Pattern.Composite
{
    public class MessageComposite : Message
    {
        #region Champs
        private List<Message> _listCompo = new List<Message>();

        public MessageComposite(Horodatage h, Texte t, Lien l, Couleur c) : base(h, t, l, c)
        {
        }
        public MessageComposite()
        {

        }
        #endregion

        #region GetterSetters
        public List<Message> ListCompo
        {
            get
            {
                return _listCompo;
            }

            set
            {
                _listCompo = value;
            }
        }
        #endregion

        #region Méthodes
        public override void add(Message m)
        {
            ListCompo.Add(m);
        }

        public override void remove(Message m)
        {
            ListCompo.Remove(m);
        }
        #endregion

    }
}

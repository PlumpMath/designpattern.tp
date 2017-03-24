using DesignPattern.TP.Pattern.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TP.Pattern.Composite
{
    public abstract class Message : IMessage
    {
        #region Champs
        private Horodatage _horodatage;
        private Texte _texte;
        private Lien _lien;
        private Couleur _couleur;
        private Horodatage h;
        private Texte t;
        private Lien l;
        private Couleur c;
        #endregion

        #region Gettersetter
        public Horodatage Horodatage
        {
            get
            {
                return _horodatage;
            }

            set
            {
                _horodatage = value;
            }
        }

        internal Texte Texte
        {
            get
            {
                return _texte;
            }

            set
            {
                _texte = value;
            }
        }

        internal Lien Lien
        {
            get
            {
                return _lien;
            }

            set
            {
                _lien = value;
            }
        }

        internal Couleur Couleur
        {
            get
            {
                return _couleur;
            }

            set
            {
                _couleur = value;
            }
        }
        #endregion

        #region Méthodes
        public abstract void add(Message m);
        public abstract void remove(Message m);

        public void filter(IMessageFilter f)
        {
            throw new NotImplementedException();
        }

        public Message()
        {
        }

        public Message(Horodatage h, Texte t, Lien l, Couleur c)
        {
            this.h = h;
            this.t = t;
            this.l = l;
            this.c = c;
        }
        #endregion
    }
}

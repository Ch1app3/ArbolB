using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Nodo
    {
        private int _Dato;

        public int Dato
        {
            get { return _Dato; }
            set { _Dato = value; }
        }
        private Nodo _HI;

        public Nodo HI
        {
            get { return _HI; }
            set { _HI = value; }
        }
        private Nodo _HD;

        public Nodo HD
        {
            get { return _HD; }
            set { _HD = value; }
        }
        private Nodo _Padre;

        public Nodo Padre
        {
            get { return _Padre; }
            set { _Padre = value; }
        }




    }
}

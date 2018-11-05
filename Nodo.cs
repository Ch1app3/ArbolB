using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolB
{
    class Nodo
    {
        private Int32 _Dato;

        public Int32 Dato
        {
            get { return _Dato; }
            set { _Dato = value; }
        }
        private Nodo _Padre;
                    
        public Nodo Padre
        {
            get { return _Padre; }
            set { _Padre = value; }
        }
        private Nodo _hijoDer;

        public Nodo hijoDer
        {
            get { return _hijoDer; }
            set { _hijoDer = value; }
        }
        private Nodo _hijoIzq;

        public Nodo hijoIzq
        {
            get { return _hijoIzq; }
            set { _hijoIzq = value; }
        }



    }
}

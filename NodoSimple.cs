using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class NodoSimple
    {
        private int _Dato;

        public int Dato
        {
            get { return _Dato; }
            set { _Dato = value; }
        }

        private NodoSimple _siguiente;

        public NodoSimple SIGUIENTE
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
    }
}

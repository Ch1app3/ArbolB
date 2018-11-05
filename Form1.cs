using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolB
{
    public partial class ArbolB : Form
    {
        Nodo Raiz = new Nodo();
        
        
        public ArbolB()
        {
            InitializeComponent();
            Raiz = null;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 cantidad = 0;
            Nodo NuevoNodo = new Nodo();
            NuevoNodo.Dato = Int32.Parse(textBox1.Text);

            if (Raiz==null)
            {
                Raiz = NuevoNodo;
                cantidad++;
            }
            else
            {
                Nodo Actual = new Nodo();
                Actual = Raiz;
                bool flag = false;
                while (flag == false)
                {
                    if (NuevoNodo.Dato < Actual.Dato)
                    {
                        if (Actual.hijoIzq == null)
                        {
                            NuevoNodo.Padre = Actual;
                            Actual.hijoIzq = NuevoNodo;
                            flag = true;


                        }
                        else
                        {
                            Actual = Actual.hijoIzq;
                        }
                    }
                }

            }
        }
    }
}

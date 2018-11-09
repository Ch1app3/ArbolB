using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Nodo Raiz = new Nodo();
        Int32 cantidad = 0;
        Int32 cuantos = 0;
        NodoSimple Base = new NodoSimple();
        NodoSimple Cima = new NodoSimple();
        bool Repetido = false;


        public Form1()
        {
            InitializeComponent();
            Raiz = null;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {

            
            Nodo NuevoNodo = new Nodo();
            NuevoNodo.Dato = Int32.Parse(textBox1.Text);
            NoEsRepetido();

            if (Repetido == false)
            {

            
            if (Raiz == null)
            {
                Raiz = NuevoNodo;
                cantidad++;
                Apilo();
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
                            cantidad++;
                            Apilo();


                        }
                        else
                        {
                            Actual = Actual.hijoIzq;
                        }
                    }
                    else
                    {
                        if (Actual.hijoDer == null)
                        {
                            NuevoNodo.Padre = Actual;
                            Actual.hijoDer = NuevoNodo;
                            flag = true;
                            cantidad++;
                            Apilo();
                        }
                        else
                        {
                            Actual = Actual.hijoDer;
                        }
                    }
                }

            }
            }else
            {
                MessageBox.Show("El dato ya existe en el Arbol");
            }
        }

        private void NoEsRepetido()
        {

            NodoSimple Duplicate = new WindowsFormsApplication1.NodoSimple();
            Duplicate.Dato = int.Parse(textBox1.Text);
            NodoSimple ActualDuplicate = new NodoSimple();
            ActualDuplicate = Cima;
            while (ActualDuplicate.SIGUIENTE != null)
            {
                if (ActualDuplicate.Dato == Duplicate.Dato)
                {
                    Repetido = true;
                    
                }
                else
                {
                    ActualDuplicate = ActualDuplicate.SIGUIENTE;
                }
            }
        }

        private void Apilo()
        {
            Nodo NuevoNodoPila = new Nodo();
            NuevoNodoPila.Dato = Int32.Parse(textBox1.Text);

            if (cuantos == 0)
            {
                MessageBox.Show("La Pila estba vacia");
                NodoSimple NuevoNodoSimple = new NodoSimple();
                NuevoNodoSimple.Dato = NuevoNodoPila.Dato;
                cuantos++;
                Cima = NuevoNodoSimple;
                Base = NuevoNodoSimple;

            }
            else
            {
                NodoSimple NuevoNodoSimple = new NodoSimple();
                NuevoNodoSimple.Dato = NuevoNodoPila.Dato;
                cuantos++;
                NuevoNodoSimple.SIGUIENTE = Cima;
                Cima = NuevoNodoSimple;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) && (e.KeyChar == (char)Keys.Subtract))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            
        

            

        }

        
    }
}

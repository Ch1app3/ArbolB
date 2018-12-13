using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parcial
{
    public partial class Form1 : Form
    {
        

        Nodo Raiz = new Nodo();
        public Form1()
        {
            Raiz = null;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            var Lineas = File.ReadAllLines("Dato.txt");
            var Texto = String.Join("\r\n", Lineas);
            textBox1.Text = Texto;
            button2.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bool Flag = true;
            

            FileStream FS1;
            FS1 = new FileStream("Dato.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS1);
            

            while (!SR.EndOfStream)
            {
                Nodo NuevoDato = new Nodo();
                NuevoDato.Dato = int.Parse(SR.ReadLine());
                bool Flag1 = false;

                if (Flag == true)
                {
                    Raiz = NuevoDato;
                    Flag = false;
                    
                    
                }
                else
                {
                    Nodo Actual = new Nodo();
                    Actual = Raiz;
                    
                    while (Flag1 == false)
                    {
                        if (NuevoDato.Dato < Actual.Dato)
                        {
                            if (Actual.HI == null)
                            {
                                NuevoDato.Padre = Actual;
                                Actual.HI = NuevoDato;
                                Flag1 = true;
                                


                            }
                            else
                            {
                                Actual = Actual.HI;
                            }
                        }
                        else
                        {
                            if (Actual.HD == null)
                            {
                                NuevoDato.Padre = Actual;
                                Actual.HD = NuevoDato;
                                Flag1 = true;
                                

                            }
                            else
                            {
                                Actual = Actual.HD;
                            }
                        }



                    }


                }



            }

            button2.Enabled = false;
            FS1.Close();

        }

        public void button4_Click(object sender, EventArgs e)
        {
            FileStream FS;
            File.Delete("Solucion.txt");
            FS = new FileStream("Solucion.txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FS);
            string linea = "Universidad Abierta Interamericana\r\n" + "Facultad de Tecniologia-Ingenieria en Sistemas Informaticos\r\n" + "Programacion 1 - 2018\r\n";
            SW.WriteLine(linea);
            File.Delete("Preorder.txt");
            Preorder(Raiz);
            var Lineas = File.ReadAllLines("Preorder.txt");
            var Texto = String.Join("\r\n", Lineas);
            SW.WriteLine(Texto + "\r\n");
            string linea2 = "Apellido y Nombre del Docente                                 Apellido y Nombre del Alumno";
            SW.WriteLine(linea2);
            SW.Close();
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream FS;
            File.Delete("Solucion.txt");
            FS = new FileStream("Solucion.txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FS);
            string linea = "Universidad Abierta Interamericana\r\n" + "Facultad de Tecniologia-Ingenieria en Sistemas Informaticos\r\n" + "Programacion 1 - 2018\r\n";
            SW.WriteLine(linea);
            File.Delete("Inorder.txt");
            Inorder(Raiz);
            var Lineas = File.ReadAllLines("Inorder.txt");
            var Texto = String.Join("\r\n", Lineas);
            SW.WriteLine(Texto + "\r\n");
            string linea2 = "Apellido y Nombre del Docente                                 Apellido y Nombre del Alumno";
            SW.WriteLine(linea2);
            SW.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream FS;
            File.Delete("Solucion.txt");
            FS = new FileStream("Solucion.txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FS);
            string linea = "Universidad Abierta Interamericana\r\n" + "Facultad de Tecniologia-Ingenieria en Sistemas Informaticos\r\n" + "Programacion 1 - 2018\r\n";
            SW.WriteLine(linea);
            File.Delete("Postorder.txt");
            Postorder(Raiz);
            var Lineas = File.ReadAllLines("Postorder.txt");
            var Texto = String.Join("\r\n", Lineas);
            SW.WriteLine(Texto + "\r\n");
            string linea2 = "Apellido y Nombre del Docente                                 Apellido y Nombre del Alumno";
            SW.WriteLine(linea2);
            SW.Close();

        }

        public void Preorder(Nodo Actual)
        {
            FileStream FS;
            if (Actual == null) return;
            FS = new FileStream("Preorder.txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FS);
            string linea1 = Convert.ToString(Actual.Dato);
            SW.WriteLine(linea1);
            SW.Close();
            Preorder(Actual.HI);
            Preorder(Actual.HD);
            

        }

        public void Inorder(Nodo Actual)
        {
            
            if (Actual == null) return;
            Inorder(Actual.HI);
            FileStream FS;
            FS = new FileStream("Inorder.txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FS);
            string linea1 = Convert.ToString(Actual.Dato);
            SW.WriteLine(linea1);
            SW.Close();
            Inorder(Actual.HD);


        }

        public void Postorder(Nodo Actual)
        {

            if (Actual == null) return;
            Postorder(Actual.HI);
            Postorder(Actual.HD);
            FileStream FS;
            FS = new FileStream("Postorder.txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FS);
            string linea1 = Convert.ToString(Actual.Dato);
            SW.WriteLine(linea1);
            SW.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            FileStream FS1;
            FS1 = new FileStream("Solucion.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS1);

            while (!SR.EndOfStream)
            {
                var Texto = SR.ReadLine();
                // var Lineas = File.ReadAllLines("Solucion.txt");
                // var Texto = String.Join("\r\n", Lineas);
                listBox1.Items.Add(Texto + "\r\n");
            }

            FS1.Close();
            SR.Close();

        }

        
    }
}
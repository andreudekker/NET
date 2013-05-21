using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Linq_Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sortchararray();
            //arrayporpaises();
            //usandoLinq();
            consulta2linq();
        }
        #region Ordenar arreglo
        private void sortchararray()
        {
            char[] array = { 'x', 'z', 'a', 'b', 't', 'u', 'w' };   //sort del array
            Array.Sort<char>(array);
            foreach (var c in array)
            {
                listBox1.Items.Add(c.ToString());
            }   
        }
        #endregion

        #region Array por paises
        private void arrayporpaises()
        {
            string [] paises =new string[]
            {
                "Colombia",
                "Venezuela",
                "PuertoRico",
                "Mexico",
                "Chile",
                "Philipinas",
                "Japon",
                "India"
            };
            Array.Sort(paises);
            foreach (var s in paises)
            {
                listBox1.Items.Add(s.ToString());
            }
        }
        #endregion

        #region Usandolinq

        public void usandoLinq()
        { 
           string[] nombres={"Andres","Edison","Mariana","Tatiana","Josefa","Pablo","Natalia","Monica","Ricardo","Ruben","Edison"};
            //se usa la palabra var porque no hay nombre para el tipo resultante de pila proyeccoin
             var sort = from  s in nombres
                   //orderby s              
                   where s.Length >=7
                        select s;
           //sort ahora es un inumerable donde t  es un tipo anonimo generado por el compilador
            foreach (string c in sort)
            {
                listBox1.Items.Add(c.ToString());
            }
        }
        #endregion

        #region Consulta2enlinq
        private void consulta2linq()
        {
            string[] palabras = { "Andres", "Edison", "Mariana", "Tatiana", "Josefa", "Pablo", "Natalia", "Monica", "Ricardo", "Ruben", "Edison" };
                    var consulta = from p in palabras
                        orderby p ascending
                        group p by p.Length   into GrupoPorLongitud
                        orderby  GrupoPorLongitud.Key descending
                        select new { length =GrupoPorLongitud.Key, palabras=GrupoPorLongitud };
                   
                        foreach( var grupo in consulta)
                        {
                            string mensaje = string.Format("palabra con lonigtud{0}", grupo.length);
                                listBox1.Items.Add(mensaje);
                            foreach (var palabra in grupo.palabras)
                            {
                                listBox1.Items.Add(" " + palabras.ToString());
                            }

                        }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;  //activar el arraylist

namespace CodigoBaseCsharp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        #region Constructores
        private void button1_Click(object sender, EventArgs e)
        {
            //forma de llamar  al constructor// Constructor objConstructor = new Constructor();
            // label1.Text = Convert.ToString(objcons.precio);

            Constructor objConstructor = new Constructor("Hola", 545);
            label1.Text = objConstructor.nombre;
            label2.Text = objConstructor.precio.ToString();

   
            
        }
        #endregion
        #region Arreglos
        private void button2_Click(object sender, EventArgs e)
        {
            Arreglos objArreglos = new Arreglos();
            LstBox_Pantalla.Items.Add(objArreglos.arrayEjemplo[1]="Andres");
            LstBox_Pantalla.Items.Add(objArreglos.arrayEjemplo2[0]=206);
            LstBox_Pantalla.Items.Add(objArreglos.arrayEjemplo3[2]);
            LstBox_Pantalla.Items.Add(objArreglos.arrayEjemplo3[1]);
            LstBox_Pantalla.Items.Add(objArreglos.arrayEjemplo4[3]);
        }
        #endregion
        #region Arreglosmultidimencionalesyrecorrido
        private void button3_Click(object sender, EventArgs e)
        {
            ArreglosMultidimensionalesYrecorrido objarregloMulti = new ArreglosMultidimensionalesYrecorrido(); //desde la clase
            LstBox_Pantalla.Items.Add(objarregloMulti.arrayMulti[0,0]);
            int aux = objarregloMulti.arrayMulti2[0, 0];
            for (int i = 0; i < objarregloMulti.arrayMulti2.Length; i++)
            {
                LstBox_Pantalla.Items.Add(objarregloMulti.arrayMulti2[0, 0] + i);
            }

            string[] arrayEjemplo = new String[3];          //recorrido de arreglos sin clase
            arrayEjemplo[0] = "a";
            arrayEjemplo[1] = "b";
            arrayEjemplo[2] = "c";
            for (int i = 0; i < arrayEjemplo.Length; i++)
            {
                LstBox_Pantalla.Items.Add(arrayEjemplo[i]);
            }
                      
            //arreglo multidimensional sin clase
            string[,] arregloMulti = { { "perro", "gato", "canario" }, { "ave", "hormiga", "avestruz" } };
            for (int i = 0; i < arregloMulti.GetLength(0); i++)  //recorre el primer arreglo
            {
                for (int j = 0; j < arregloMulti.GetLength(1); j++) //recorre el segundo arreglo i filas j columnas
                {
                    LstBox_Pantalla.Items.Add(arregloMulti[i, j]);
                }
            }

        #endregion
        }
        #region Metodos
        private void button4_Click(object sender, EventArgs e)
        {
           LstBox_Pantalla.Items.Add( Suma(5, 5));
           LstBox_Pantalla.Items.Add(multiplicacion(2,2));
          
        }
        //sintaxis modificador de  accesso<static> |<tipodatoretorno>|<nombredelmetodo>|<parametros>
        public static int Suma(int a, int b)//con static no creo instancia de la clase
        {
            return a + b;
        }
        public int multiplicacion(int c,int d)
        {
            //Suma(5,3) si quisiera llamar al metodo suma lo prodira hacer pero no viceversa
            return c * d;
        }
        #endregion
        #region SobrecargadeMetodos
        private void button5_Click(object sender, EventArgs e)
        {
           int varAux=Resta(10,2); //puedo llamra a cualquiera de los metodos
           LstBox_Pantalla.Items.Add(varAux);
            LstBox_Pantalla.Items.Add(Resta(10,2,2));
        }
        public static int Resta(int e, int f)
        {
            return e - f;
        }
        public static int Resta(int e, int f, int g)
        {
            return e - f - g;
        }
        #endregion
        #region SobreCargaConstructores
        private void button6_Click(object sender, EventArgs e)
        {
            SobrecargaConstructores_Persona objSobreCargaCons = new SobrecargaConstructores_Persona();
            LstBox_Pantalla.Items.Add(objSobreCargaCons.edad);
            LstBox_Pantalla.Items.Add(objSobreCargaCons.nombre);
        }
        #endregion
        #region Enumeraciones
        private void button7_Click(object sender, EventArgs e)
        {
            //int x = (int)dias.Domingo;              //primera Conversion de Enum
            //listBox1.Items.Add(dias.Jueves);  //primera Convesion de Enum
            
            Dias dia = (Dias)4;             //Segunda Conversion
            LstBox_Pantalla.Items.Add(dia);    //Segunda Conversion

        }
        public enum Dias   //Siempre por Fuera de la clase
        {
            Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo   //Inicia en 0

        }
  

        private void button8_Click(object sender, EventArgs e)
        {
            FormularioSwitch objformulario = new FormularioSwitch();      
            objformulario.Show(); 
        }
        #endregion
        #region Btn_Limpiar
        private void button9_Click(object sender, EventArgs e)
        {
            LstBox_Pantalla.Items.Clear();
        }
        #endregion
        #region DoWhile
        private void button10_Click(object sender, EventArgs e)
        {
            int y = 1;
            do //Evalua la condicion por lo menos una vez
            {
                LstBox_Pantalla.Items.Add(y);
                y++;
            } while (y >1 && y < 3); 
        }
        #endregion
        #region foreach
        private void button11_Click(object sender, EventArgs e)
        {
            //Repite un bloque de codigo por cada elemento de una matriz o un objeto de coleccion
            //No se debe de utilizar para cambiar  el contenido  de una coleccion ej:(eliminar un elemento de la lista)
            //arroja una excepcion
            //palabras clave  break,goto,return,throw,continue;
            int[] arreglo = { 1, 4, 8, 12 };
            foreach (int miVariable in arreglo)
            {
                if (miVariable==4)
                {
                    continue; //ignora el 4
                }
                LstBox_Pantalla.Items.Add(miVariable);
            }
        }
        #endregion
        #region Get-Set
        private void button12_Click(object sender, EventArgs e)
        {
            //ofrecen un mecanismo flexible para, escribir o calcular
            //los valores de campos privados
            //Son denominados campos de acceso
            //Tienen accesso a los datos con facilidad,flexibilidad y seguridad de los metodos
            //set-get: Es de lectura y escritura
            //set:solo escritura
            //get:Soo lectura
            ClassGET_SET objGET_SET = new ClassGET_SET();
     
            LstBox_Pantalla.Items.Add(objGET_SET.Nickname = "1");
           
        }
        #endregion
        #region try,catch,finally
        private void button13_Click(object sender, EventArgs e)
        {
            //Try: se ejecuta hasta que se produce una excepcion o hasta completarse correctamente
            //Catch: atrapa la excepcion
            //Try-finally: se ejecuta a si no haya una excepcion;
            int[] arregloTry = { 1, 2, 3 };
            try
            {
                int x = arregloTry[3]; //esta fuera de la matriz
            }
            catch (IndexOutOfRangeException error)          //agregar + catch si se necesita mas excepciones
            {
                MessageBox.Show(error.Message);
            }
            finally 
            {
                LstBox_Pantalla.Items.Add("Se ejecuto el bloque Finally"); //sigque adelante no importa la excepcion y que no exista
            }
        }
        #endregion
        #region Herencia
        private void button14_Click(object sender, EventArgs e)
        {
            //Herencia
            //Permite generar una jerarquia de clase relacionadas
            //Reutilizar la funcionalidad definidad en las clases existentes
            //Extender otras Clases
            //Adoptar el comportamiento de la clase base
            //Modificadores
            //Abstract: Solo se podra utilizar como clase base de otras clases
            //Override: Nueva implementacion de un  miembro heredado de la clase base
            //Virtual: Puede cambiar su implementacion dentro de la clase derivada
            //New: Ocultar un miembro heredado de la clase base
            var cuadrado = new Cuadrado_tclases(4.0);
            cuadrado.Dibujar();
            LstBox_Pantalla.Items.Add("Area del cuadrado"+cuadrado.Area());

            var circulo = new Circulo_tclases(2.5);
            circulo.Dibujar();
            LstBox_Pantalla.Items.Add("Area del circulo:"+circulo.Area());
        }
        #endregion
        #region Estructuras
        private void button15_Click(object sender, EventArgs e)
        {
            //estructuras
            //Las estructuras son tipos de valor,mientras que las clases son tipos de referencia
            //A diferencia de la clases, se puenden crear instancias de  las  estructuras sin utilizar el operador new
            //Las estructuras pueden declarar constructoras,pero deben utilizar parametros
            //Una estructura no puede heredar de otra estructura o clase,ni puede ser la base de una clase.
            //Todas las estructuras heredan directamente de System.ValueType, que hereda de System.Object.
            //Una estructura puede implementar interfaces.

            Vector3d_estructuras vector; // se instancia la estructura asi sin el new
            vector.x = 10;
            vector.y = 20;
            vector.z = 30;
            var persona = new Persona_estructuras();
            persona.Nombre = "Andres";
           
            ModificarVector(vector);        //Metodos que modifican
            ModificarPersona(persona);

            LstBox_Pantalla.Items.Add("el valor de X:"+vector.x+" "+"El valor de Y:"+" "+ vector.y+" "+"El valor de Z:"+" "+ vector.z);
            LstBox_Pantalla.Items.Add("El nombre es:"+persona.Nombre); //reemplazo andres por pedro
        }
        static void ModificarPersona(Persona_estructuras persona) //estructuras son de tipo valor se crea una copia de las variables
        {                                                                                        //por eso modifica.
                                                                                                    
            persona.Nombre = "Pedro";                                       //valor por referencia al estado en memoria.
        }
        static void ModificarVector(Vector3d_estructuras vector)
        {
            vector.x = 0;
            vector.y = 0;
            vector.z = 0;
        }
        #endregion
        #region Polimorfismo
        private void btnPolimorfismo_Click(object sender, EventArgs e)
        {
            Polimorfismo objPolimorfismo = new Polimorfismo();

            LstBox_Pantalla.Items.Add("Primer Mensaje"+objPolimorfismo.miVehiculo("Negro","4","4"));
            LstBox_Pantalla.Items.Add( "Mensaje es:"+ objPolimorfismo.miVehiculo());
                 
        }
        #endregion
        #region GenericList
        private void btnGenericList_Click(object sender, EventArgs e)
        {
            ///ArrayList inventario = new ArrayList();
            //List<Vehiculos> inventario = new List<Vehiculos>();
            List<Productos_GenericList> inventario = new List<Productos_GenericList>();
            
            Vehiculos_GenericList v1 = new Vehiculos_GenericList();
            v1.marca = "Toyota";
            v1.modelo = "Corola";
            v1.fechaDeFabricacion = 2009;

            Vehiculos_GenericList v2 = new Vehiculos_GenericList();
            v2.marca = "Pegueot";
            v2.modelo = "306";
            v2.fechaDeFabricacion = 2005;

            Vehiculos_GenericList v3 = new Vehiculos_GenericList();
            v2.marca = "Mazda";
            v2.modelo = "Asahi";
            v2.fechaDeFabricacion = 2000;

            Peliculas_GenericList peli = new Peliculas_GenericList();
            peli.Nombre = "Andres";
            peli.Protagonista = "Larisa";
            peli.Genero = "drama-comedia";

            inventario.Add(v1);
            inventario.Add(v2);
            inventario.Add(peli);
            LstBox_Pantalla.Items.Add("Cantidad de vehiculos Disponible");
            foreach (Productos_GenericList producto in inventario)
            {
                LstBox_Pantalla.Items.Add(producto.reporte());
            }



        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       



    }
    }



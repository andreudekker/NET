using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baseCsharp
{
    class MiClase
    {
        #region Constructor
        public string nombre; //variable a nivel clase
       public int precio;

        public MiClase()
        {
            precio = 200;
        }

        public MiClase(string nombre, int precio) // esto es  un constructor con sus variables a nivel constructor
        {
            this.nombre = nombre;  //this distingue la variable a nivel clase
            this.precio =precio;
        }
        #endregion     
        #region Arreglos
        //Array
        public string[] arrayEjemplo = new String[4];
        public int[] arrayEjemplo2 = new int[9]; // el array empieza en 0
        public double[] arrayEjemplo3 = new double[] {2.5,3.6,3.9};
        public int[] arrayEjemplo4 = { 100, 200, 300, 500 };
        #endregion
        #region arraysMultidimensionales
        //arraysMultidimensionales
        public int[,]arrayMulti=  new int[2,3];
        public int[,] arrayMulti2 = { { 1, 2, 3 }, { 4, 5, 6 } };//array2*2
        #endregion




    }
}

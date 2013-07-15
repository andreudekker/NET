using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;// para el stream

namespace CodigoCSharp
{
    class Program
    {

        public enum modoEntrada
        {
            Guardar=1,
            Cancelar=2
        }
        
        
        static void Main(string[] args)
        {
            string strMensaje = "Texto de prueba .Net";
            Console.WriteLine(strMensaje);
            string strprefijo = new string('-', strMensaje.Length);
            Console.WriteLine(strprefijo);
            Console.WriteLine();
            Console.Write("Nombre:");
            string strNombre = Console.ReadLine();
            Console.Write("Correo:");
            string strCorreo = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Opciones: Grabar[1] Cancelar[2]");
            int opcion = int.Parse(Console.ReadLine());
           modoEntrada me =(modoEntrada)opcion;
            switch (me)
	        {
		        case modoEntrada.Guardar:

                    //Cliente cliente = new Cliente(strNombre, strCorreo);  //instanciado de la clase   // pertencealaclaseCliente
                    //cliente.Guardar();
                    //Console.Write(cliente.ObtenerMensaje());
                    Empleado emp = new Empleado(strNombre, strCorreo, 2.000000);
                    emp.Guardar();
                    Console.Write(emp.ObtenerMensaje());

                    #region Desdelaconsolafuncionasinlaclaseactivar
                    //Guardar(strNombre,strCorreo);
                   //Console.WriteLine(string.Format("El cliente:{0} y  su correo es:{1} fue registrado satisfactoriamente",strNombre,strCorreo));
#endregion
                   break;
                case modoEntrada.Cancelar:
                    break;
                    default:
                    break;
	        }
            
            
            Console.ReadLine();

        }
        #region guardar
        //private static void Guardar(string nombre,string correo)
//{
//    FileStream fs= new FileStream("..\\Clientes.txt", FileMode.Append);
//    StreamWriter sw= new StreamWriter(fs);
//    sw.WriteLine(nombre+"\t"+correo);
//    sw.Close();
//    fs.Close();
        //}
        #endregion
    }
}


#region Declaracion de una clase
public class Cliente
{
    public string Nombre { get; set; } //get lerr set acceder
    public string Correo { get; set; }

    public Cliente(string nombre, string correo)
    {
        Nombre = nombre;
        Correo = correo;
    }

    public void Guardar()
    {
        FileStream fs = new FileStream("..\\Clientes.txt", FileMode.Append);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine(Nombre + "\t" + Correo);
        sw.Close();
        fs.Close();
    }

    public virtual string ObtenerMensaje()      //paso para cambiar obtener mensaje en la clase
    {
        return string.Format("El cliente:{0} y  su correo es:{1} fue registrado satisfactoriamente", Nombre, Correo);
    }
}
#endregion

public class Empleado : Cliente
{
    public double Sueldo { get; set; }
    public Empleado(string nombre, string correo, double sueldo)
        : base(nombre, correo)   //llama a la clasePadre
       
    {

        Sueldo = sueldo;
    }
    public override string ObtenerMensaje() // sobreescriboelmetodo
    {
        return string.Format("El Empleado:{0} y  su correo es:{1} fue registrado satisfactoriamente", Nombre, Correo);
    }

}
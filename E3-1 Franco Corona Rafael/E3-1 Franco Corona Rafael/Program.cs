using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1_Franco_Corona_Rafael
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero de clases: ");
            int n_clases = int.Parse(Console.ReadLine());//Ingreso de numero de clases.
            Universidad universidad = new Universidad(n_clases);//Creacion de un objeto para mandar a llamar metodos de la clase "Universidad" y mandar el valor de n_clases.
            universidad.Captura();//Llamada del metodo "Captura" desde la clase Universidad.
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3___Franco_Corona_Rafael
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            Console.Write("A que ejercicio desea acceder: " +
                "\n1.- Ejercicio1" +
                "\n2.- Ejercicio2" +
                "\n3.- Ejercicio3" +
                "\n4.- Ejercicio4" +
                "\nIngrese opción: ");
            int opc = int.Parse(Console.ReadLine());
            Console.Clear();
            switch(opc)
            {
                case 1:
                    operaciones.Ejercicio1();
                    break;
                case 2:
                    operaciones.Ejercicio2();
                    break;
                case 3:
                    operaciones.Ejercicio3();
                    break;
                case 4:
                    operaciones.Ejercicio4();
                    break;
            }
            Console.ReadKey();
        }
    }
}

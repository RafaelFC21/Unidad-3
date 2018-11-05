using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacas
{
    class Operaciones
    {
        Stack<string> Vaca = new Stack<string>();//Creación de las pilas para el nombre de las vacas y el tiempo.
        Stack<int> Tiempo = new Stack<int>();
        public Operaciones()
        {
            Vaca.Push("Mazie");//Ingresando nombre de las vacas en la pila.
            Vaca.Push("Daisy");
            Vaca.Push("Crazy");
            Vaca.Push("Lazy");
            Tiempo.Push(2);//Ingresando tiempo de las vacas en la pila.
            Tiempo.Push(4);
            Tiempo.Push(10);
            Tiempo.Push(20);
        }
        public void Cruzar()
        {
            Console.WriteLine("Bob cruza con {0} y {1} la primera vez por el puente", Vaca.ToArray().ElementAt(3), Vaca.ToArray().ElementAt(2));
            int Tiempo1 = Tiempo.ElementAt(2);//Tiempo de la vaca más lenta.
            Console.WriteLine("Tiempo 1: " + Tiempo1);
            Console.WriteLine("Bob regresa con la vaca {0} para llevar el yugo de regreso", Vaca.ToArray().ElementAt(3));
            int Tiempo2 = Tiempo.ElementAt(3);//Tiempo de la vaca sola
            Console.WriteLine("Tiempo 2: " + Tiempo2);
            Console.WriteLine("Bob ata el yugo a {0} y a {1} para cruzar de nuevo", Vaca.ToArray().ElementAt(1), Vaca.ToArray().ElementAt(0));
            int Tiempo3 = Tiempo.ElementAt(0);//Tiempo de la vaca más lenta
            Console.WriteLine("Tiempo 3: " + Tiempo3);
            Console.WriteLine("Bob regresa con la vaca {0} para llevar el yugo de regreso", Vaca.ToArray().ElementAt(2));
            int Tiempo4 = Tiempo.ElementAt(2);//Tiempo de la vaca sola
            Console.WriteLine("Tiempo 4: " + Tiempo4);
            Console.WriteLine("Bob cruza con {0} y {1} por segunda y ultima vez el puente.", Vaca.ToArray().ElementAt(3), Vaca.ToArray().ElementAt(2));
            int Tiempo5 = Tiempo.ElementAt(2);//Tiempo de la vaca más lenta
            Console.WriteLine("Tiempo 5: " + Tiempo5);
            Console.WriteLine("El tiempo que tarda cada una es el siguiente:" +
                "\nMezie tarda 2 minutos" +
                "\nDaisy tarda 4 minutos" +
                "\nCrazy tarda 10 minutos" +
                "\nLazy tarda 20 minutos" +
                "\nPero al momento de estar 2 atadas estas toman el tiempo de la que más tarda.");
            int TiempoTotal = Tiempo1 + Tiempo2 + Tiempo3 + Tiempo4 + Tiempo5;//Suma de los tiempos de las vacas más lentas para asegurar que estas cruzaron en 34 minutos.
            Console.WriteLine("El tiempo que tardaron en cruzar todas las vacas fue: " + TiempoTotal);
            Console.ReadKey();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3_2_FrancoCoronaRafael
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0;
            do
            {
                try
                {
                    int value = 0;
                    int num_value;
                    int search;
                    string opc;
                    Console.Write("¿Qué desea observar?" +
                        "\n1.- Pilas" +
                        "\n2.- Colas" +
                        "\nIngrese opción: ");
                    opc = (Console.ReadLine());//Ingresas opción del menú...
                    Console.Clear();
                    switch (opc)
                    {
                        case "1":
                            Stack pila = new Stack(); // Creamos la pila.
                            Console.Write("Ingrese valores:"); //Ingresamos numero de valores que meteremos en la pila.
                            num_value = int.Parse(Console.ReadLine());
                            for (int contador = 0; contador < num_value; contador++)  //Se utiliza un for para ingresar valores.
                            {
                                Console.Write("Ingrese el valor {0}: ", contador + 1);
                                value = int.Parse(Console.ReadLine());
                                pila.Push(value); //Se ingresan los valores en la pila.
                            }

                            Console.Write("Que valor desea encontrar: ");
                            search = int.Parse(Console.ReadLine());
                            Console.WriteLine("¿Se a encontrado el valor buscado?: {0}", pila.Contains(search)); //El metodo "Contains" es utilizado para verificar si un elemento esta en la pila.
                            Console.WriteLine("La pila contiene {0} elementos", pila.Count);//"Count" es utilizado para ver cuantos valores tiene la pila.
                            foreach (var item in pila)
                            {
                                Console.WriteLine("{0} que es una variable tipo {1}", item, item.GetType()); //El metodo "GetType" es utilizado para desplegar que tipo de valor es el almacenado en la pila.
                            }
                            IEnumerator move = pila.GetEnumerator(); //El metodo "GetEnumerator" es utilizado para crear un enumerador que recorre la pila.
                            move.MoveNext();
                            move.MoveNext();
                            Console.WriteLine("La posición del enumerador se recorre 2 veces dando como resultado {0} ", move.Current); //La propiedad "Current" se utiliza para ver en que posición quedo el enumerator.
                            object[] arrayPila = pila.ToArray(); //Transformación de pila(Stack) a arreglo (Array) utilizando el metodo "ToArray".
                            Console.WriteLine("La pila se ha transformado a Array: ");
                            foreach (int i in arrayPila)
                            {
                                Console.Write(i + " ");
                            }
                            Console.WriteLine("\nLos datos de la pila son cambiados a string.");
                            foreach (var item in pila)
                            {
                                Console.WriteLine("{0} ahora es variable tipo {1}", item, item.ToString().GetType());//El metodo "ToString" convierte las variables de la pila en tipo string.
                            }
                            Console.WriteLine("El elemento mas viejo es {0}.", pila.Peek()); //El metodo "Peek" devuelve el elemento mas viejo.
                            pila.Pop(); //El metodo "Pop" elimina el último elemento que introducido.

                            Console.WriteLine("Pila sin el ultimo numero:");
                            foreach (var item in pila)
                            {
                                Console.WriteLine(item); //Se imprime los valores de la pila sin el ultimo valor ingresado.
                            }
                            Console.ReadKey();
                            break;
                        case "2":
                            Queue cola = new Queue();
                            Console.Write("Ingrese valores:"); //Ingresamos numero de valores que meteremos en la cola.
                            num_value = int.Parse(Console.ReadLine());
                            for (int contador = 0; contador < num_value; contador++)  //Se utiliza un for para ingresar valores.
                            {
                                Console.Write("Ingrese el valor {0}: ", contador + 1);
                                cola.Enqueue(value = int.Parse(Console.ReadLine())); //Se ingresan los valores en la cola.
                            }
                            cola.TrimToSize(); //El metodo "TrimToSize" se utiliza para delimitar la cola con la cantidad de valores introducidos a este momento.
                            Console.Write("Que valor desea encontrar: ");
                            search = int.Parse(Console.ReadLine());
                            Console.WriteLine("¿Se a encontrado el valor buscado?: {0}", cola.Contains(search)); //El metodo "Contains" es utilizado para verificar si un elemento esta en la cola.
                            Console.WriteLine("La pila contiene {0} elementos", cola.Count);//"Count" es utilizado para ver cuantos valores tiene la cola.
                            foreach (var item in cola)
                            {
                                Console.WriteLine("{0} que es una variable tipo {1}", item, item.GetType()); //El metodo "GetType" es utilizado para desplegar que tipo de valor es el almacenado en la cola.
                            }
                            IEnumerator moving = cola.GetEnumerator(); //El metodo "GetEnumerator" es utilizado para crear un enumerador que recorre la cola.
                            moving.MoveNext();
                            moving.MoveNext();
                            Console.WriteLine("La posición del enumerador se recorre 2 veces dando como resultado {0} ", moving.Current); //La propiedad "Current" se utiliza para ver en que posición quedo el enumerator.

                            object[] arrayCola = cola.ToArray(); //Transformación de cola(Queue) a arreglo (Array) utilizando el metodo "ToArray".

                            Console.WriteLine("La pila se ha transformado a Array: ");
                            foreach (int i in arrayCola)
                            {
                                Console.Write(i + " ");
                            }
                            Console.WriteLine("\nLos datos de la pila son cambiados a string.");
                            foreach (var item in cola)
                            {
                                Console.WriteLine("{0} ahora es variable tipo {1}", item, item.ToString().GetType());//El metodo "ToString" convierte las variables de la cola en tipo string.
                            }
                            Console.WriteLine("El elemento mas viejo es {0}.", cola.Peek()); //El metodo "Peek" devuelve el elemento mas viejo.
                            cola.Dequeue(); //El metodo "Dequeue" elimina el último elemento que introducido.
                            Console.WriteLine("Pila sin el ultimo numero:");
                            foreach (var item in cola)
                            {
                                Console.WriteLine(item); //Se imprime los valores de la cola sin el ultimo valor ingresado.
                            }
                            Console.ReadKey();
                            break;
                    }
                    Console.Clear();
                    Console.Write("¿Desea volverlo a intentar?" +
                        "\n1.- Si" +
                        "\nCualquier otro numero.- No" +
                        "\nIngrese opción: ");
                    opcion = int.Parse(Console.ReadLine());//Se ingresa opción para saber si quieres continuar o no.
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
            }
            while (opcion==1);
        }
    }
}
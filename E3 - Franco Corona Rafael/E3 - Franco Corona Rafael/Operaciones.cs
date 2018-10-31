using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3___Franco_Corona_Rafael
{
    class Operaciones
    {
            Stack Pila = new Stack();
            Queue Cola = new Queue();

        public void Ejercicio1()
        {
            Pila.Push(5);
            Pila.Push(3);
            Pila.Pop();
            Pila.Push(2);
            Pila.Push(8);
            Pila.Pop();
            Pila.Pop();
            Pila.Push(7);
            Pila.Push(6);
            Pila.Pop();
            Pila.Push(4);
            Pila.Pop();
            Pila.Pop();
            foreach (var item in Pila)
            {
                Console.WriteLine(item);
            }
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ? 5...
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
        }

        public void Ejercicio2()
        {
            LinkedList<string> Lista = new LinkedList<string>();
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
            int cantidad = 0;
            Console.Write("Numero de palabras a ingresar: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            List<string> valores = new List<string>();
            LinkedList<string> reservadas = new LinkedList<string>();
            LinkedList<string> Id_Literal = new LinkedList<string>();
            for (int contador = 0; contador < cantidad; contador++)
            {
                Console.WriteLine("Ingrese la palabra: ");
                valores.Add(Console.ReadLine());
            }
            string[] val_KeyWord = new string[107] {"continue",  "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit",
                                                "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null",
                                                "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit",
                                                "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref",
                                                "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch",
                                                "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort",
                                                "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked","class", "const",
                                                "using", "using", "static", "virtual", "void", "volatile", "while", "add", "alias", "ascending", "async",
                                                "nameof", "on", "orderby", "partial", "remove", "select", "set", "value", "var", "when", "where", "yield",
                                                "await", "by", "descending", "dynamic", "equals", "from", "get", "global", "groupo", "into", "join", "let"};
            List<string> palabras = new List<string>();
            foreach (var item in val_KeyWord)
            {
                palabras.Add(item);
            }
            Console.WriteLine("");
            Console.WriteLine("Las siguientes palabras son clave: ");
            foreach (var item in valores)
            {
                Id_Literal.AddLast(item);
                foreach (var item2 in val_KeyWord)
                {
                    if (item == item2)
                    {
                        Console.WriteLine(item2);
                        Id_Literal.Remove(item);
                        reservadas.AddLast(item2);
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Identificadores y literales: ");
            foreach (var item in Id_Literal)
            {
                Console.WriteLine(item);
            }
        }

        public void Ejercicio3()
        {
            LinkedList<int> ListaLigada = new LinkedList<int>();
            List<int> Lista = new List<int>();
            for (int contador = 0; contador < 9876; contador++)
            {
                Lista.Add(contador);
                ListaLigada.AddLast(contador);
            }
            var tiempo = Stopwatch.StartNew();
            foreach (var item in Lista)
                {
                    Console.Write(item + ", ");
                }
            tiempo.Stop();
            Console.WriteLine("");
            var tiempo2 = Stopwatch.StartNew();
            foreach (var item in ListaLigada)
                {
                    Console.Write(item + ", ");
                }
            tiempo2.Stop();
            Console.WriteLine("");
            Console.WriteLine("Tiempo Lista"+((double)(tiempo.Elapsed.TotalMilliseconds)).ToString("0.00 milisegundos"));
            Console.WriteLine("Tiempo Lista ligada" + ((double)(tiempo2.Elapsed.TotalMilliseconds)).ToString("0.00 milisegundos"));
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
        }
        public void Ejercicio4()
        {
            ClaseOpciones claseOpciones = new ClaseOpciones();
            claseOpciones.Agregar();
            claseOpciones.Media();
            claseOpciones.CalifAlta();
            claseOpciones.CalifBaja();
            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
        }
    }
}

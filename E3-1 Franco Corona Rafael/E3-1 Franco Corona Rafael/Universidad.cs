using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1_Franco_Corona_Rafael
{
    class Universidad
    {
        int n_clases;
        int n_alumnos;
        public Universidad(int n_clases)
        {
            this.n_clases = n_clases;
        }
        public void Captura()
        {
            ArrayList clases = new ArrayList();//Creacion de una lista.
            for (int contador1 = 0; n_clases > contador1; contador1++)//Implementacion de un for para el ingreso de los datos.
            {
                Console.Write("Ingrese nombre de la clase {0}: ", contador1 + 1);
                clases.Add(Console.ReadLine());//Agrega nombre de clases a la lista.
                Console.Clear();
                Console.Write("Ingrese numero de alumnos de la clase {0}: ", contador1 + 1);
                n_alumnos = int.Parse(Console.ReadLine());//Se ingresa el valor del número de alumnos para el uso del siguiente for. 
                Console.Clear();
                for (int contador2 = 0; n_alumnos > contador2; contador2++)
                {
                    Console.Write("Ingrese calificacion del alumno {0}: ", contador2 + 1);
                    clases.Add(Console.ReadLine());//Se agrega el valor de la calificación a la lista.
                    Console.Clear();
                }
            }
            foreach (var valor in clases)//Implementación de un foreach para que cada vez que aumente valor en el limite de clases se impriman los valores almacenados en la lista.
            {
                Console.WriteLine(valor);//Impresión de nombre de la clase y calificaciones en el orden ingresado por alumno.
            }
        }
    }
}

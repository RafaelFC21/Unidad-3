using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3___Franco_Corona_Rafael
{
    class ClaseOpciones
    {
        List<Clase> alumno = new List<Clase>();
        List<Clase> maestro = new List<Clase>();
        Clase clase;
        public void Agregar()
        {
            for (int contador = 0; contador < 1; contador++)
            {
                clase = new Clase();
                Console.Write("Ingrese nombre de la clase: ");
                clase.NombreClase = Console.ReadLine();
                Console.Clear();
                Console.Write("Ingrese nombre del maestro: ");
                clase.Maestro = Console.ReadLine();
                Console.Clear();
                maestro.Add(clase);
            }
            for (int contador = 0; contador < 30; contador++)
            {
                clase = new Clase();
                Console.Write("Ingrese nombre del Alumno: ");
                clase.Alumno = Console.ReadLine();
                Console.Clear();
                Console.Write("Ingrese calificiación del alumno: ");
                clase.Calificacion = int.Parse(Console.ReadLine());
                Console.Clear();
                alumno.Add(clase);
            }
            foreach (var item in maestro)
            {
                Console.WriteLine("Clase: " + item.NombreClase);
                Console.WriteLine("Maestro: " + item.Maestro);
            }
            foreach (var item in alumno)
            {
                Console.WriteLine("Alumno: " + item.Alumno);
                Console.WriteLine("Calificación: " + item.Calificacion);
            }
        }
        public void Media()
        {
            int calif = 0;
            int media = 0;
            foreach (var item in alumno)
            {
                calif = item.Calificacion + calif;
            }
            media = calif / 30;
            Console.WriteLine("La media es: " + media);
        }
        public void CalifAlta()
        {
            int maximo = 0;
            foreach (var item in alumno)
            {
                maximo = alumno.Max(x =>x.Calificacion);
            }
            Console.WriteLine("La calificacion mas alta es: " + maximo);
        }
        public void CalifBaja()
        {
            int minimo = 0;
            foreach (var item in alumno)
            {
                minimo = alumno.Min(x => x.Calificacion);
            }
            Console.WriteLine("La calificacion mas baja es: " + minimo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Torres torres = new Torres();//Creación del objeto que llama al metodo de otra clase.
            torres.Juego();
        }
    }
}
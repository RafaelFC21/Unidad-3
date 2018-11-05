using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacas
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();//Creación del objeto que llama al metodo de otra clase.
            operaciones.Cruzar();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Torres
    {
        int cont;
        Stack TorreA = new Stack();//Se crean las pilas de cada torre.
        Stack TorreB = new Stack();
        Stack TorreC = new Stack();
        public void Juego()//Metodo interactivo con el usuario.
        {
            Console.WriteLine("Introdusca numero de discos");
            int discos = Int16.Parse(Console.ReadLine());//Ingresas el numero de discos con los que quieres "jugar".
            cont = 0;
            Agregar(discos);//Llama al metodo Agregar
            MoverTorre(discos, 'A', 'B', 'C');//Llama al metodo MoverTorre
            Console.WriteLine("\nNúmero de Discos: " + discos);//Despliega resultados
            Console.WriteLine("\nNúmero de Movimientos: " + cont);
            Console.ReadKey();
        }
        public void Agregar(int discos)
        {
            for (int contador = 1; contador <= discos; contador++)
            {
                TorreA.Push(contador);//Agrega todos los discos quese pidieron a la torre A.
            }
        }
        private void MoverDisco(char inicio, char fin)
        {
            cont++;
            if (inicio == 'A' && fin == 'B')
            {
                Console.WriteLine("Mover disco " + TorreA.Peek() + inicio + " " + fin); //Se muestra el disco que se movio de A a B
                TorreB.Push(TorreA.Pop());//El disco se agrega a B y se elimina de A
            }
            else if (inicio == 'A' && fin == 'C')
            {
                Console.WriteLine("Mover disco " + TorreA.Peek() + inicio + " " + fin); //Se muestra el disco que se movio de A a C
                TorreC.Push(TorreA.Pop());//El disco se agrega a C y se elimina de A
            }
            else if (inicio == 'B' && fin == 'A')
            {
                Console.WriteLine("Mover disco " + TorreB.Peek() + inicio + " " + fin); //Se muestra el disco que se movio de B a A
                TorreA.Push(TorreB.Pop());//El disco se agrega a A y se elimina de B
            }
            else if (inicio == 'B' && fin == 'C')
            {
                Console.WriteLine("Mover disco " + TorreB.Peek() + inicio + " " + fin); //Se muestra el disco que se movio de B a C
                TorreC.Push(TorreB.Pop());//El disco se agrega a C y se elimina de B
            }
            else if (inicio == 'C' && fin == 'A')
            {
                Console.WriteLine("Mover disco " + TorreC.Peek() + inicio + " " + fin); //Se muestra el disco que se movio de C a A
                TorreA.Push(TorreC.Pop());//El disco se agrega a A y se elimina de C
            }
            else
            {
                Console.WriteLine("Mover disco " + TorreC.Peek() + inicio + " " + fin); //Se muestra el disco que se movio de C a B
                TorreB.Push(TorreC.Pop());//El disco se agrega a B y se elimina de C
            }
        }
        private void MoverTorre(int discos, char inicio, char fin, char temp)//Inicio hace referencia a donde empiezan los discos, fin a donde deberian quedar y temp es el lugar temporal en el que puede quedar uno de los discos.
        {
            if (discos == 1)//Si el numero de discos es igual a 1 se vuelve a llamar a la el metodo MoverDisco
            {
                MoverDisco(inicio, fin);
            }
            else//En otro caso 
            {
                MoverTorre(discos - 1, inicio, temp, fin); //El metodo se llama a si mismo pero con 1 disco menos quitandola de la torre de origen.
                MoverDisco(inicio, fin);//El metodo llama a el metodo mover disco.
                MoverTorre(discos - 1, temp, fin, inicio);//El metodo se vuelve a llamar a si mismo pero el disco se retira del destino del anterior.
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    class Operaciones
    {
        int suma = 0;
        int suma2 = 0;
        int opc = 0;
        int opc2 = 0;
        int opcAs = 0;//Se inicializan variables.
        Random rnd = new Random();//Se establece un random para barajear.
        List<Deck> Lista = new List<Deck>();//Se crea una list.
        List<Deck> hand = new List<Deck>();//Se crea otra lista para establecer los elementos de la mano.
        Stack decks = new Stack();// Se crea una pila para tener almacenados todos los elementos de la baraja.
        public void Fill()//Se crea un metodo llamado "fill" que en si es como se llena la baraja.
        {
            Deck carta;
            char[] figuras = new char[4] { '♥', '♦', '♣', '♠' };//Se crea un vector donde se almacenen las figuras.
            char[] letras = new char[4] { 'A', 'J', 'Q', 'K' };//Se crea un vector donde se almacenen las letras.
            for (int contador1 = 0; contador1 < 4; contador1++)//Utilizamos un for para las figuras.
            {
                for (int contador2 = 1; contador2 < 14; contador2++)//Utlilizamos un for para el numero de cartas de cada figura.
                {
                    carta = new Deck();
                    if (contador2 == 1)//Se crea la condicion para sustituir el 1 por el A.
                    {
                        carta.Id = Convert.ToString(letras[contador2 - 1]) + Convert.ToString(figuras[contador1]);//Almacenamos valores en Id de la clase instanciada.
                        carta.Card_Value = contador2;//Se establece cuanto valdra la carta.
                        decks.Push(Convert.ToString(letras[contador2 - 1]) + Convert.ToString(figuras[contador1]));//Almacenamos valores en la pila.
                    }
                    else if (contador2 > 10)//Se crea la condicion de que los numeros mayores a 10 sean sustituidos por J, Q & K.
                    {
                        carta.Id = Convert.ToString(letras[contador2 - 10]) + Convert.ToString(figuras[contador1]);
                        carta.Card_Value = 10;
                        decks.Push(Convert.ToString(letras[contador2 - 10]) + Convert.ToString(figuras[contador1]));
                    }
                    else//Lo demas tendran los valores del contador.
                    {
                        carta.Id = Convert.ToString(contador2) + Convert.ToString(figuras[contador1]);
                        carta.Card_Value = contador2;
                        decks.Push(contador2 + Convert.ToString(figuras[contador1]));
                    }
                    Lista.Add(carta);//Se agregan los valores a la lista.
                }
            }
        }
        public void Final()//Metodo para ver si ganaste o perdiste.
        {
                if ((hand.Count == 5 && suma <= 21) || (hand.Count == 5 && suma2 <= 21))//si la mano tiene 5 cartas y la suma da igual a 21 o menos ganas.
                {
                    Console.WriteLine("Ganaste!");
                }
                else if (suma == 21 || suma2 == 21)//Si la suma es igual a 21 ganas.
                {
                    Console.WriteLine("Ganaste!");
                }
                else if (suma > 21 || suma2 > 21)//Si la suma pasa de 21 pierdes.
                {
                    Console.WriteLine("Game Over");
                }
        }
        public void Robar()//Se crea el metodo para robar las primeras 2 cartas.
        {
            var shuffle = rnd.Next(0, decks.Count);//Se inicializa la variable a la cual corresponde el random.
            var shuffle2 = rnd.Next(0, decks.Count);//Segunda variable del random.
            var first = Lista[shuffle];//Inicializo variables de cada random para asi poder reutilizar el numero.
            var second = Lista[shuffle2];
            hand.Add(first);//Agrego las cartas a la mano.
            Lista.Remove(first);//Remuevo las cartas del deck.
            hand.Add(second);
            Lista.Remove(second);
            foreach (var item in hand)//Por cada item en la mano se realizará lo siguiente.
            {
                Console.WriteLine(item.Id);//Se imprime la carta.
                if (item.Card_Value == 1)//Si alguna vez sale un As te dara la opción de cambiar de 1 a 11.
                {
                    As();
                    if (opcAs == 1)
                    {
                        item.Card_Value = 11;
                    }
                }
                suma = item.Card_Value + suma;//Suma de las cartas para ver si llegas a 21 o te pasas.
            }
            Final();
            Console.WriteLine("Suma:" + suma);//Impresion de la suma
            Console.Write("¿Desea robar otra carta?: " +
                "\n1.-Si" +
                "\n2.-No" +
                "\nIngrese una opción: ");//Preguntas si quieres obtener otra carta.
            opc = int.Parse(Console.ReadLine());
            Console.Clear();
            if (opc == 1)//Si elige que si entonces robaras otra.
            {
                Sig_Robo();
            }
        }
        public int As()//Metodo para comparar el As
        {
            Console.Write("Que valor desea darle al As" +
                "\n1. 11" +
                "\nCualquier otro numero. 1" +
                "\nIngrese una opción: ");
            opcAs = int.Parse(Console.ReadLine());
            Console.Clear();
            return opcAs;
        }
        public void Sig_Robo()//Metodo para robar la siguiente carta
        {
            var shuffle3 = rnd.Next(0, decks.Count);
            var next = Lista[shuffle3];
            hand.Add(next);//Tomas otra carta aleatoria.
            
            foreach (var item in hand)
            {
                Console.WriteLine(item.Id);
                if (item.Card_Value == 1)//Vuelves a hacer la condicion para ver si es que sale As puedas elegir entre 1 y 11
                {
                    As();
                    if (opcAs == 1)
                    {
                        item.Card_Value = 11;
                    }
                }
                suma2 = item.Card_Value + suma2;  
            }
            Lista.Remove(next);//La remueves del deck.
            Final();
            Console.WriteLine("Suma:" + suma2);
            Console.WriteLine("¿Desea robar otra carta?: " +
                "\n1.-Si" +
                "\nCualquier otro numero.-No" +
                "\nIngrese una opción: ");//Preguntas si quieres obtener otra carta.
            opc2 = int.Parse(Console.ReadLine());
            Console.Clear();
            while (opc2 == 1)//Si elige que si entonces robaras otra.
            {
                Sig_Robo();
            }
        }
    }
}
//El programa registro algunos problemas en la suma de las cartas...

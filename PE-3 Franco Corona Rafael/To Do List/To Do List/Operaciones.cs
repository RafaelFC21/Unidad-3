using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    class Operaciones
    {
        List<Tarea> Global = new List<Tarea>();//Se crean cada una de las listas 1 donde se muestran todas las tareas
        //y las demas para los estados de la tarea.
        List<Tarea> Pendientes = new List<Tarea>();
        List<Tarea> Proceso = new List<Tarea>();
        List<Tarea> Terminadas = new List<Tarea>();
        public void Agregar()//Metodo para agregar tareas
        {
            Tarea tarea;
            Console.Write("¿Cuantas tareas desea agregar?: ");
            int n_tarea = int.Parse(Console.ReadLine());//Estableces con cuantas tareas vas a trabajar.
            Console.Clear();
            for (int contador = 1; contador <= n_tarea; contador++)//El for ayuda a introducir los datos de cada una de las tareas en las listas.
            {
                tarea = new Tarea();
                tarea.ID = contador;
                Console.Write("Ingrese el nombre de la tarea: ");
                tarea.NombreTarea = Console.ReadLine();
                Console.Clear();
                Console.Write("Ingrese la descripción de la tarea: ");
                tarea.Descripcion = Console.ReadLine();
                Console.Clear();
                Console.Write("Ingrese fecha de inicio: ");
                tarea.FechaInicio = Console.ReadLine();
                Console.Clear();
                Console.Write("Ingrese fecha para finalizar: ");
                tarea.FechaFin = Console.ReadLine();
                Console.Clear();
                Global.Add(tarea);//Se agregan los datos a la lista global la cual no debe moverse.
                Pendientes.Add(tarea);//Se agregan los datos a la lista de pendientes con la cual se va a estar trabajando.
            }
            Console.Clear();
            Cambio_Estado();//Llamada del metodo Cambio_Estado.
            
        }
        public void Cambio_Estado()//Metodo para preguntar si quieres cambiar el estado de la tarea.
        {
            int opc = 0;
            Console.Write("El estado de todas las tareas esta en PENDIENTE." +
                "\n¿Desea cambiar el estado de alguna tarea?" +
                "\n1.-Si" +
                "\n2.-No" +
                "\nIngrese una opción: ");
            opc = int.Parse(Console.ReadLine());//Introduces una opción para saber si quieres salir o continuar.
            Console.Clear();
            if (opc == 1)//Si la opción es 1 el programa continuará
            {
                Opciones_Tarea();//Llamada del metodo Opciones_Tarea.
            }
            else//En otro caso este se saldra.
            {
                Environment.Exit(0);
            }
        }
        public void Opciones_Tarea()//Metodo para elgir el estado de la tarea.
        {
            int opc2 = 0;
            int opc3 = 0;
            int n_tarea = 0;
            foreach (var item in Global)//Impresión de los datos de cada tarea.
            {
                Console.WriteLine("Tareas Globales: " +
                    "\nID:" + item.ID +
                    "\nTarea:" + item.NombreTarea +
                    "\nDescripción: " + item.Descripcion +
                    "\n Fecha de Incio: " + item.FechaInicio +
                    "\n Fecha de entrega: " + item.FechaFin);
            }
            Console.WriteLine("¿Qué tarea busca?" +
                "\nIntrodusca ID de la tarea: ");
            n_tarea = int.Parse(Console.ReadLine());//Se introduce le ID o numero de tarea para desplegar una tarea especifica con la que se desea trabajar.
            Console.Clear();
            var select_Pendiente = (from buscar
                                in Pendientes
                                where n_tarea == buscar.ID
                                select buscar).ToList();//Busca la tarea dentro de las tareas pendientes.
            var select_Proceso = (from buscar
                                in Proceso
                          where n_tarea == buscar.ID
                          select buscar).ToList();//Busca la tarea dentro de las tareas en proceso.
            var select_Terminadas = (from buscar
                                in Terminadas
                          where n_tarea == buscar.ID
                          select buscar).ToList();//Busca la tarea dentro de las tareas terminadas.
            foreach (var item in select_Pendiente)//Despliega la tarea buscada con sus datos y su estado actual
            {
                Console.WriteLine("Tarea encontrada" +
                    "\nID:" + item.ID +
                    "\nTarea:" + item.NombreTarea +
                    "\nDescripción: " + item.Descripcion +
                    "\n Fecha de Incio: " + item.FechaInicio +
                    "\n Fecha de entrega: " + item.FechaFin +
                    "\nEstado: Pendiente");
            }
            foreach (var item in select_Proceso)//Despliega la tarea buscada con sus datos y su estado actual
            {
                Console.WriteLine("Tarea encontrada" +
                    "\nID:" + item.ID +
                    "\nTarea:" + item.NombreTarea +
                    "\nDescripción: " + item.Descripcion +
                    "\n Fecha de Incio: " + item.FechaInicio +
                    "\n Fecha de entrega: " + item.FechaFin +
                    "\nEstado: En proceso");
            }
            foreach (var item in select_Terminadas)//Despliega la tarea buscada con sus datos y su estado actual
            {
                Console.WriteLine("Tarea encontrada" +
                    "\nID:" + item.ID +
                    "\nTarea:" + item.NombreTarea +
                    "\nDescripción: " + item.Descripcion +
                    "\n Fecha de Incio: " + item.FechaInicio +
                    "\n Fecha de entrega: " + item.FechaFin + 
                    "\nEstado: Terminado");
            }            
            Console.Write("Como desea clasificar la tarea" +
                "\n1.- En proceso" +
                "\n2.- Terminadas" +
                "\nIngrese una opción: ");
            opc2 = int.Parse(Console.ReadLine());//Se introduce un numero para especificar el nuevo estado de la tarea...
            //No se puede cambiar de pendiente a terminado y viceversa.
            //No se puede cambiar de en proceso a pendiente.
            Console.Clear();
            switch(opc2)//Menú de la para la opción elegida.
            {
                case 1: //Al elegir uno cambias el estado a "en proceso".
                    foreach (var item in select_Pendiente)
                    {
                        Pendientes.Remove(item);
                        Proceso.Add(item);
                    }
                    foreach (var item in select_Terminadas)
                    {
                        Terminadas.Remove(item);
                        Proceso.Add(item);
                    }
                    foreach (var item in Proceso)//Despliega las tareas en proceso actualmente.
                    {
                        Console.WriteLine("Tareas en Proceso: " +
                            "\nID:" + item.ID +
                            "\nTarea:" + item.NombreTarea +
                            "\nDescripción: " + item.Descripcion +
                            "\n Fecha de Incio: " + item.FechaInicio +
                            "\n Fecha de entrega: " + item.FechaFin);
                    }
                    break;
                case 2: //Al elegir dos cambias el estado a "terminado".
                    foreach (var item in select_Proceso)
                    {
                        Proceso.Remove(item);
                        Terminadas.Add(item);
                    }
                    foreach (var item in Terminadas)//Despliega las tareas terminadas actualmente.
                    {
                        Console.WriteLine("Tareas en Terminadas: " +
                            "\nID:" + item.ID +
                            "\nTarea:" + item.NombreTarea +
                            "\nDescripción: " + item.Descripcion +
                            "\n Fecha de Incio: " + item.FechaInicio +
                            "\n Fecha de entrega: " + item.FechaFin);
                    }
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }
            Console.WriteLine("¿Desea cambiar el estado de otra tarea?" +
                "\n1.-Si" +
                "\n2.-No" +
                "\nIngrese una opción: ");
            opc3 = int.Parse(Console.ReadLine());//Introduces una opción para saber si quieres continuar 
            //cambiando estados a las tareas ya establecidas o salir
            Console.Clear();
            if (opc3 == 1)//Si la opción es 1 continuas.
            {
                Opciones_Tarea();
            }
            else//Si la opción es cualquier otra cosa sales del programa.
            {
                Environment.Exit(0);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E3_EstDatos
{
    public class Clase
    {
        public string Maestro { get; set; }
        public string Alumno { get; set; }
        public string NombreClase { get; set; }
        public int Calificacion { get; set; }

        public Clase(string Maestro, string Alumno, string NombreClase, int Calificacion)
        {
            this.Maestro = Maestro;
            this.Alumno = Alumno;
            this.NombreClase = NombreClase;
            this.Calificacion = Calificacion;
        }

        // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
        // en un solo curso.Incluir métodos que calculen la nota media, la
        //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
        //implementación. Minimo 30 Calificaciones, de 30 alumnos.





    }

    public class Operacion
    {

        Stack Lista = new Stack();
        Queue Cola = new Queue();



        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()

            Lista.Push(5);
            Lista.Push(3);
            Lista.Pop();
            Lista.Push(2);
            Lista.Push(8);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(9);
            Lista.Push(1);
            Lista.Pop();
            Lista.Push(7);
            Lista.Push(6);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(4);
            Lista.Pop();
            Lista.Pop();
            Console.WriteLine("\t\tEjercicio 1\n\n");
            foreach (var item in Lista)
            {
                Console.WriteLine("Valores que quedaron en la pila: " + item);

            }

            Console.Write("\n\n");

        }

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal


            Console.WriteLine("Subi a github la practica sin el ejercicio 2, posteriormente la hice e hice un commit y oush (actualizando segun yo" +
                              ") y no lo veo refleado en el archivo de github de la pagina, esto es una prueba a ver si actualiza con este mensaje");

            Console.WriteLine("Se perdio mi ejercicio 2...");
        }
        entificadores y literales en Otra lista enlazada.
           //Cuando el programa haya terminado de leer la entrada, mostrar
           //Los contenidos de cada lista enlazada.
           //Revise que es un Identificador y que es un literal


           Console.WriteLine("Subi a github la practica sin el ejercicio 2, posteriormente la hice e hice un commit y oush (actualizando segun yo" +
                              ") y no lo veo refleado en el archivo de github de la pagina, esto es una prueba a ver si actualiza con este mensaje");

            Console.WriteLine("Se perdio mi ejercicio 2...");
        }

    public void Ejercicio3()
        {
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.

            Console.WriteLine("\t\tEjercicio 3\n\n");
            const int max = 100000;
            List<int> lista = new List<int>();//Instanciamos una lista
            LinkedList<int> listaligada = new LinkedList<int>();// y una lista ligada

            for (int i = 0; i < 9877; i++)//Las dos listas las llenamos con un elemento 9876 veces
            {
                lista.Add(i);
                listaligada.AddLast(i);





            }
            var m1 = Stopwatch.StartNew();//Instanciamos una variable para medir el tiempo

            for (int i = 0; i < lista.Count; i++)//Hacemos el recorrido de la lista
            {
                foreach (var item in lista)//Por cada elemento de la lista decimos que si el elemento de la lista es diferente a 4
                {

                }
            }

            m1.Stop();//Paramos el tiempo

            var m2 = Stopwatch.StartNew();//LA misma medicion

            for (int i = 0; i < listaligada.Count; i++)// pero con la lista ligada
            {
                foreach (var item in listaligada)
                {



                }
            }

            m2.Stop();

            Console.WriteLine("Lista: " + ((double)(m1.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));//Imprimimos los tiempos
            Console.WriteLine("Lista ligada: " + ((double)(m2.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));
            Console.Write("\n\n");
        }

        public void Ejercicio4()
        {

            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.

            Console.WriteLine("\t\tEjercicio 4\n\n");
            List<Clase> alumnos = new List<Clase>();
            Random rdn = new Random();
            for (int i = 17212130; i < 17212161; i++)
            {
                alumnos.Add(new Clase("Humberto Taboada", (i + 1).ToString(), "Estructura de datos", rdn.Next(1, 101)));
            }
            Console.WriteLine("Las calificaciones de los alumnos son: ");
            foreach (var item in alumnos)
            {
                Console.WriteLine("Maestro: {0}\tAlumno: {1}\t\nMateria: {2}\tCalificacion: {3}\n\n", item.Maestro, item.Alumno, item.NombreClase, item.Calificacion);
            }

            int aux1 = 0;
            foreach (var item in alumnos)
            {
                aux1 = aux1 + item.Calificacion;
            }
            int aux2 = aux1 / alumnos.Count();
            Console.WriteLine("La nota media es: " + aux2);

            var maxObject = alumnos.Max(item => item.Calificacion);//Linq y Lambda for the win!!
            var minObject = alumnos.Min(item => item.Calificacion);
            Console.WriteLine("La calificacion mas alta es: " + maxObject);
            Console.WriteLine("La calificacion mas baja es: " + minObject);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Operacion op = new Operacion();
            op.Ejercicio1();
            op.Ejercicio3();
            op.Ejercicio4();
            Console.ReadKey();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   // Encuentra el mayor  el menor elemento de n elementos generados.
            // La Moda de un conjunto de datos es el elemento que mas se repite. Encuentra la moda de n elementos almacenados en una array.
            // Genera 2 arrays con notas para nota 1 y nota 2 simulando una matriz; muestre un listado:

            Console.Write("Cantidad de elementos:"); int n = int.Parse(Console.ReadLine());
            string[] name = new string[n]; int[] nota1 = new int[n]; int[] nota2 = new int[n]; int opcion;
            do
            {
                Console.WriteLine("\n------------------------------------------------------\n" +
                    "\n (1) Generar (2) Leer (3) Mostar (4) Recuperar (5) Salir\n");
                opcion = int.Parse(Console.ReadLine());
                Menu(opcion, name, nota1, nota2);

            } while (opcion != 5);
        }
        static void Menu(int opcion, string[] name, int[] nota1, int[] nota2)
        {
            switch (opcion)
            {
                case 1: Generar(nota1, nota2); break;
                case 2: Leer(name); break;
                case 3: Mostrar(name, nota1, nota2); break;
                case 4: Recuperar(nota1, nota2); break;
                case 5: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opcion no valida"); break;


            }
        }
        static void Generar(int[] nota1, int[]nota2)
        {
            Random ale = new Random();
            for (int i = 0; i < nota1.Length; i++)
            {
                nota1[i] = ale.Next(21); nota2[i] = ale.Next(21);
            }
        }
        static void Leer(string[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("NOMBRE[" + (i + 1) + "]:");
                name[i] = Console.ReadLine();
            }
        }
        static void Mostrar(string[] name, int[] nota1, int[] nota2)
        {
            Console.WriteLine("\n\tNombre\tNota1\tNota2\tPromedio");

            for (int i = 0; i < name.Length; i++)
            {
                float promedio;
                promedio = (nota1[i] + nota2[i]) / 2f;
                Console.WriteLine("\t" + name[i] + "\t" + nota1[i] + "\t" + nota2[i] + "\t" + promedio);
            }
        }
        static void Recuperar(int[] nota1, int[] nota2)
        {
            Random num = new Random();
            for (int i = 0; i < nota1.Length; i++)
            {
                float promedio = (nota1[i] + nota2[i]) / 2f;
                if (nota1[i] < 11.5) nota1[i] = num.Next(21);
            }
            for (int i = 0; i < nota2.Length; i++)
            {
                
                if (nota1[i] < 11.5) nota2[i] = num.Next(21);
            }
        }

    }
}

           
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de elementos:"); int n = int.Parse(Console.ReadLine());
            string[] name = new string[n]; int[] nota = new int[n]; int opcion;
            do
            {
                Console.WriteLine("\n------------------------------------------------------\n" +
                    "\n (1) Generar (2) Leer (3) Mostar (4) Recuperar (5) Salir\n");
                opcion = int.Parse(Console.ReadLine());
                Menu(opcion,name,nota);

            } while (opcion != 5);      
        }
        static void Menu (int opcion, string[]name, int[]nota)
        {
            switch (opcion)
            {
                case 1: Generar(nota);break;
                case 2: Leer(name); break;
                case 3: Mostrar(name, nota); break;
                case 4: Recuperar(nota); break;
                case 5: Console.WriteLine("Saliendo...");break;
                default: Console.WriteLine("Opcion no valida"); break;


            }
        }
        static void Generar(int[]nota)
        {
            Random ale = new Random();
            for (int i = 0; i < nota.Length; i++)
            {
                nota[i] = ale.Next(21);
            }
        }
        static void Leer(string[]name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("NOMBRE[" + (i + 1) + "]:");
                name[i] = Console.ReadLine();
            }
        }
        static void Mostrar(string[]name, int[]nota)
        {
            Console.WriteLine("\n\tNOMBRE:\tNOTA:");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("\t" + name[i] + "\t" + nota[i]);
            }
        }
        static void Recuperar(int[]nota)
        {
            Random num = new Random();
            for (int i = 0; i < nota.Length; i++)
            {
                if (nota[i] < 12) nota[i] = num.Next(21);
            }
        }
        
    }
}

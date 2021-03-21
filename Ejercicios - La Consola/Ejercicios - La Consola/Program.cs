using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios___La_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            /*Console.WriteLine("Ejercicio 1");

            Console.WriteLine("Hola Mundo");
            Console.ReadKey();

            Console.WriteLine("Ejercicio 2");

            Console.WriteLine("Por favor ingrese un texto");
            string texto = Console.ReadLine();
            Console.WriteLine("El texto ingresado es '" + texto + "'");
            Console.ReadKey();

            Console.WriteLine("Ejercicio 3");

            Console.WriteLine("Presione la tecla X");
            string tecla = Console.ReadLine();
            while (tecla != "X")
            {
                Console.WriteLine("La tecla que debe presionar es la X. Intente de nuevo por favor");
                tecla = Console.ReadLine();
                Console.WriteLine("Gracias!");
                Console.ReadKey();
            }


            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("Por favor ingrese su primera frase.");
            string frase = Console.ReadLine();
            while (frase != "fin")
            {
                Console.WriteLine("Ingrese otra frase o escriba 'fin' ");
                frase = Console.ReadLine();
                if (frase != "fin")
                {
                    Console.WriteLine("La frase colocada es " + frase);
                }
            }

            */
            Console.WriteLine("Ejercicio 5");

            Console.WriteLine("Presione la tecla que quiera.");
            Console.WriteLine("Presione la tecla Control + F para salir.");

            cki = Console.ReadKey();
            Console.ReadKey();
            while (((cki.Modifiers & ConsoleModifiers.Control) == 0)  && cki.Key.ToString() != "f")
            {
                Console.WriteLine("Presionaste ");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
                Console.WriteLine(cki.Key.ToString());
                Console.WriteLine("Presione otra combinacion de teclas o presione la tecla Control + F para salir.");
                cki = Console.ReadKey();
                Console.ReadKey();

            }
            Console.WriteLine("Presionaste CTRL + " + cki.Key.ToString()); 

            Console.ReadKey();
            Console.WriteLine("Ejercicio 6");
        }
    }
}

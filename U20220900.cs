using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)

        {

         //Ejercicio clase 9
		
            //Ejercicio clase 9
		//Programa para evaluar la nota ingresada
            Console.WriteLine("\n------Programa para evaluar la nota ingresada------\n");
            Console.WriteLine("Ingresa la calificación: ");
            double calificación = Convert.ToDouble(Console.ReadLine());
   
         //Si la nota es mayor o igual que 7.0
         if (calificación >= 7)
         {
            Console.WriteLine("\nLa nota " + calificación + " ingresada es buena\n");
                Console.WriteLine("\n------Fin del Programa------\n");
         }

         //Si la nota es mayor o igual que 8.5
            else if (calificación >= 8.5)
             {
                Console.WriteLine("\nLa nota " + calificación + " ingresada es muy buena\n");
                Console.WriteLine("\n------Fin del Programa------\n");
            }

            //Si la nota es mayor que 9.5
            else if (calificación >= 9.5) 
            { 
                Console.WriteLine("\nLa nota " + calificación + " ingresada es excelente\n");
                Console.WriteLine("\n------Fin del Programa------\n");
            }

                 //Si no se cumplen ninguna condición
            else
            {
                Console.WriteLine("\nLa calificación " + calificación + " es deficiente\n");
                Console.WriteLine("\n------Fin del Programa------\n");

           }
        }
    }
}
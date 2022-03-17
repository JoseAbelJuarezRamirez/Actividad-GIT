using System;

namespace Actividad_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Alumnos = "Alumnos";
            
            for (int i = 1; i < 11; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Alumnos + " numero: " + i);

            }
            
        }
    }
}

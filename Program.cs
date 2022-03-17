using System;

namespace Actividad_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Alumnos = "Alumnos";
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Universidad Autonoma de Occidente");
            for (int i = 1; i < 21; i++)
            {
                if((i % 2) == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(Alumnos + " numero: " + i + " Aprobados");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Alumnos + " numero: " + i + " Reprobados");
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Fin de la lista");
            
        }
    }
}

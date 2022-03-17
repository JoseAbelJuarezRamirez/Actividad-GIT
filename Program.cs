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
            
        }
    }
}

using System.ComponentModel.Design;

namespace CalificacionesEv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bienvenido querido estudiante, introduzca su calificación :3");
            int calificacion = int.Parse(Console.ReadLine());
            Console.WriteLine(calificacion);

            if (calificacion >=70)
            {
                Console.WriteLine($"Mayores que 60");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Aprobado");
            }
            else if (calificacion <=50)
            {
                Console.WriteLine($"Menores que 60");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Reprobado");
            }
            else 
            {
                Console.WriteLine("60");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Regularización");
            }
        }
    }
}

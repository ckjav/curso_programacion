using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            calcular();
        }

        static void saludo()
        {
            Console.WriteLine("Bienvenido al mundo de C#");
            Console.WriteLine("Podrás dar solución a muchos problemas");
            Console.ReadLine();
        }

        public static void op_Suma_Media()
        {
            int a = 3;
            int b = 2;
            int c = 14;
            int d = 10;
            Console.WriteLine("La suma es: " + (a + b + c + d));
            Console.WriteLine("El promedio es: " + (a + b + c + d) / 4);
            Console.ReadLine();
        }

        public static void calcular()
        {
            int a = 1;
            int b = 5;
            int c = 2;
            Console.WriteLine("El resultado es: " + ((Math.Pow(b, 2) - 4 * a * c) / 2 * a));
            Console.ReadLine();
        }
    }
}

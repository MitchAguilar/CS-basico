using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_funciones_may_men
{
    //cifras mayores a menores
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Todas las cifras menores o iguales a 3? " + SoloCifrasMenorIgual(numero, 3).ToString());
            Console.WriteLine("¿Todas las cifras mayores o iguales a 5? " + SoloCifrasMayorIgual(numero, 5).ToString());
            Console.ReadKey();
        }
        //retorna true si num sólo tiene cifras menores o iguales a cifra
        static bool SoloCifrasMenorIgual(int num, int cifra)
        {
            while (num != 0)
            {
                if (num % 10 > cifra) return false;
                num /= 10;
            }
            return true;
        }
        //retorna true si num tiene sólo cifras mayores o iguales de cifra
        static bool SoloCifrasMayorIgual(int num, int cifra)
        {
            while (num != 0)
            {
                if (num % 10 < cifra) return false;
                num /= 10;
            }
            return true;
        }
    }
}

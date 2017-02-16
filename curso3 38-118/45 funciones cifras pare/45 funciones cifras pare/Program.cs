using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_funciones_cifras_pare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Todas cifras pares? "+TodasCifrasPares(numero).ToString());
            Console.ReadKey();
        }
        //retorna true si todas las cifra son pares
        static bool TodasCifrasPares(int num)
        {
            while (num != 0)
            {
                var cifra = num % 10;
                if (cifra % 2 != 0) return false;
                num /= 10;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_funciones_cifras_pare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Suma " + SumaCifrasPares(numero).ToString());
            Console.WriteLine(" las cifras pares del numero ingresado");
            Console.ReadKey();
        }
        //retorna la sumatoria de las cifras pares de un numero
        static int SumaCifrasPares(int num)
        {
            int acum = 0;
            while (num != 0)
            {
                int cifra = num % 10;
                if (cifra % 2 == 0) acum += cifra;
                num /= 10;
            }
            return acum;
        }
    }
}

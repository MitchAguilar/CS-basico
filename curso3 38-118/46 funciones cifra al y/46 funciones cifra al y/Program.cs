using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_funciones_cifra_al_y
{
    class Program
    {
        //cifra más alta y más baja
        static void Main(string[] args)
        {
            Console.Write("Escriba Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cifra más alta: " + LaCifraMasAlta(numero).ToString());
            Console.WriteLine("Cifra mas baja: " + LaCifraMasBaja(numero).ToString());
            Console.ReadKey();
        }
        static int LaCifraMasAlta(int num)//retorna la cifra más alta
        {
            var cifra = 0;
            while (num != 0)
            {
                if (num % 10 > cifra) cifra = num % 10;
                num /= 10;
            }
            return cifra;
        }
        static int LaCifraMasBaja(int num)//la cifra más baja
        {
            var cifra = 0;
            while (num != 0)
            {
                if (num % 10 < cifra) cifra = num % 10;
                num /= 10;
            }
            return cifra;
        }
    }
}

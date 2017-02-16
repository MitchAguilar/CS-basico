using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_funciones_suma_de_cif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba número ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Suma " + SumaCifras(numero).ToString());
            Console.WriteLine(" las cifras del numero ingresado");
            Console.ReadKey();
        }
        static int SumaCifras(int num)
        {

            int acum = 0;
            while (num!=0)
            {
                var cifra = num % 10;
                acum += cifra;
                num /= 10;
            }
            return acum;
        }
    }
}

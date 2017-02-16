using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_funciones_cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Es " + PrimeraCifra(numero).ToString());
            Console.WriteLine(" la primera cifra de el número digitado.");
            Console.ReadKey();
        }
        static int PrimeraCifra(int num)
        {
            int primera = 0;
            while (num!=0)
            {
                primera = num % 2;
                num /= 10;
            }
            return primera;
        }
    }
}

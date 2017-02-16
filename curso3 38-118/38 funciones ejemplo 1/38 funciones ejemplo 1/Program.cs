using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_funciones_ejemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Escriba Numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (Esprimo(numero))
                Console.WriteLine(numero.ToString() + " es primo");
            else
                Console.WriteLine(numero.ToString() + " no es primo");
            Console.ReadKey();
         }
        //retorna true si el  numero enviado por parametor es primo
        static bool Esprimo(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 2) return false;

            for (int divide = 3; divide <= Math.Sqrt(num); divide += 2)
                if (num % divide == 0) return false;
            return true;
        }
    }
}

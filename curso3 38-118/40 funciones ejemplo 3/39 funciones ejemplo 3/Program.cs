using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_funciones_ejemplo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hay " + TotalCifras(numero).ToString());
            Console.Write(" cifras en el numero ingresado");
            Console.ReadKey();

        }
        static int TotalCifras(int num)
        {
            var cuenta = 0;
            while (num != 0)
            {
                cuenta++;
                num /= 10;
            }
            return cuenta;
        }
    }
}

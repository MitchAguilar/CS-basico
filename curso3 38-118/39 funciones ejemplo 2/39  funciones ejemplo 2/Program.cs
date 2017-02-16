using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39__funciones_ejemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hay " + cifrashallasdas(numero, 5).ToString());
            Console.ReadKey();

        } 
        //dice cuantas cifras de d eterminado numero hay en el numero enviado
        static int cifrashallasdas(int num,int cifra) {
            int acomula = 0;
            while (num != 0)
            {
                if (num % 10 == cifra) acomula++;
                num = num / 10;
            }
            return acomula;
        }
    }
}

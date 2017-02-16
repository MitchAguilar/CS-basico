using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_funciones_todas_cifra
{
    class Program
    {
        //todas las ccifras distintas
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Todas las cifras son distintas? " + DistintasCifras(numero).ToString());
            Console.ReadKey();
        }
        static bool DistintasCifras(int num)//retorna true si todas las cifras son distintas
        {
            for (var cifra = 0; cifra <= 9; ++cifra)
            {
                var numero = num;
                var cuenta = 0;
                while (numero != 0)
                {
                    if (numero % 10 == cifra) cuenta++;
                    if (cuenta > 1) return false;
                    numero /= 10;
                }
            }
            return true;
        }
    }
}

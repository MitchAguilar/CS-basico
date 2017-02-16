using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_funciones_ult_pen_ant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Última cifra: " + UltimaCifra(numero).ToString());
            Console.WriteLine("Penúltima cifra: " + PenultimaCifra(numero).ToString());
            Console.WriteLine("Antepenultima cifra: " + AntepenCifra(numero).ToString());
            Console.ReadKey();
        }
        //retorna la antepenultima cifra
        static int AntepenCifra(int num)
        {
            return num / 100 % 10;
        }
        //retorna la penultima cifra de un numero
        static int PenultimaCifra(int num)
        {
            return num / 10 % 10;
        }
        //retorna la ultima cifra de un numero entero
        static int UltimaCifra(int num)
        {
            return num % 10;
        }
    }
}

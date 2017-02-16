using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2
{
    class Program
    {
        static void Main(string[] args) {
            //función si condicional
            /*Console.WriteLine("Escriba un valor A: ");
            int valA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba un valor B: ");
            int valB = Convert.ToInt32(Console.ReadLine());

            if (valA > valB)
                Console.WriteLine("valor A " + valA.ToString() + " es mayor a valor B " + valB.ToString());
            else
                Console.WriteLine("valor B " + valB.ToString() + " es mayor a valor A " + valA.ToString());
            Console.ReadKey();*/

            //funcion else if
            /*  Console.WriteLine("Escriba un valor A: ");
              int valA = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("Escriba un valor B: ");
              int valB = Convert.ToInt32(Console.ReadLine());

              if (valA > valB)
                  Console.WriteLine("valor A " + valA.ToString() + " es mayor a valor B " + valB.ToString());
              else if(valA==valB)
                  Console.WriteLine("valor A " + valA.ToString() + " es igual a valor B " + valB.ToString());
              else
                  Console.WriteLine("valor A " + valA.ToString() + " es menor a valor B " + valB.ToString());
              Console.ReadKey();*/

            //condicional if con corchetes
            /*Console.WriteLine("Escriba un valor A: ");
            int valA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba un valor B: ");
            int valB = Convert.ToInt32(Console.ReadLine());

            if (valA > valB) { 
                Console.WriteLine("valor A " + valA.ToString() + " es mayor a valor B " + valB.ToString());
                Console.WriteLine("se pueden ejecutar varias lineas pero con los corchetes");
            } else { 
                Console.WriteLine("valor A " + valA.ToString() + " es menor a valor B " + valB.ToString());
                Console.WriteLine("se pueden ejecutar varias lineas pero con los corchetes");
            }
            Console.ReadKey();*/

            //uso del &&
            /*Console.Write("Digite su puto valor: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if(a%3==0 && a % 7 == 0)//uso del AND
            {
                Console.WriteLine("su numero es multiplo de 3 y de 7");
            }
            else
            {
                Console.WriteLine("su numero no es multiplo ni de 3 ni de 7");
            }
            Console.ReadKey();*/

            //uso del OR
            /*Console.Write("Digite su puto valor: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 3 == 0 || a % 7 == 0)//uso del AND
            {
                Console.WriteLine("su numero es multiplo de 3 oviol de 7");
            }
            else
            {
                Console.WriteLine("su numero no es multiplo ni de 3 ni de 7");
            }
            Console.ReadKey(); */

            //si condicional con ||
            /* Console.WriteLine("Escriba el valor de Arcoseno: ");
             double valor = Convert.ToDouble(Console.ReadLine());

             if(valor >1|| valor < -1)
             {
                 Console.WriteLine("Valor fuera de rango para el arcoseno");
             }else
             {
                 double angulo = Math.Asin(valor);
                 Console.WriteLine("Angulo es de: " + angulo.ToString());
             }
             Console.ReadKey();*/

            //ejemplos del uso del AND
            /* Console.WriteLine("Escriba el valor de Arcoseno: ");
             double valor = Convert.ToDouble(Console.ReadLine());

             if (valor >= 1 && valor <= -1)
             {

                 double angulo = Math.Asin(valor);
                 Console.WriteLine("Angulo es de: " + angulo.ToString());
             }
             else
             {
                 Console.WriteLine("Valor fuera de rango para el arcoseno");
             }
             Console.ReadKey();*/

            //ejemplo del && y ||
            /*Console.Write("Escriba el valor del angulo A en grados:  ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escriba el valor del angulo B en grados:  ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escriba el valor del angulo C en grados:  ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b + c != 180){
                Console.WriteLine("Angulos invalidos. ");
            }else if(a==90 || b==90|| c==90){
                Console.WriteLine("Triangulo rectangulo");
            }else if (a < 90 && b < 90 && c < 90){
                Console.WriteLine("triangulo acutangulo");
            } else{
                Console.WriteLine("triangulo obtusangulo");
            }
            Console.ReadKey();*/

            //switch
            /*Console.Write("escriba un numero entero: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            switch (valor)
            {
                case 0: Console.Write("Usted escribio cero");break;
                case 1: Console.Write("Usted escribio 1");break;
                case 2: Console.Write("Usted escribio 2");break;
                case 3: Console.Write("Usted escribió 3");break;
                case 4: Console.Write("Usted escribió 4");break;
                default: Console.Write("Usted escribió otro valor entero");break;

            }
            Console.ReadKey();*/

            //ciclo for
            /*for (int valor = 1; valor <= 50; valor++)
            {
                Console.Write(valor+", ");
            }
            Console.ReadKey();*/

            //for descendente
            /*for(int valor = 50; valor >= 1; valor-=2)
            {
                Console.Write(valor + ", ");
            }
            Console.ReadKey();*/

            //ciclo for con reales
            /* for(double valor = 100; valor >= 1; valor -= 1.5)
             {
                 Console.Write(valor + ", ");
             }
             Console.ReadKey();*/

            //ciclo de while
            /* int valor = 0;
             while (valor<=30)
             {
                 Console.Write(valor.ToString() + ", ");
                 valor++;
             }
             Console.ReadKey();*/

            //while invertido
            /* int valor = 40;
             while (valor >= 1)
             {
                 Console.Write(valor.ToString()+ ", ");
                 valor--;
             }
             Console.ReadKey();*/

            /*int valor = 0;
            do
            {
                Console.Write(valor.ToString() + ", ");
                valor++;
            } while (valor <= 30);

            Console.ReadKey();*/

            /*int valor = 20;
            do
            {
                Console.Write(valor.ToString() + ", ");
                valor--;
            } while (valor >= 0);
            Console.ReadKey();*/

            /* Console.Write("Escriba un numero a generar factorial: ");
             int numero = Convert.ToInt32(Console.ReadLine());
             int acomula = 1;
             for (int cout=2; cout <= numero; cout++)
             {
                 acomula *= cout;
             }

             Console.Write("Factorial es: " + acomula.ToString());
             Console.ReadKey();*/

            //uso de funciones
            Console.Write("Escriba Cateto A: ");
            double catA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escriba Cateto B: ");
            double catB = Convert.ToDouble(Console.ReadLine());

            double hip = calculaHipotenusa(catA, catB);
            Console.WriteLine("Hipotenusa: " + hip.ToString());
            Console.ReadKey();

        }
        static double calculaHipotenusa(double ladoA, double ladoB)
        {
            return Math.Sqrt(ladoA * ladoA + ladoB * ladoB);
        }
    }
}

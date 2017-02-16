using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso1
{
    class Program
    {
        static void Main(string[] args) {
            //primeros pasos en c# 
            /*conociendo el ide
            */
            //Console.WriteLine("Hola mundo");
            //Console.Write("linea de texto sin salto de linea");
            //Console.ReadKey();

            /////segunda parte

            //int entero;
            //entero = 20;
            //Console.WriteLine("ésto es un entero: " + entero);
            //Console.ReadKey();//recrdar simpre ponerlo para que pare la ejecución y espere tecla

            //diferentes tipos de enteros
            /*
            int entero1;//es equivalente a 4bytes
            Int32 entero2;//(-2.147.483.648 a +-2.147.483.647)
            Int16 entero3;// equivale a 2 bytes ( -32768 a +32767)
            Int64 entero4;//equivale a un entero de 8 bytes( un entero muy grande ya)
            uint entero5;// equivale a 4 bytes sin signo (0 a 4.294.967.295)

            entero1 = 10;
            entero2 = 20;
            entero3 = 30;
            entero4 = 40;
            entero5 = 50;

            Console.WriteLine(entero1.GetType());
            Console.WriteLine(entero2.GetType());
            Console.WriteLine(entero3.GetType());
            Console.WriteLine(entero4.GetType());
            Console.WriteLine(entero5.GetType());

            Console.ReadKey();
            */
            /*

            //diferentes tipos de decimal
            float decimal1;//decimal de baja precición
            Double decimal2;//doble de un flotante
            decimal decimal3;//decimal de alta presción

            decimal1 = (float)1 / 23;//se debe especificar el tipo con el cual se va a dividir
            decimal2 = (double)1 / 23;
            decimal3 = (decimal)1 / 23;

            Console.WriteLine(decimal1.GetType() + " Resulado: " + decimal1.ToString());
            Console.WriteLine(decimal2.GetType() + " Resulado: " + decimal2.ToString());
            Console.WriteLine(decimal3.GetType() + " Resulado: " + decimal3.ToString());
            Console.ReadKey();
            */

            //leyendo datos por consola
            /* Console.WriteLine("Digite su valor 1: ");
             String cadena = Console.ReadLine(); //el usuario infresa el dato
             Console.WriteLine("Digite su valor 2:");
             String cadena2 = Console.ReadLine();

             //el valor leido es convertido a int32 
             int valor1 = Convert.ToInt32(cadena);
             int valor2 = Convert.ToInt32(cadena2);

             int valor3 = valor1 + valor2;
             Console.WriteLine("Su resultado es: " + valor3.ToString());
             Console.ReadKey();*/

            //leyendo datos decimales
            /*Console.WriteLine("Digite su valor 1: ");
            String cadena = Console.ReadLine(); //el usuario infresa el dato
            Console.WriteLine("Digite su valor 2:");
            String cadena2 = Console.ReadLine();

            //el valor leido es convertido a int32 
            float valor1 = Convert.ToSingle(cadena);
            float valor2 = Convert.ToSingle(cadena2);

            float valor3 = valor1 / valor2;
            Console.WriteLine("Su resultado es: " + valor3.ToString());
            Console.ReadKey(); */

            //leyendo numeros reales con punto decimal
            /*Console.WriteLine("Digite su valor 1: ");
            String cadena1 = Console.ReadLine(); //el usuario infresa el dato
            Console.WriteLine("Digite su valor 2:");
            String cadena2 = Console.ReadLine();

            //el valor leido es convertido a int32 
            float valor1 = Convert.ToSingle(cadena1, CultureInfo.InvariantCulture.NumberFormat);//recordar importar la libreria
            float valor2 = Convert.ToSingle(cadena2);

            float valor3 = valor1 / valor2;
            Console.WriteLine("Su resultado es: " + valor3.ToString());
            Console.ReadKey();
            */

            //hacer los cast
            /*int valora=47;
            int valorb=17;

            int valorc = valora / valorb;
            float valord = valora / valorb;
            float valore = (float)valora / valorb;

            double valorf = valora / valorb;
            double valorg = (Double)valora / valorb;//ojo!! al poner la divivión entre parentesis se anula el cast

            Console.WriteLine("Valor c= "+valorc.ToString());
            Console.WriteLine("Valor d= " + valord.ToString());
            Console.WriteLine("Valor e= " + valore.ToString());
            Console.WriteLine("Valor f= " + valorf.ToString());
            Console.WriteLine("Valor g= " + valorg.ToString());
            Console.ReadKey();
            */

            //operaciones matematicas
            /*
            int a = 10, b = 40;

            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            int g = a % b;

            Console.WriteLine("Suma: " + c.ToString());
            Console.WriteLine("Resta: " + d.ToString());
            Console.WriteLine("Multiplicación: " + e.ToString());
            Console.WriteLine("Divicion: " + f.ToString());
            Console.WriteLine("Modulo: " + g.ToString());
            Console.ReadKey();*/

            //seno, coseno y tangente
            /*double angulo = 40;
            double angradian = angulo * Math.PI / 180;

            //las funciaones senos, coseno, tangente reciben el angul de radiantes
            double a = Math.Sin(angradian);
            double b = Math.Cos(angradian);
            double c = Math.Tan(angradian);

            Console.WriteLine("Angulo: " + angulo.ToString());
            Console.WriteLine("Angulo en gradianes: " + angradian.ToString());
            Console.WriteLine("Seno: " + a.ToString());
            Console.WriteLine("Coseno: " + b.ToString());
            Console.WriteLine("Tangente: " + c.ToString());
            Console.ReadKey();*/

            //potencias 
            /*double numeroelevador = 3;
            double numeroelevado = 5;
            //función de potencia
            double resultado = Math.Pow(numeroelevado, numeroelevador);
            Console.WriteLine("su resultdo es: " + resultado.ToString());
            Console.ReadKey();*/

            //ejeplo1 de calculos
            /*Console.WriteLine("Escriba la longitud del lado A:");
            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba la longitud del lado B:");
            double ladoB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba la longitud del lado C:");
            double ladoC = Convert.ToDouble(Console.ReadLine());

            var s = (ladoA + ladoB + ladoC) / 2;
            var area = Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));

            Console.WriteLine("El area de su trinagulo es: " + area.ToString());
            Console.ReadKey();*/

            //ejemplo de calculos 2
            /*Console.WriteLine("Escriba el radio del circulo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radio * radio;
            double perimetro = 2 * Math.PI * radio;

            Console.WriteLine("Area del circulo: " + area.ToString());
            Console.WriteLine("perimetro del circulo: " + perimetro.ToString());
            Console.ReadKey();*/




        }
    }
}

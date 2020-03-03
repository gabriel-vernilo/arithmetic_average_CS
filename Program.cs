using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTPA
{
    class Program
    {
        static void Main(string[] args)
        {

            Double Primeiro_numero, Segundo_numero, res;
            String Nome;
            Console.WriteLine("======CALCULO DE MÉDIA ARITMÉTICA======");
            Console.WriteLine("\nQual é seu nome?: ");
            Nome = Console.ReadLine();
            Console.WriteLine("digite o primiero número: ");
            Primeiro_numero = Double.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo número:");
            Segundo_numero = Double.Parse(Console.ReadLine());
            res = (Primeiro_numero + Segundo_numero) / 2;
            Console.WriteLine("======RESULTADO======");
            Console.Write($" {Nome}, sua média é {res} \n");

            Console.ReadKey(true);

        }
    }
}

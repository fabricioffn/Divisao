using System;

namespace divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int  numerador;
            int denominador;
            Console.WriteLine("digite um numerador");
            numerador = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("digite um denominador");
            denominador = Convert.ToInt16(Console.ReadLine());

            if(numerador > 0)
            {
                Console.WriteLine(numerador / denominador);
            }
            if(numerador == 0)
            {
                Console.WriteLine(numerador + " dividido por " + denominador + " é 0");
            }
            else if(denominador <= 0)
            {
                Console.WriteLine("não é possivel dividir por zero");
            }








        }
    }
}

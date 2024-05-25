using System;

namespace CalculadoraDio
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora("25/05/2024");

            calculadora.Somar(5, 6);
            calculadora.Subtrair(10, 8);
            calculadora.Multuplicar(1, 2);
            //calculadora.Dividir(16, 8);


            foreach (var item in calculadora.Historico())
            {
                Console.WriteLine(item);
            }
        }
    }
}



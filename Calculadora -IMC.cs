using System;

namespace Calculadora_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora IMC(Índice de Massa Corporal)");

            Console.WriteLine("Digite Seu nome");

            string Nome = Console.ReadLine();

            Console.WriteLine("Digite seu peso (Kg)");

            string Peso = Console.ReadLine();

            decimal Pesoemdecimal = Convert.ToDecimal(Peso);

            Console.WriteLine("Digite sua altura (M)");

            string Altura = Console.ReadLine();

            decimal Alturaemdecimal = Convert.ToDecimal(Altura);

            decimal indice = 0;

            indice =
                Pesoemdecimal /
                (Alturaemdecimal*Alturaemdecimal);

            if (indice <= 18.5M)

                Console.WriteLine(Nome + " está abaixo do peso.");

            else if (18.5M <= indice && indice < 25)

                Console.WriteLine(Nome + " está no peso Normal.");

            else if (25 <= indice && indice < 30)

                Console.WriteLine(Nome + " esta acima do peso.");

            else if (30 <= indice)

                Console.WriteLine(Nome + " está obeso.");

            else
                Console.WriteLine("Erro");

                Console.ReadKey();

            
                
         






        }
    }
}

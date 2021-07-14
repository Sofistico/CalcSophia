using System;

namespace CalcSophia
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int nmrAnterior, nmrPosterior, resultadoFinal = 0;

            Console.WriteLine("Digite um numero inteiro para calcular");
            nmrAnterior = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero inteiro para calcular com o anterior");
            nmrPosterior = int.Parse(Console.ReadLine());

            Console.WriteLine("Coloque o simbolo que vc gostaria de calcular, simbolos disponiveis: {+, -, *, /}");

            char simbolo = char.Parse(Console.ReadLine());

            switch (simbolo)
            {
                case '+':
                    resultadoFinal = nmrAnterior + nmrPosterior;
                    break;

                case '-':
                    resultadoFinal = nmrAnterior - nmrPosterior;
                    break;

                case '*':
                    resultadoFinal = nmrAnterior * nmrPosterior;
                    break;

                case '/':
                    resultadoFinal = nmrAnterior - nmrPosterior;
                    break;

                default:
                    Console.WriteLine("Voce não inseriu um caracter correto.");
                    break;
            }

            Console.WriteLine($"Seu resultado final: {resultadoFinal}");
        }
    }
}
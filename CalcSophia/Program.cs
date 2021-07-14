using System;

namespace CalcSophia
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float nmrAnterior, nmrPosterior, resultadoFinal = 0;

            Console.WriteLine("Digite um numero inteiro para calcular");
            nmrAnterior = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero inteiro para calcular com o anterior");
            nmrPosterior = float.Parse(Console.ReadLine());

            Console.WriteLine("Coloque o simbolo que vc gostaria de calcular, simbolos disponiveis: {+, -, *, /}");

            char simbolo = char.Parse(Console.ReadLine());

            switch (simbolo)
            {
                case '+':
                    resultadoFinal = (float)Math.Round(nmrAnterior + nmrPosterior, 4);
                    break;

                case '-':
                    resultadoFinal = (float)Math.Round(nmrAnterior - nmrPosterior, 4);
                    break;

                case '*':
                    resultadoFinal = (float)Math.Round(nmrAnterior * nmrPosterior, 4);
                    break;

                case '/':
                    resultadoFinal = (float)Math.Round(nmrAnterior - nmrPosterior, 4);
                    break;

                default:
                    Console.WriteLine("Voce não inseriu um caracter correto.");
                    break;
            }

            Console.WriteLine($"Seu resultado final: {resultadoFinal}");
        }
    }
}
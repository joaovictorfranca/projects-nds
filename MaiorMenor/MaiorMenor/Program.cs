using System;

namespace MaiorMenor
{
    class MaiorMenor
    {
        static void Main(string[] args)
        {
            bool loop = true;
            double maior = 0;
            double menor = 1000000000000;

            while (loop != false)
            {
                Console.WriteLine("Informe um numero (ou 0 para sair): ");
                double numero = double.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine($"O maior numero é: {maior}");
                    Console.WriteLine($"O menor numero é: {menor}");
                    return;
                }
                else if (maior == 0 || numero > maior)
                {
                    maior = numero;
                }
                else if (numero < menor)
                {
                    menor = numero;
                }
            }
        }
    }
}
/*
using System;

namespace MaiorMenor
{
    class MaiorMenor
    {
        static void Main(string[] args)
        {
            bool loop = true;
            double maior = double.MinValue; // Inicializado com o menor valor possível de double
            double menor = double.MaxValue; // Inicializado com o maior valor possível de double

            while (loop)
            {
                Console.WriteLine("Informe um número (ou 0 para sair): ");
                double numero;

                if (double.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero == 0)
                    {
                        if (maior == double.MinValue && menor == double.MaxValue)
                        {
                            Console.WriteLine("O maior valor é: 0");
                            Console.WriteLine("O menor valor é: 0");
                        }
                        else if (maior == double.MinValue)
                        {
                            Console.WriteLine("O maior valor é: 0");
                            Console.WriteLine($"O menor número é: {menor}");
                        }
                        else if (menor == double.MaxValue)
                        {
                            Console.WriteLine($"O maior número é: {maior}");
                            Console.WriteLine("O menor valor é: 0");
                        }
                        else
                        {
                            Console.WriteLine($"O maior número é: {maior}");
                            Console.WriteLine($"O menor número é: {menor}");
                        }
                        return;
                    }

                    if (numero > maior)
                    {
                        maior = numero;
                    }

                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                }
            }
        }
    }
}
*/
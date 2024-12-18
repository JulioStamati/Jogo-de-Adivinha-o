using System;
class Program
{
    static void Main()
    {
        Random random = new Random();
        int numerosorteado = random.Next(1, 100);

        int tentativas = 0;
        int palpite = 0;

        Console.WriteLine("Bem vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar um número entre 1 e 100");

            while (palpite != numerosorteado)
        {
            Console.WriteLine("\nDigite seu Palpite:");

            try
            {
                palpite = int.Parse(Console.ReadLine());
                tentativas++;

                if (palpite < numerosorteado)
                {
                    Console.WriteLine("O número sorteado é maior que" + palpite + ".");
                }
                else if (palpite > numerosorteado)
                {
                    Console.WriteLine("O número sorteado é menor que" + palpite + ".");
                }
                else
                {
                    Console.WriteLine($"\nParabéns! Você acertou o número{numerosorteado} em {tentativas} tentativas.");
                }
            }
            catch
            {
                Console.WriteLine("Por favor digite um número válido!");

            }
        }
    }
}


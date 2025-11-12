using System;

namespace Buscador
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meuVetor = new string[10] {
                "Ana", "Bruno", "Carlos", "Daniela", "Elias",
                "Fábio", "Gabriela", "8", "50", "123"
            };

            Console.WriteLine("Digite o nome ou número a ser buscado:");
            string termoBusca = Console.ReadLine();

            bool encontrado = false;
            int posicaoEncontrada = -1;

            for (int i = 0; i < meuVetor.Length; i++)
            {
                if (meuVetor[i] == termoBusca)
                {
                    encontrado = true;
                    posicaoEncontrada = i;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine($"Item encontrado!");
                Console.WriteLine($"A posição (índice) no vetor é: {posicaoEncontrada}");
            }
            else
            {
                Console.WriteLine("não encontrado");
            }
        }
    }
}

using System;

class Program
{
    static char[] tabuleiro = { '1','2','3','4','5','6','7','8','9' };
    static int jogadorAtual = 1;

    static void Main()
    {
        bool jogoAtivo = true;

        while (jogoAtivo)
        {
            Console.Clear();
            MostrarTabuleiro();

            char simbolo = jogadorAtual == 1 ? 'X' : 'O';
            Console.Write($"Jogador {jogadorAtual} ({simbolo}), escolha uma posição (1-9): ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int posicao) && posicao >= 1 && posicao <= 9)
            {
                if (tabuleiro[posicao - 1] != 'X' && tabuleiro[posicao - 1] != 'O')
                {
                    tabuleiro[posicao - 1] = simbolo;

                    if (VerificarVitoria())
                    {
                        Console.Clear();
                        MostrarTabuleiro();
                        Console.WriteLine($"\n🎉 Jogador {jogadorAtual} venceu!");
                        jogoAtivo = false;
                    }
                    else if (VerificarEmpate())
                    {
                        Console.Clear();
                        MostrarTabuleiro();
                        Console.WriteLine("\n😐 Empate!");
                        jogoAtivo = false;
                    }
                    else
                    {
                        jogadorAtual = jogadorAtual == 1 ? 2 : 1;
                    }
                }
                else
                {
                    Console.WriteLine("Essa posição já está ocupada. Pressione Enter para tentar novamente.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Pressione Enter para tentar novamente.");
                Console.ReadLine();
            }
        }

        Console.WriteLine("Fim de jogo. Pressione Enter para sair.");
        Console.ReadLine();
    }

    static void MostrarTabuleiro()
    {
        Console.WriteLine("\n Jogo da Velha\n");
        Console.WriteLine($" {tabuleiro[0]} | {tabuleiro[1]} | {tabuleiro[2]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {tabuleiro[3]} | {tabuleiro[4]} | {tabuleiro[5]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {tabuleiro[6]} | {tabuleiro[7]} | {tabuleiro[8]} ");
    }

static bool VerificarVitoria()
{
    int[,] combinacoes = {
        {0,1,2}, {3,4,5}, {6,7,8},
        {0,3,6}, {1,4,7}, {2,5,8},
        {0,4,8}, {2,4,6}
    };

    for (int i = 0; i < combinacoes.GetLength(0); i++)
    {
        int a = combinacoes[i, 0];
        int b = combinacoes[i, 1];
        int c = combinacoes[i, 2];
        if (tabuleiro[a] == tabuleiro[b] && tabuleiro[b] == tabuleiro[c])
            return true;
    }

    return false;
}

    static bool VerificarEmpate()
    {
        foreach (char c in tabuleiro)
        {
            if (c != 'X' && c != 'O')
                return false;
        }
        return true;
    }
}
using System.Collections.Generic;
Console.WriteLine("Invertendo palavras com pilhas (Stacks)");

Console.WriteLine("Digite uma palavra:");
string? palavra = Console.ReadLine();

Stack<char> chars = new Stack<char>();
foreach (var c in palavra!)
{
    chars.Push(c);
}

string? palavra_invertida = string.Empty;
while (chars.Count > 0)
{
    var c = chars.Pop();muss
    Console.Write(c);
    palavra_invertida += c;
}

if (palavra == palavra_invertida)
        Console.WriteLine("\nA palavra é um palíndromo");
else
        Console.WriteLine("\nA palavra não é um palíndromo");
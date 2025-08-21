using System;
class Program
{
    public static void Main()
    {
        int fact, num;
        Console.Write("Digite um número para calcular o fatorial: ");

        // take input from user 
        num = Convert.ToInt32(Console.ReadLine());

        Program obj = new Program();

        // calling recursive function   
        fact = obj.factorial(num);

        Console.WriteLine("Fatorial de {0} é {1}", num, fact);
    }

    // recursive function 
    public int factorial(int num)
    {
        // termination condition
        if (num == 0)
            return 1;
        else
            // recursive call
            return num * factorial(num - 1);
    }
}
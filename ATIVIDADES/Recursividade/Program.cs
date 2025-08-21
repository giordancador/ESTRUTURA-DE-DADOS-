Console.WriteLine("Enter the lenght of the Fibonacci Series: ");
int Length = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < Length; i++)
{
    Console.Write(" {0} ", FibonacciSeries(i));
}
Console.ReadKey();

static int FibonacciSeries(int n)
{
    if (n == 0) return 0; // to return the first fibonacci number
    if (n == 1) return 1; // to return the second number 
    return FibonacciSeries (n - 1) + FibonacciSeries(n - 2);
}
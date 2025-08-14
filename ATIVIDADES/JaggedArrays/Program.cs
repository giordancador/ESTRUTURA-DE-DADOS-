int[][] numbers =
{
    new int[] { 1, 2, 3 },
    new int[] { 4 },
    new int[] { 5, 6, 7, 8, 9 },
    new int[] { 6, 5, 4 }
};

// outra forma de inicializar 

int[][] numbers2 = 
{
    new int[] { 1 },
    new int[] { 2 },
    new int[] { 3 },
    new int[] { 4 },
    new int[] { 5 },
    new int[] { 6 },
    new int[] { 7 },
    new int[] { 8 },
    new int[] { 9 },
    new int[] { 10 }
};

//para percorrer o jegueaarray utilizamos laços de repetição encadeados // nested loops

for (int i = 0; i < numbers2.Length; i++)
{ 
    Console.Write("[");
    for (int j = 0; j < numbers2[i].Length; j++)
    {
        if (j > 0) Console.Write(", ");
        Console.Write(numbers2[i][j]);
    }
    Console.WriteLine("]");
}
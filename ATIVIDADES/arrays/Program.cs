using System.Globalization;
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

Console.WriteLine("");

Console.WriteLine("");

Console.WriteLine("Informe o seu nome");

// ? > operador nullable 
// indica que a variavel pode receber valor nulo

string? name = Console.ReadLine();
Console.WriteLine($"Seja bem vindo{name}");

//declarando vetor
//sem inicializacao
int[] numbers;

//inicializando vetor

numbers = new int[5];
int[] numbers2 = new int[5];

//atribuindo valores
numbers2[0] = 1;
numbers2[1] = 2;
numbers2[2] = 3;
numbers2[3] = 4;
numbers2[4] = 5;

//declarando e inicializando com valores

int[] numbers3 = new int[] { 1, 2, 3, 4, 5};

//simplicada

int[] numbers4 = { 1, 2, 3, 4, 5 };

//preenchendo um vetor com os 12 meses do ano

string[] months = new string[12];
for (int i = 1; i <= 12; i++)
{  
    DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);
    string monthname = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));

    months[i - 1] = monthname;
}

foreach (var month in months)
{
    Console.WriteLine(month);
}

//array multi dimensional  
// 2 dimensoes

int[,] numbers52 = new int[5, 2];

int[,,] numbers543 = new int[5, 4, 3];

//iniciando matriz valorada

int[,] nmb = new int[, ]  {
    {1,2,- 9 }, 
    { 5,7,10}, 
    { 6,115,54}
    };

//tambem podemos acessar a matriz da seguinte forma


int myNumber = nmb[2, 1];
Console.WriteLine("Imprimindo valor da matriz:");
Console.WriteLine(myNumber);
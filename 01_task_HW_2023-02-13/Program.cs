// 01_task_HW_2023-02-13
// Показать двумерный массив размером m×n заполненный вещественными числами
Console.Clear();
Console.WriteLine("Показать двумерный массив размером m x n заполненный вещественными числами" !);
Console.WriteLine();

void PrintMass(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i , j]} \t" !);
        }
        Console.WriteLine();
    }
}

double[,] CreateMass(int sizeM, int sizeN )
{   
    double[,] massive = new double[sizeM, sizeN];
    Random rnd = new Random();
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i , j] = rnd.NextDouble();
        }
    }
    return massive;
}

int ReadNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int ComputeDiagonal(int[,] mass)
{
    int sumDiagonal = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
       sumDiagonal += mass[i, i];
    }
    return sumDiagonal;
}

int sizeM = ReadNum("Enter massive size m:"!);
int sizeN = ReadNum("Enter massive size n:"!);
double[,] array = CreateMass(sizeM, sizeN);

Console.WriteLine($"Двумерный массив размером {sizeM} X {sizeN} заполненный вещественными числами:");
PrintMass(array);
Console.WriteLine();

// double[] CreateArray(int lenght, int hightest)
// {
//     Random rndm = new Random();
//     double[] array = new double[lenght];
//     for (int i = 0; i < array.Length; i++)
//         array[i] = rndm.NextDouble() * (hightest + 1);
//     return array;
// }

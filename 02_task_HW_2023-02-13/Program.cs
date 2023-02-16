// 02_task_HW_2023-02-13
// Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.Clear();
Console.WriteLine("Задать двумерный массив следующим правилом: A(m,n) = m+n" !);
Console.WriteLine();

void PrintMass(int[,] massive)
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

int[,] CreateMass(int sizeM, int sizeN )
{   
    int[,] massive = new int[sizeM, sizeN];
    Random rnd = new Random();
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i , j] = i + j;
        }
    }
    return massive;
}

int ReadNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int sizeM = ReadNum("Enter massive size m:"!);
int sizeN = ReadNum("Enter massive size n:"!);
int[,] array = CreateMass(sizeM, sizeN);

Console.WriteLine($"Двумерный массив размером {sizeM} X {sizeN} заданный следующим правилом: A(m,n) = m+n:");
PrintMass(array);
Console.WriteLine();

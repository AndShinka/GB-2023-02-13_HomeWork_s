//03_task_HW_2023-02-13
// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.Clear();
Console.WriteLine("В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты" !);
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
    Random random = new Random();
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i , j] = random.Next(1, 11);
        }
    }
    return massive;
}

int[,] QuadratEvenIndex(int[,] massive)
{   
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            //Console.WriteLine($"i = {i} \t j = {j} \t massive[i , j] = {massive[i , j]}" !);
            if (i %2 == 0 && j %2==0 )
                {massive[i , j] = massive[i , j] * massive[i , j];
                //Console.WriteLine($"massive[i , j] = {massive[i , j]}" !);
                }
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

Console.WriteLine($"Создан двумерный массив размером {sizeM} X {sizeN} заполненый числами от 0 до 10:" !);
PrintMass(array);
Console.WriteLine();

Console.WriteLine($"Результат замены в двумерном массиве {sizeM} X {sizeN} элементов, у которых оба индекса чётные на их квадраты:" !);
PrintMass(QuadratEvenIndex(array));
Console.WriteLine();


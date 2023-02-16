// 04_task_HW_2023-02-13
// Написать программу, которая обменивает элементы первой строки и последней строки
Console.Clear();
Console.WriteLine("Программа, которая обменивает элементы первой строки и последней строки" !);
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

int[,] ChangeString(int[,] massive)
{   
    int temp = 0;
    int lastJ = massive.GetLength(0) - 1;
    for (int i = 0; i < massive.GetLength(1); i++)
    {
        //Console.WriteLine($"massive[i , 0] = {massive[i , 0]} \t massive[i , lastJ]  = {massive[i , lastJ] }" !);
        temp = massive[0 , i];
        massive[0 , i] = massive[lastJ, i];
        massive[lastJ, i] = temp;
        //Console.WriteLine($"massive[i , 0] = {massive[i , 0]} \t massive[i , lastJ]  = {massive[i , lastJ] }" !);
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

Console.WriteLine($"Результат замены в двумерном массиве {sizeM} X {sizeN} элементов первой строки и последней строки:" !);
PrintMass(ChangeString(array));
Console.WriteLine();



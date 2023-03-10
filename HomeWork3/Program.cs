// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}

void SumСolumns(int[,] array, int cols)
{
    Console.WriteLine($"\n Среднее арифметическое столбцов: ");

    for (int j = 0; j < array.GetLength(1); j++)
    {

        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++) // Перебераю строки текущего столбца
        {
            sum += array[i, j]; 
        }

        Console.Write("{0:  0.00}", (double)sum / cols); //делю сумму на число столбцов.

    }
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
SumСolumns(array, cols);


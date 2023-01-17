// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int[rows,cols ];
// FillArray(array);
// PrintArray(array);


// void FillArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j] = new Random().Next(-10,11);
// }

// void PrintArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j],3} \t");
//         Console.WriteLine();
//     }
// }


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int[rows,cols ];
// FillArray(array);
// PrintArray(array);


// void FillArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j] = i + j;                //!!!!!!!!!!!!!!!
// }

// void PrintArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j], 3}"); // !!!!!!!!!!!!!!!!
//         Console.WriteLine();
//     }
// }

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int[rows,cols ];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Cheach(array);
// PrintArray(array);


// void FillArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j] = new Random().Next(-10,0);
// }

// void PrintArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j],3} \t");
//         Console.WriteLine();
//     }
// }

// void Cheach(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//         for (int j=0;j<array.GetLength(1);j++)
//             if (i % 2 != 0 && j % 2 != 0)
//                 array[i,j] = array[i,j] * array[i,j];
// }


// Задача 51: Задайте двумерный квадратный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); 
// (1;1) и т.д.
// Например, задан массив:
// 1 4 7 
// 5 9 2 
// 8 4 2 
// Сумма элементов главной диагонали: 1+9+2 = 12
// найдите сумму элементов обратной диагонали


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3} \t");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 10);
// }




// int[,] array = new int[3, 3];
// FillArray(array);
// PrintArray(array);
// SummDiag(array);

// void SummDiag(int[,] array)
// {
//     int summ = 0;
//     for (int i = 0, j = 0; i < array.GetLength(0); i++, j++)
//     {
//         {
//         summ = summ + array[i, j];

//         }

//     }

//     Console.WriteLine(summ);
// }


// **Задача HARD SORT необязательная. Считается за три обязательных** 
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10




// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3} \t");
//         Console.WriteLine();
//     }
// }


// void Replace(int[,] array)
// {
//     int min = array[0, 0];
//     int temp = 0;
//     int x = 0;
//     int y = 0;
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             if (min < array[i, j])
//             {
//                 temp = min;
//                 array[i, j] = array[x, y]
//                 x++; y++
//             }
//         }

//     }
// }



Задача 51: Задайте двумерный квадратный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 
5 9 2 
8 4 2 
Сумма элементов главной диагонали: 1 + 9 + 2 = 12
найдите сумму элементов обратной диагонали

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов по диагонали: {Diag(array)}");
Console.WriteLine($"Сумма элементов по обратной: {MainDiag(array)}");


int MainDiag(int[,] array)  // обратная даиг
{
    int sum1 = 0;
    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == (array.GetLength(1) - 1) - j)  // 8[2.0] 9[1.1] 7[0.2]
            {
                sum1 = sum1 + array[i, j];
            }

        }
    return sum1;
}


int Diag(int[,] array)  // прямая диаг
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum = sum + array[i, j]; //1[0.0] 9[1.1] 2[2.2]
        }
    return sum;

}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 11);
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
// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Write("Введите строку:");
int line = Convert.ToInt32(Console.ReadLine()) - 1; // пишу - 1 чтобы начать поиск с 0го элемента массива 
Console.Write("Введите столбец:");
int column = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5; // количество строк массива
int m = 5; // количество столбцов массива
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Таблица поиска:"); 

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(10, 99);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}
if (line < 0 | line > arr.GetLength(0) - 1 | column < 0 | column > arr.GetLength(1) - 1) 
// вычисляю существует ли элемент используя логическое ИЛИ.
// если хотябы одно из условий верно то на консоль выводится сообщение, такого что элемента не существует
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[line, column]); 
    // если результат if будет false то элемент существует в рамках массива и в консоль выводится результат поиска
}
Console.ReadLine();

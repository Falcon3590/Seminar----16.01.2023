// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите значения m и n в строку через пробел и нажмите ввод ");
string[] num = Console.ReadLine().Split(' ');
int m = Convert.ToInt32(num[0]);
int n = Convert.ToInt32(num[1]);
Console.WriteLine($" Количество строк = {m}; Количество столбцов = {n}");

double[,] arr = new double[m, n];

Random random = new Random(100);

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = random.NextDouble() * 10; // получаю случайное вещественное число в диапазоне от 0 до 1.
                                              // умножаю результат на 10 чтобы получить целую часть.
        Console.Write("{0,5:F1}", arr[i, j]);
    }
    Console.WriteLine();
}



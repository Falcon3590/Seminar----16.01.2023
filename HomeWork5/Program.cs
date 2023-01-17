// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара

// 1. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное. 

// 2. Вывести на экран красивенько таблицей. 

// 3. Перемешать случайным образом элементы массива, причем чтобы каждый элемент гарантированно и только один раз 
// переместился на другое место и выполнить перемешивание за m*n / 2 итераций. 

// 4. То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.

var m = 0;
var n = 0;
do
{
    Console.Write("Введите значения m и n ( m*n должно быть четным числом) в строку через пробел и нажмите ввод ");
    string[] num = Console.ReadLine().Split(' ');
    m = Convert.ToInt32(num[0]);
    n = Convert.ToInt32(num[1]);
}
while ((m * n) % 2 != 0);


int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
MixArray(array, m, n);


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
    Console.WriteLine();
}

void MixArray(int[,] array, int m, int n)
{
    var rnd = new Random();
    for (var i = 0; i < m * n / 2; i++)
    {
        int r1 = rnd.Next(0, array.GetLength(0)),
            r2 = rnd.Next(0, array.GetLength(0)),
            c1 = rnd.Next(0, array.GetLength(1)),
            c2 = rnd.Next(0, array.GetLength(1));
        int temp = array[r1, c1];
        array[r1, c1] = array[r2, c2];
        array[r2, c2] = temp;
    }
    PrintArray(array);
}



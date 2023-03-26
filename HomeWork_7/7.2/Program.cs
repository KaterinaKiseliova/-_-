// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

string FindElement(int[,] arr, int m, int n)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (m > row || m <= 0 || n > column || n <= 0)
        return $"{m} {n} -> нет в массиве";
    return $"число[{m}, {n}] = {arr[m - 1, n - 1]} -> есть в массиве";
}

System.Console.WriteLine("Введите количество строк:");
int row_num = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количество столбцов:");
int column_num = int.Parse(Console.ReadLine()!);

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(row_num, column_num, start, stop);

Print(mass);

System.Console.WriteLine("Введите положение строки:");
int first = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите положение столбца:");
int second = int.Parse(Console.ReadLine()!);

string answer = FindElement(mass, first, second);
Console.WriteLine(answer);

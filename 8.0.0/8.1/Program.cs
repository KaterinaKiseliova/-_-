// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнююстроку массива.

int[,] FillMassive(int row, int column, int from, int to)
{
    int[,] mass = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        {
            mass[i, j] = new Random().Next(from, to);
        }
    return mass;
}
void PrintArray(int[,] array)
{
    int RowLength = array.GetLength(0);
    int ColumnLength = array.GetLength(1);

    for (int i = 0; i < RowLength; i++)
    {
        for (int j = 0; j < ColumnLength; j++)
        {
            System.Console.WriteLine($"{array[i, j]}");
        }
        System.Console.WriteLine();
    }
}
void ReplaceIndex(int[,] array)
{
    int ArrayRow = array.GetLength(0);
    int ArrayColumn = array.GetLength(1);

    for (int j = 0; j < ArrayColumn; j++)
    {
        (array[0, j], array[ArrayRow - 1, j]) = (array[ArrayRow - 1, j], array[0, j]);
    }
}
System.Console.WriteLine("Введите количество строк:");
int row = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количество столбцов:");
int column = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите начальное значение:");
int from = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите конечное значение:");
int to = int.Parse(Console.ReadLine()!);

int[,] mass = FillMassive(row, column, from, to);
PrintArray(mass);
System.Console.WriteLine();
ReplaceIndex(mass);
PrintArray(mass);
//  Задайте двумерный массив. Напишите программу,
//    которая заменяет строки на столбцы. В случае, если это невозможно,
//    программа должна вывести сообщение для пользователя.

// https://ru.wikihow.com/%D1%82%D1%80%D0%B0%D0%BD%D1%81%D0%BF%D0%BE%D0%BD%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D1%82%D1%8C-%D0%BC%D0%B0%D1%82%D1%80%D0%B8%D1%86%D1%83

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
            Console.WriteLine($"{array[i, j]}");
        }
        Console.WriteLine();
    }
}
bool check(int row, int column)
{
  bool result = row ! == column;
  return result;  
}
string RowToColumn(int[,]array)
{
    if(check(array.GetLength(0),array.GetLength(1)))return" нет";
    for (int i = 1; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < i; j++)
        {
          (array[i,j],array[j,i] ) = (array[j,i],array[i,j]);
        }
    }
   PrintArray(array); 
    return"Да";
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
string result = RowToColumn(mass);
Console.WriteLine(result);
PrintArray(mass);

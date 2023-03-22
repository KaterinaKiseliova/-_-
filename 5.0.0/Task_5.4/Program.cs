// Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
//123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
void Print(int[] arr)
{
int size = arr.Length;

for (int i = 0; i < size; i++)
Console.Write($"{arr[i]} ");
Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
int[] arr = new int[size];

for (int i = 0; i < size; i++)
arr[i] = new Random().Next(from, to);
return arr;
}


int RetNum(int[] Mass, int from, int to)

{
int count = 0;
for (int i = 0; i < Mass.Length; i++)
{
if (Mass[i] >= from & Mass[i] <= to)
count = count + 1;

}
return count;
}


int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

int first = int.Parse(Console.ReadLine()!);
int sec = int.Parse(Console.ReadLine()!);

int result = RetNum(mass, first, sec);

Console.WriteLine(result);
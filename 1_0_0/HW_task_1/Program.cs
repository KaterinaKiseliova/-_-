//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a < b)
{
    Console.Write($"Число {a} меньше числа {b}");
}
else if (a == b)
{
    Console.Write($"Число {a} равно числу {b}");   
}
else
{
    Console.Write($"Число {b} меньше числа {a}");
}
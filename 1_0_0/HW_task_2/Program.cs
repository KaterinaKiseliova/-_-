
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этиConsole.WriteLine("Введите первое число:");
int n_1 = int.Parse(Console.ReadLine()!);
int n_2 = int.Parse(Console.ReadLine()!);
int n_3 = int.Parse(Console.ReadLine()!);

if (n_1 > n_2)
{
    if (n_1 > n_3)
    {
Console.WriteLine("Максимальное число:" + n_1);
    }
    else
    {
Console.WriteLine("Максимальное число:" + n_3);
    }
}
 else if (n_2 > n_3)
{
 Console.WriteLine("Максимальное число:" + n_2);   
}
else
{
Console.WriteLine("Максимальное число:" + n_3);    
}
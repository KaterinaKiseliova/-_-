
internal class Program
{
    private static void Main(string[] args)
    {
        // Задайте значения M и N. Напишите программу, которая выведет все
        //чётные натуральные числа в промежутке от M до N с помощью рекурсии.
        //M = 1; N = 5 -> "2, 4"
        //M = 4; N = 8 -> "4, 6, 8"
        System.Console.Write("Введите первое число: ");
        int Num = int.Parse(Console.ReadLine()!);
        System.Console.Write("Введите второе число: ");
        int Num2 = int.Parse(Console.ReadLine()!);

        void NaturalEven(int m, int n)
        {
            if (m > n) return;
            if (m % 2 == 0)
            {
                System.Console.Write($"{m},");
            }
            NaturalEven(m + 1, n);

        }
        NaturalEven(Num, Num2);
    }
}
//  Напишите программу, которая выводит
//случайное трёхзначное число и удаляет вторую цифру
//этого числа.
//456 -> 46
//782 -> 72
//918 -> 98
string SecondNum(int num)
{
    if ((-1000 < num && num < -99)|| (num < 1000 && num > 99));
        return $"{num} -> {num / 100 * 10 + num % 10}";
    return "The number is not three-digit!";

}
Console.WriteLine(SecondNum(int.Parse(Console.ReadLine()!)));

//  Напишите программу, которая принимает
//на вход трёхзначное число и на выходе
//показывает последнюю цифру этого числа.
Console.WriteLine("Введите ваше число");
int num = new Random().Next(100, 1000);

Console.WriteLine(num);
Console.WriteLine(num % 10);


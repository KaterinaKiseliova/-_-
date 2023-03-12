// : Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
void Weekend(int num)
{
    string text = "no";

    if (num == 7 || num == 6) text = "weekend";
    else if (num < 6 && num > 0) text = "workday";
    else text = "not quite a week";
    Console.WriteLine($"{num} ->{text}");
}

Weekend(int.Parse(Console.ReadLine()!));
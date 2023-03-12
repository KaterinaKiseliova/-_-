// Напишите программу, которая принимает на вход
//число и проверяет, кратно ли оно одновременно 7 и 23
int N = int.Parse(Console.ReadLine()!);


void Div(int N)
    {
        if (N % 7 == 0 & N % 23 == 0)
            Console.WriteLine("кратно");
        else
            Console.WriteLine("некратно " );


}
Div(N);
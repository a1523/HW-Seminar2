//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void Task1(int numb)
{
    int result = (numb/10)%10;
    Console.WriteLine(result);
}

Console.WriteLine("Введите трехзначное число: ");
int x = int.Parse(Console.ReadLine());
Task1(x);

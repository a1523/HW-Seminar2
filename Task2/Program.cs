//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


void Task2(string number)
{
if (number.Length > 2)
{
    Console.WriteLine($"Третья цифра числа {number[2]}");
}
else
{
    Console.WriteLine("Третьей цифры в числе нет");
}
}

Console.WriteLine("Введите число: ");
string number = Convert.ToString(Console.ReadLine());
Task2(number);
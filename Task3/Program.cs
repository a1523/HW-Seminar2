// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

void Task3(int numb)
{
    if (numb >= 1 & numb <=5) 
    {
        Console.WriteLine("Это рабочий день!");
    }
    else if (numb == 6 || numb == 7) 
    {
        Console.WriteLine("Это выходной день!");
    }
    else 
    {
        Console.WriteLine("Нет соответствия дню недели. Используйте целые числа от 1 до 7!");
    }
}

Console.WriteLine("Напишите цифру, обозначающую день недели: ");
try
{
    int numb = int.Parse(Console.ReadLine());
    Task3(numb);
}
catch
{
    Console.WriteLine("Нет соответствия дню недели. Используйте целые числа от 1 до 7!");
}

    


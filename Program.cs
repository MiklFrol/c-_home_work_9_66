// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int getDataFromUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int getSumRange(int start, int finish)
{
    if (start == finish)
    {
        return start;
    }
    return start + getSumRange(start + 1, finish);
}

int userNumberStart = getDataFromUser("Введите значение начала ряда");
int userNumberFinish = getDataFromUser("Введите значение конца ряда");
int start = Math.Min(userNumberStart, userNumberFinish);
int finish = Math.Max(userNumberStart, userNumberFinish);
int sum = getSumRange(userNumberStart, userNumberFinish);
Console.WriteLine(sum);


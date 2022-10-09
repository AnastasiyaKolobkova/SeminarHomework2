// Задача 1. 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

bool SecondNum(int n)
{
    if(n >= 100 && n < 1000)
    {
        Console.WriteLine(n % 100 / 10);
    }
    else
    {
        Console.WriteLine("Uncorrect input!");
    }
    return false;
}

Console.Write("Input a three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
SecondNum(n);

// Задача 2.  
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdDigit(string num)
{
    if (num.Length > 2)
    {
    Console.WriteLine("Third number " + num[2]);
    }
    else
    {
    Console.WriteLine("No third digit");
    }
}

Console.Write("Input a digit: ");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);
ThirdDigit(num);

// Задача 3. 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOfTheWeek(int dayNum)
{
    if (dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine("Day off");
    }
    else
    {
        if (dayNum < 1 || dayNum  > 7)
        {
            Console.WriteLine("Not a day of the week");
        }
        else
        {
            Console.WriteLine("Not a day off");
        }
    }
}

Console.Write("Input a digit: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
DayOfTheWeek(dayNum);
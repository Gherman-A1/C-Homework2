//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(6 -> да; 7 -> да; 1 -> нет)
Console.Write("Введите порядковый номер дня недели: ");
int number = int.Parse(Console.ReadLine()!);

bool ValidateWeekday(int num)
{
    if(num<1||num>7)
    {
      Console.WriteLine("Это не день недели");
      return false;
    }
    else
    {
        return true;
    }
}

if(ValidateWeekday(number))
{
    if (number<6) 
    {
      Console.WriteLine("Этот день не выходной");
    }
    else
    {
      Console.WriteLine("Выходной");
    }
}


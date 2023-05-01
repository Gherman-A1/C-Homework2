//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.(645 -> 5; 78 -> третьей цифры нет; 32679 -> 6)
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

bool ValidateNumber(int num)
{
    if(num<100)
    {
      Console.WriteLine("Третьей цифры нет");
      return false;
    }
    else if(num>999)
    {
      Console.WriteLine("Число четырехзначное и более");
      return false;
    }
    else
    {
      return true;
    }
}

int ThirdNum(int numb)
{
int result=numb%10;
return result;
}

if(ValidateNumber (number)) 
{
int thirdnumber=ThirdNum(number);
Console.WriteLine("Третья цифра числа: "+thirdnumber);
}
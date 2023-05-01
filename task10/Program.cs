// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.(456 -> 5; 782 -> 8; 918 -> 1)
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

bool ValidateNumber(int num)
{
    if(num<100||num>999)
    {
      Console.WriteLine("Число не трехзначное");
      return false;
    }
    else
    {
        return true;
    }
}

int SecondNum(int numb)
{
int result=(numb/10)%10;
return result;
}

if(ValidateNumber(number))
{
int secondnumber=SecondNum(number);
Console.WriteLine("Вторая цифра числа: "+secondnumber);
}
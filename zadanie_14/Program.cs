int delenie(int number1)
{
    int result = number1 % 7;
    int result1 = number1 % 23;
    int r;
    if ((result > 0) | (result1 > 0))
    { 
        r = 0;
     //   Console.WriteLine(r);
    }
    else 
    {
        r = 1;
     //    Console.WriteLine(r);
    }
    return r;
}

Console.WriteLine("введите число");
int number1 = int.Parse(Console.ReadLine());

int answer = delenie (number1);
if (answer == 1) 
{
  Console.WriteLine("да");  
}
if (answer == 0) 
{
Console.WriteLine("нет");
}

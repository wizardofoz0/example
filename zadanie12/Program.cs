

int delenie(int number1, int number2)
{
    int result = number1 % number2;
    return result;
}

Console.WriteLine("введите число 1");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("введите число 2");
int number2 = int.Parse(Console.ReadLine());

int digit = delenie (number1, number2);
if (digit > 0) 
{
    Console.WriteLine($"Не кратно, остаток {digit}");
}
else 
{
    Console.WriteLine($"Кратно");
}
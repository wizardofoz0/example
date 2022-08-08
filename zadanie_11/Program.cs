int GetMaxDeletefromNumber(int number3)
{
    int result = number3 / 100;
    int result1 = number3 % 10;
    int result2 = result *10 + result1;
    System.Console.WriteLine(result1 );
    return result2;
}
int number3 = new Random().Next(100, 1000);
int maxDigit = GetMaxDeletefromNumber(number3);
Console.WriteLine($"Из числа {number3} получили {maxDigit}");
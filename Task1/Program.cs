int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsBetween(int number, int min, int max)
{
    return number >= min && number <= max;
}

int number = ReadInt("Введите пятизначное число: ");
int min = 10000, max = 99999;

if (IsBetween(number, min, max))
{
    int fifthDigit = number % 10;
    int firstDigit = number / 10000;
    int fourthDigit = number / 10 % 10;
    int secondDigit = number / 1000 % 10;

    if (fifthDigit == firstDigit && fourthDigit == secondDigit)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Число не пятизначное!");
}
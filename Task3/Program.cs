int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число: ");

if (number < 1)
{
    Console.WriteLine("Число должно быть больше или равно 1!");
}
else
{
    int i = 1;
    while (i < number)
    {
        Console.Write(i * i * i + ", ");
        i++;
    }
    Console.Write(i * i * i);
}
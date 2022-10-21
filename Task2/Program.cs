int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Введите X точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int z1 = ReadInt("Введите Z точки A: ");

int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");
int z2 = ReadInt("Введите Z точки B: ");

int sqrLengthX = (x2 - x1) * (x2 - x1);
int sqrLengthY = (y2 - y1) * (y2 - y1);
int sqrLengthZ = (z2 - z1) * (z2 - z1);

double distance = Math.Round(Math.Sqrt(sqrLengthX + sqrLengthY + sqrLengthZ), 2, MidpointRounding.AwayFromZero);

Console.WriteLine("Расстояние равно: " + distance);
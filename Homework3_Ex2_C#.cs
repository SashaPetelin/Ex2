Console.WriteLine("Please enter x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int length = (int)Math.Sqrt(Math.Pow(GetDelta(x1, x2), 2) + Math.Pow(GetDelta(y1, y2), 2) + Math.Pow(GetDelta(z1, z2), 2));

Console.Write("Расстояние между двумя точками = ");
Console.Write(length);

int GetDelta(int num1, int num2)
{
    int delta = num1 - num2;
    return delta;
}
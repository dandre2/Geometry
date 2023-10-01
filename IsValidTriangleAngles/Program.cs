// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Enter value for angle 1");
int Angle1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Enter value for angle 2");
int Angle2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Enter angle 3");
int Angle3 = int.Parse(Console.ReadLine());

Console.WriteLine(IsPythagoreanTriple(Angle1, Angle2, Angle3));
if (IsPythagoreanTriple(Angle1, Angle2, Angle3))
{
    Console.WriteLine($"When Angle one is {Angle1} and the second Angle is {Angle2}, Angle3 equals {Angle3} it is a pythogorean triple ");
}
else
{
    Console.WriteLine($"The values are not a pythagorean triple");
}
static bool IsPythagoreanTriple(int Angle1, int Angle2, int Angle3)
{
    if (Angle1 <= 0 || Angle2 <= 0 || Angle3 <= 0)
    {
        return false;
    }
    // if leg 3 is the longest
    if (Angle3 > Angle1 && Angle3 > Angle2)
    {
        return Angle1 + Angle2 + Angle3 == 180;
    }

    // if leg 2 is the longs
    if (Angle2 > Angle1 && Angle2 > Angle3)
    {
        return Angle1 + Angle2 + Angle3 == 180;
    }

    // if leg 1 is the longeast
    if (Angle1 > Angle2 && Angle1 > Angle3)
    {
        return Angle1 + Angle2 + Angle3 == 180;
    }
    return false;
}


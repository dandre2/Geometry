// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Enter value for angle 1");
int Angle1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Enter value for angle 2");
int Angle2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Enter angle 3");
int Angle3 = int.Parse(Console.ReadLine());

Console.WriteLine(IsValidAngles(Angle1, Angle2, Angle3));
if (IsValidAngles(Angle1, Angle2, Angle3))
{
    Console.WriteLine($"When Angle one is {Angle1} and the second Angle is {Angle2}, Angle3 equals {Angle3} it is a valid triangle angle sum ");
}
else
{
    Console.WriteLine($"The values are not a triangle angle sum");
}
static bool IsValidAngles(int Angle1, int Angle2, int Angle3)
{
    if (Angle1 <= 0 || Angle2 <= 0 || Angle3 <= 0)
    {
        return false;
    }
    

        return Angle1 + Angle2 + Angle3 == 180;

}


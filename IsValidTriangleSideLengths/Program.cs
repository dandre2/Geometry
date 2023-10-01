// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"Enter value for leg 1");
int legOne = int.Parse(Console.ReadLine());
Console.WriteLine($"Enter value for leg 2");
int legTwo = int.Parse(Console.ReadLine());
Console.WriteLine($"Enter leg 3");
int Hypotenuse = int.Parse(Console.ReadLine());

Console.WriteLine(IsPythagoreanTriple(legOne, legTwo, Hypotenuse));
if (IsPythagoreanTriple(legOne, legTwo, Hypotenuse))
{
    Console.WriteLine($"When leg one is {legOne} and the second leg is {legTwo}, hypotenuse equals {Hypotenuse}, and it is a pythogorean triple ");
}
else
{
    Console.WriteLine($"The values are not a pythagorean triple");
}
static bool IsPythagoreanTriple(int legOne, int legTwo, int legThree)
{
    if (legOne <= 0 || legTwo <= 0 || legThree <= 0)
    {
        return false;
    }
    // if leg 3 is the longest
    if (legThree > legOne && legThree > legTwo)
    {
        return legOne * legOne + legTwo * legTwo == legThree * legThree;
    }

    // if leg 2 is the longs
    if (legTwo > legOne && legTwo > legThree)
    {
        return legOne * legOne + legThree * legThree == legTwo * legTwo;
    }

    // if leg 1 is the longeast
    if (legOne > legTwo && legOne > legThree)
    {
        return legTwo * legTwo + legThree * legThree == legOne * legOne;
    }
    return false;
}

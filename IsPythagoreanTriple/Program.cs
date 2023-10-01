Console.WriteLine($"Enter value for leg 1");
int legOne = ExceptionHandlingForIntegers();
Console.WriteLine($"Enter value for leg2");
int legTwo = ReadIntegerFromConsole();
Console.WriteLine($"Enter hypotenuse length");
int Hypotenuse = ReadIntegerFromConsole();


Console.WriteLine(IsPythagoreanTriple(legOne, legTwo, Hypotenuse));
if (IsPythagoreanTriple(legOne, legTwo, Hypotenuse))
{
    Console.WriteLine($"When leg one is {legOne} and the second leg is {legTwo}, hypotenuse equals {Hypotenuse}, and it is a pythogorean triple ");
}
else
{
    Console.WriteLine($"The values are not a pythagorean triple");
}

static int ExceptionHandlingForIntegers()
{
    int output = -1;
    while (output < 0)
    {
        output = ReadIntegerFromConsole();
    }
    return output;
}
static int ReadIntegerFromConsole()
{
    try
    {
        return int.Parse(s: Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return -1;
    }

}
static bool IsPythagoreanTriple(int legOne, int legTwo, int legThree)
{
    if (legOne <= 0 || legTwo <= 0 || legThree <= 0)
    {
        return false;
    }

    if (legThree > legOne && legThree > legTwo)
    {
        return legOne * legOne + legTwo * legTwo == legThree * legThree;
    }

    if (legTwo > legOne && legTwo > legThree)
    {
        return legOne * legOne + legThree * legThree == legTwo * legTwo;
    }
    if (legOne > legTwo && legOne > legThree)
    {
        return legTwo * legTwo + legThree * legThree == legOne * legOne;
    }
    return false;
}

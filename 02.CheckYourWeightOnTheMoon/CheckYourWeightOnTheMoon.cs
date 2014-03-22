using System;

class CheckYourWeightOnTheMoon
{
    static void Main()
    {
        int earthWeightOne = 86;
        double earthWeightTwo = 74.6;
        double earthWeightThree = 53.7;
        double moonConstantGravity = 0.17;
        Console.WriteLine(earthWeightOne*moonConstantGravity);
        Console.WriteLine(earthWeightTwo*moonConstantGravity);
        Console.WriteLine(earthWeightThree*moonConstantGravity);
    }
}


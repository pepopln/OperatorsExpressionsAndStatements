using System;
class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Is it odd?");
        Console.WriteLine();

        int firstN = 3;
        Console.WriteLine(firstN % 2 == 1);

        int secondN = 2;
        Console.WriteLine(secondN % 2 == 1);

        int thirdN = -2;
        Console.WriteLine(thirdN % 2 == 1);

        int fourthN = 1;
        Console.WriteLine(fourthN % 2 == 1);

        int fifthN = 0;
        Console.WriteLine(fifthN % 2 == 1);
    }
}


using System;

class ExtractBit3
{
    static void Main()
    {
        int position = 3;
        Console.WriteLine("Examples 5,15,5343");

        int number = 5;
        int nRightP = number >> position;
        int lastBit = nRightP & 1;
        Console.WriteLine(lastBit);

        int number0 = 15;
        int nRightP0 = number0 >> position;
        int lastBit0 = nRightP0 & 1;
        Console.WriteLine(lastBit0);

        int number1 = 5343;
        int nRightP1 = number1 >> position;
        int lastBit1 = nRightP1 & 1;
        Console.WriteLine(lastBit1);

    }
}


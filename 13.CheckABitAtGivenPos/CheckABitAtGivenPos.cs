using System;

    class CheckABitAtGivenPos
    {
        static void Main()
        {
            Console.WriteLine("Examples 5,15,62241");

            int pTwo = 2;
            int number = 5;
            int nRightP = number >> pTwo;
            int lastBitTwo = nRightP & 1;
            bool isItOne = lastBitTwo == 1;
            Console.WriteLine(isItOne);

            int pOne = 1;
            int number0 = 15;
            int nRightP0 = number0 >> pOne;
            int lastBit0 = nRightP0 & 1;
            bool isItOne0 = lastBit0 == 1;
            Console.WriteLine(isItOne0);

            int pEleven = 11;
            int number1 = 62241;
            int nRightP1 = number1 >> pEleven;
            int lastBit1 = nRightP1 & 1;
            bool isItOne1 = lastBit1 == 1;
            Console.WriteLine(isItOne1);
        }
    }


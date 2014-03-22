using System;

class PrimeNumberCheck
{
    static void Main()
    {
        uint myInt = uint.Parse(Console.ReadLine());
        bool isPrime = (myInt <= 2 ? true : myInt % 2 != 0) &&
            (myInt <= 3 ? true : myInt % 3 != 0) &&
            (myInt <= 4 ? true : myInt % 4 != 0) &&
            (myInt <= 5 ? true : myInt % 5 != 0) &&
            (myInt <= 6 ? true : myInt % 6 != 0) &&
            (myInt <= 7 ? true : myInt % 7 != 0) &&
            (myInt <= 8 ? true : myInt % 8 != 0) &&
            (myInt <= 9 ? true : myInt % 9 != 0) &&
            (myInt <= 10 ? true : myInt % 10 != 0);

        Console.WriteLine(isPrime);
    }

}
    


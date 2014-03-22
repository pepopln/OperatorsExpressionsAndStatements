using System;

class FourDigitNumber
{
    static void Main()
    {
        int number = 2011;
        int d = number % 10;
        int c = (number / 10) % 10;
        int b = (number / 100) % 10;
        int a = (number / 1000) % 10;
        Console.WriteLine("Sum is {0}", d + c + b + a);
        Console.WriteLine("Reverse is {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Last digit in front:{0}{1}{2}{3} ", d, a, b, c);
        Console.WriteLine("Second and third digits exchange: {0}{1}{2}{3}", a, c, b, d);
    }
}


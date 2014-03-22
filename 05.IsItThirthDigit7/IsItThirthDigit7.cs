using System;
    class IsItThirthDigit7
    {
        static void Main(string[] args)
        {
            int n = 701;
            bool number = ((n / 100) % 10 == 7);
            Console.WriteLine(number);

            int n1 = 7;
            bool number1 = ((n1 / 100) % 10 == 7);
            Console.WriteLine(number1);
        }
    }


using System;

    class TrapezoidsArea
    {
        static void Main()
        {
            var a = 8.5;
            var b = 4.3;
            var h = 2.7;
            var area = h * (a + b) / 2;
            Console.WriteLine("Area is {0}",area);

            var a1 = 5;
            var b1 = 7;
            var h1 = 12;
            var area1 = h1 * (a1 + b1) / 2;
            Console.WriteLine("Area is {0}", area1);
        }
    }


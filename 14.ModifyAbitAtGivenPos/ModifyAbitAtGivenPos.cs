using System;

    class ModifyAbitAtGivenPos
    {
        static void Main()
        {
            int n = 0;
            byte v = 1;
            int p = 9;
            int mask = ~(v << p);
            int result = n & mask;
            Console.WriteLine(result);

            int n0 = 0;
            byte v0 = 1;
            int p0 = 9;
            int mask0 = (v0 << p0);
            int result0 = n0 | mask0;
            Console.WriteLine(result0);

            int n1 = 62241;
            byte v1 = 0;
            int p1 = 11;
            int mask1 = ~(v1 << p1);
            int result1 = n1 & mask1;
            Console.WriteLine(result1);

        }
    }


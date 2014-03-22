using System;

class DivideBy7And5
{
    static void Main()
    {
        int n0=3;
        bool divide0 = (n0 % 5==0) &&( n0 % 7==0);
        Console.WriteLine(divide0);
        int n1 = 0;
        bool divide1 = (n1 % 5 == 0) && (n1 % 7 == 0)||(n1!=0);
        Console.WriteLine(divide1);
        int n2 = 5;
        bool divide2 = (n2 % 5 == 0) && (n2 % 7 == 0);
        Console.WriteLine(divide2);
        int n3 = 7;
        bool divide3 = (n3 % 5 == 0) && (n3 % 7 == 0);
        Console.WriteLine(divide3);
        int n4 = 35;
        bool divide4 = (n4 % 5 == 0) && (n4 % 7 == 0);
        Console.WriteLine(divide4);
        int n5 = 140;
        bool divide5 = (n5 % 5 == 0) && (n5 % 7 == 0);
        Console.WriteLine(divide5);
    }
}


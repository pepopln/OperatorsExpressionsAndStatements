using System;

class PointInACircle
{
    static void Main()
    {
        int r = 2;
        int xK = 0;
        int yK = 0;

        int x0 = 0;
        int y0 = 1;
        bool formula0 = (x0 - xK) * (x0 - xK) + (y0 - yK) * (y0 - yK) < r * r;
        Console.WriteLine(formula0);

        int x1 = -1;
        int y1 = 2;
        bool formula1 = (x1 - xK) * (x1 - xK) + (y1 - yK) * (y1 - yK) < r * r;
        Console.WriteLine(formula1);

        double x2 = 1.655;
        int y2 = 1;
        bool formula2 = (x2 - xK) * (x2 - xK) + (y2 - yK) * (y2 - yK) < r * r;
        Console.WriteLine(formula2);
    }
}

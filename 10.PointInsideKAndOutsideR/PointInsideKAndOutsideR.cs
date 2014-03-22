using System;

class PointInsideKAndOutsideR
{
    static void Main()
    {
        var r = 1.5;
        var xK = 1;
        var yK = 1;

        var x0 = 1;
        var y0 = 2;

        var xRStart = 1;
        var xREnd = 5;
        var yRStart = -1;
        var yREnd = 1;
        bool formulaK = (x0 - xK) * (x0 - xK) + (y0 - yK) * (y0 - yK) < r * r;
        bool formulaR = (x0 <= xRStart || x0 >= xREnd) && (y0 <= yRStart || y0 >= yREnd);
        string output = (formulaK == true) && (formulaR == true) ? "yes" : "no";
        Console.WriteLine(output);
    }
}


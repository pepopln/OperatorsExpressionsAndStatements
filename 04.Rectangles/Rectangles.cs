using System;
class Rectangles
{
    static void Main()
    {
        int width = 3;
        int height = 4;
        int perimeter = (width + height) * 2;
        int area = width * height;
        Console.WriteLine("Perimeter is {0} and Area is {1}", perimeter, area);

        double secondWidth = 2.5;
        int secondHeight = 3;
        double secondPerimeter = (secondWidth + secondHeight) * 2;
        double secondArea = secondWidth * secondHeight;
        Console.WriteLine("Perimeter is {0} and Area is {1}", secondPerimeter, secondArea);

        int thirdWidth = 5;
        int thirdHeight = 5;
        int thirdPerimeter = (thirdWidth + thirdHeight) * 2;
        int thirdArea = thirdWidth * thirdHeight;
        Console.WriteLine("Perimeter is {0} and Area is {1}", thirdPerimeter, thirdArea);


    }
}


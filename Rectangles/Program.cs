using System;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = new Point[] 
            {
                new Point(2, 8),
                new Point(2, 2),
                new Point(7, 7),
                new Point(2, 10),
                new Point(2, 11),
                new Point(4, 11),
                new Point(5, 10),
                new Point(5, 8),
                new Point(4, 8),
                new Point(5, 3),
                new Point(5, 5),
                new Point(9, 5), 
                new Point(9, 3), 
                new Point(4, 12) 
            };
            int count = RectanglesCounter.CountRectangles(points);
            Console.WriteLine($"Number of rectangles: {count}");
        }
    }
}

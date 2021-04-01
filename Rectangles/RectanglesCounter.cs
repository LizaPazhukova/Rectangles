using System;
using System.Linq;

namespace Rectangles
{
    public static class RectanglesCounter
    {
        public static int CountRectangles(Point[] points)
        {
            var count = 0;
            if (points.Length < 4)
            {
                return count;
            }
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    Point p1 = points[i];
                    Point p2 = points[j];

                    if (p1.X == p2.X || p1.Y == p2.Y)
                        continue;

                    Point p3 = new Point(p1.X, p2.Y);
                    Point p4 = new Point(p2.X, p1.Y);

                    if (points.Contains(p3) && points.Contains(p4))
                    {
                        count++;
                    }
                }
            }

            return count / 2;
        }
    }
}

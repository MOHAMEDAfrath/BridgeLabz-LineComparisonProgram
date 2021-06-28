using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem!");
            //for loop to get input coordinates for two line
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Enter the coordinates of Line " + i + " (x1,y1,x2,y2): ");
                int xPoint1 = int.Parse(Console.ReadLine());
                int yPoint1 = int.Parse(Console.ReadLine());
                int xPoint2 = int.Parse(Console.ReadLine());
                int yPoint2 = int.Parse(Console.ReadLine());
                double lengthLine1 = Math.Round(Program.findLength(xPoint1, yPoint1, xPoint2, yPoint2), 2);
                Console.WriteLine("Length of Line "+i+" is " +lengthLine1);
            }
        }

        //static function to compute the length
        public static double findLength(int x1, int y1, int x2, int y2)
        {
            double lineLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return lineLength;
        }
    }
}

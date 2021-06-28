using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem!");
            //Intialising a double  array to store length of two lines
            double[] lengthArray = new double[3];
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
                //storing length in array
                lengthArray[i] = lengthLine1;
            }
            Program.checkEquality(lengthArray[1].ToString(), lengthArray[2].ToString());
        }
        //static function that uses Equals method to compare lengths
        public static void checkEquality(string length1, string length2)
        {
            if (length1.Equals(length2))
            {
                Console.WriteLine("The Lines are at equal length: "+length1);
            }
            else
            {
                Console.WriteLine("The Lines are not at equal length: L1: "+length1+ " L2: "+length2);
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

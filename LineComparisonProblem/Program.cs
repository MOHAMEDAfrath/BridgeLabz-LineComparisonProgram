using System;

namespace LineComparisonProblem
{
    class Program
    {
        /// <summary>
        /// UC1: Find the length between points.
        /// UC2: Find the Equality of lines.
        /// UC3: Find the line which is greater or smaller
        /// </summary>
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
                Console.WriteLine("Length of Line " + i + " is " + lengthLine1);
                //storing length in array
                lengthArray[i] = lengthLine1;
            }
          
            while(true)
            {
                Console.WriteLine("Enter 0 to check equality / Enter 1 to compare Lines/ Enter 2 to Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Program.checkEquality(lengthArray[1].ToString(), lengthArray[2].ToString());
                        break;
                    case 1:
                        Program.comparingTheLines(lengthArray[1].ToString(), lengthArray[2].ToString());
                        break;
                    case 2:
                        return;
                    default:
                        break;

                }
            }
        }
        public static void comparingTheLines(string length1, string length2)
        {
            if(length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("The Line1 with length "+length1+ " is greater than Line2 with length "+length2);
            }else if(length1.CompareTo(length2) < 0)
            {
                Console.WriteLine("The Line2 with length " + length2 + " is greater than Line1 with length " + length1);
            }
            else
            {
                Console.WriteLine("Both Lines are of same length");
            }

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

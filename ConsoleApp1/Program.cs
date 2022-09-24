using System;
namespace FirstApplication
{
    public class Logic
    {
        public static string Compare (double circleRadius, double sideOfaSquare) 
        {
            string outMessage = "";
            double circleS = Math.Pow(circleRadius, 2) * Math.PI;
            double SquareS = Math.Pow(sideOfaSquare, 2);
            if (Math.Abs(circleS - SquareS) >= 0.000000000001)
            {
                if (circleS > SquareS)
                {
                    outMessage = "Площадь Круга больше площади квадрата";
                }

                else if (circleS < SquareS)
                {
                    outMessage = "Площадь Круга меньше площади квадрата";
                }
            }
            else
            {
                    outMessage = "Площадь Круга и площадь квадрата равны";
            }
            return outMessage;
        }
    }
    internal class Programm 
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Введите радиус круга-");
            double circleRadius = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата-");
            double sideOfaSquare = double.Parse(Console.ReadLine());

            var outMessage= Logic.Compare(circleRadius, sideOfaSquare);
            Console.WriteLine(outMessage);
            Console.ReadLine();
        }
    }
}


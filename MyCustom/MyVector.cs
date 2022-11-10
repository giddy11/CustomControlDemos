using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustom
{
    public class MyVector
    {

        public MyVector()
        {
            //X = 0;
            //Y = 0;
            //Z = 0;
        }
        public MyVector(double x, double y)
        {
            X = x;
            Y = y;
        }

        private double GetLengthOfVector()
        {
            double squaredElement = (X * X) + (Y * Y);
            double length = Math.Sqrt(squaredElement);
            return length;
        }

        public static MyVector Add(MyVector myVector1, MyVector myVector2)
        {
            var xAxis = myVector1.X + myVector2.X;
            var yAxis = myVector1.Y + myVector2.Y;
            var additionOfTwoVectors = new MyVector(xAxis, yAxis);
            return additionOfTwoVectors;
        }


        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }




        public double X { get; set; }
        public double Y { get; set; }
        public double LengthOfVector
        {
            get
            {
                return GetLengthOfVector();
            }
        }
    }
}

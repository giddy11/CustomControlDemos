using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomClasses
{
    public class MyCustomVector
    {
        public MyCustomVector()
        {
            //X = 0;
            //Y = 0;
            //Z = 0;
        }
        public MyCustomVector(double x, double y)
        {
            XAxis = x;
            YAxis = y;
        }

        private double GetLengthOfVector()
        {
            double squaredElement = (XAxis * XAxis) + (YAxis * YAxis);
            double length = Math.Sqrt(squaredElement);
            return length;
        }



        public static MyCustomVector Add(MyCustomVector myVector1, MyCustomVector myVector2)
        {
            var xAxis = myVector1.XAxis + myVector2.XAxis;
            var yAxis = myVector1.YAxis + myVector2.YAxis;
            var additionOfTwoVectors = new MyCustomVector(xAxis, yAxis);
            return additionOfTwoVectors;
        }

        public double XAxis { get; set; }
        public double YAxis { get; set; }
        public double LengthOfVector
        {
            get
            {
                return GetLengthOfVector();
            }
        }
    }
}

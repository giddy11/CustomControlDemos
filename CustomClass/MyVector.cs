using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomClass
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

        //public override string ToString()
        //{
        //    return $"[{X}, {Y}]";
        //}

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

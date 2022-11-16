using System.Numerics;

namespace CustomClasses
{
    public struct MyVector
    {

        public MyVector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double GetLengthOfVector()
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

        public static MyVector operator +(MyVector a, MyVector b)
        {
            return MyVector.Add(a, b);
        }

        public static MyVector Subtract(MyVector myVector1, MyVector myVector2)
        {
            var xAxis = myVector1.X - myVector2.X;
            var yAxis = myVector1.Y - myVector2.Y;
            var subtractionOfTwoVectors = new MyVector(xAxis, yAxis);
            return subtractionOfTwoVectors;
        }

        public static MyVector operator -(MyVector a, MyVector b)
        {
            return MyVector.Subtract(a, b);
        }

        public static double AngleBetween(MyVector myVector1, MyVector myVector2)
        {
            double product = Multiply(myVector1, myVector2);
            double magnitude = myVector1.LengthOfVector * myVector2.LengthOfVector;
            double divide = product / magnitude;
            double angle = Math.Acos(divide) / (Math.PI / 180);
            return angle;
        }

        //this is also the dot product
        public static double Multiply(MyVector myVector1, MyVector myVector2)
        {
            return (myVector1.X * myVector2.X) + (myVector1.Y * myVector2.Y);
        }

        //public static double operator *(MyVector myVector1, MyVector myVector2)
        //{
        //    return MyVector.Multiply(myVector1, myVector2);
        //}

        public static MyVector operator *(double factor, MyVector myVector)
        {
            myVector.ScalarMultiplication(factor);
            return myVector;
        }

        //public static MyVector operator /(MyVector myVector, double factor)
        //{

        //    myVector.ScalarDivision(factor);
        //    return myVector;
        //}

        public void ScalarMultiplication(double factor)
        {
            X *= factor;
            Y *= factor;
        }

        public void ScalarDivision(double factor)
        {
            X /= factor;
            Y /= factor;
        }
        public void Normalize()
        {
            var len = LengthOfVector;
            X = X / len;
            Y = Y / len;
        }
        public static double CrossProduct(MyVector myVector1, MyVector myVector2)
        {
            var cross1 = myVector1.X * myVector2.Y;
            var cross2 = myVector1.Y * myVector2.X;
            var crossProduct = cross1 - cross2;
            return crossProduct;
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
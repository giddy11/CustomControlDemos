using System.Numerics;

namespace CustomStructs
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
            return Math.Round(Math.Sqrt(squaredElement), 2);
        }

        public static MyVector operator +(MyVector myVector1, MyVector myVector2)
        {
            var xAxis = myVector1.X + myVector2.X;
            var yAxis = myVector1.Y + myVector2.Y;
            var additionOfTwoVectors = new MyVector(xAxis, yAxis);
            return additionOfTwoVectors;
        }

        public static MyVector operator - (MyVector myVector1, MyVector myVector2)
        {
            var xAxis = myVector1.X - myVector2.X;
            var yAxis = myVector1.Y - myVector2.Y;
            var subtractionOfTwoVectors = new MyVector(xAxis, yAxis);
            return subtractionOfTwoVectors;
        }

        public static double AngleBetween(MyVector myVector1, MyVector myVector2)
        {
            double product = myVector1 * myVector2;
            double magnitude = myVector1.LengthOfVector * myVector2.LengthOfVector;
            double divide = product / magnitude;
            double angle =Math.Round(Math.Acos(divide) / (Math.PI / 180), 2);
            return angle;
        }

        //this is also the dot product
        public static double operator * (MyVector myVector1, MyVector myVector2)
        {
            return (myVector1.X * myVector2.X) + (myVector1.Y * myVector2.Y);
        }

        public static MyVector operator *(double factor, MyVector myVector)
        {
            myVector.ScalarMultiplication(factor);
            return myVector;
        }

        public static MyVector operator /(MyVector myVector, double factor)
        {

            myVector.ScalarDivision(factor);
            return myVector;
        }

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
            X = Math.Round((X / len),1);
            Y = Math.Round((Y / len), 1);
            var result = new MyVector(X, Y);
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
        public double LengthSquared
        {
            get
            {
                return Math.Pow(LengthOfVector, 2);
            }
        }
    }
}
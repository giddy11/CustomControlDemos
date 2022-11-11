// See https://aka.ms/new-console-template for more information

public struct MyVector
{
   
    public MyVector(double x, double y)
    {
        XCordinates = x;
        YCordinates = y;
    }

    #region Calculate Length Of Vector
    private double GetLengthOfVector()
    {
        double squaredElement = (XCordinates * XCordinates) + (YCordinates * YCordinates);
        double length = Math.Sqrt(squaredElement);
        return length;
    }
    #endregion



    #region Addition Method with + operator overload
    public static MyVector Add(MyVector myVector1, MyVector myVector2)
    {
        var xAxis = myVector1.XCordinates + myVector2.XCordinates;
        var yAxis = myVector1.YCordinates + myVector2.YCordinates;
        var additionOfTwoVectors = new MyVector(xAxis, yAxis);
        return additionOfTwoVectors;
    }

    public static MyVector operator +(MyVector a, MyVector b)
    {
        return MyVector.Add(a, b);
    }
    #endregion

    #region Subtraction Method with - operator overload
    public static MyVector Subtract(MyVector myVector1, MyVector myVector2)
    {
        var xAxis = myVector1.XCordinates - myVector2.XCordinates;
        var yAxis = myVector1.YCordinates - myVector2.YCordinates;
        var subtractionOfTwoVectors = new MyVector(xAxis, yAxis);
        return subtractionOfTwoVectors;
    }

    public static MyVector operator -(MyVector a, MyVector b)
    {
        return MyVector.Subtract(a, b);
    }
    #endregion


    #region Angle Between
    public static double AngleBetween(MyVector myVector1, MyVector myVector2)
    {
        double product = Multiply(myVector1, myVector2);
        double magnitude = myVector1.LengthOfVector * myVector2.LengthOfVector;
        double divide = product / magnitude;
        double angle = Math.Acos(divide);
        return angle;
    } 
    #endregion

    #region Multiplication Method with * operator overload
    public static double Multiply(MyVector myVector1, MyVector myVector2)
    {
        return (myVector1.XCordinates * myVector2.XCordinates) + (myVector1.YCordinates * myVector2.YCordinates);
    }

    public static double operator * (MyVector myVector1, MyVector myVector2)
    {
        return MyVector.Multiply(myVector1, myVector2);
    }

    public static MyVector operator * (double factor, MyVector myVector)
    {
        myVector.ScalarMultiplication(factor);
        return myVector;
    }

    public static MyVector operator / (MyVector myVector, double factor)
    {

        myVector.ScalarDivision(factor);
        return myVector;
    }

    public void ScalarMultiplication(double factor)
    {
        XCordinates *= factor;
        YCordinates *= factor;
    }

    public void ScalarDivision(double factor)
    {
        XCordinates /= factor;
        YCordinates /= factor;
    }

    #endregion

    public void Normalize()
    {
        XCordinates = XCordinates / LengthOfVector;
        YCordinates = YCordinates / LengthOfVector;
    }


    #region Cross Product Method
    public static double CrossProduct(MyVector myVector1, MyVector myVector2)
    {
        var cross1 = myVector1.XCordinates * myVector2.YCordinates;
        var cross2 = myVector1.YCordinates * myVector2.XCordinates;
        var crossProduct = cross1 - cross2;
        return crossProduct;
    } 
    #endregion


    public override string ToString()
    {
        return $"[{XCordinates}, {YCordinates}]";
    }

    #region Properties
    public double XCordinates { get; set; }
    public double YCordinates { get; set; }
    public double LengthOfVector
    {
        get
        {
            return GetLengthOfVector();
        }
    } 
    #endregion
}
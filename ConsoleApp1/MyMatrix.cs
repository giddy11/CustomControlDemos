namespace ConsoleApp1
{
    public struct MyMatrix
    {

        public MyMatrix(double m11, double m12, double m21, double m22, double offsetX, double offsetY)
        {
            M11 = m11;
            M12 = m12;
            M21 = m21;
            M22 = m22;
            OffsetX = offsetX;
            OffsetY = offsetY;
        }

        //let the first matrix be denotd as a and the second matrix be denoted as b
        public static  MyMatrix Multiply (MyMatrix a, MyMatrix b)
        {   
            var ab11 = (a.M11 * b.M11) + (a.M12 * b.M21) + 0;
            var ab12 = (a.M11 * b.M12) + (a.M12 * b.M22) + 0;

            var ab21 = (a.M21 * b.M11) + (a.M22 * b.M21) + 0;
            var ab22 = (a.M21 * b.M12) + (a.M22 * b.M22) + 0;

            var abX = (a.OffsetX * b.M11) + (a.OffsetY * b.M21) + (1 * b.OffsetX) ;
            var abY = (a.OffsetX * b.M12)+ (a.OffsetY * b.M22)+ (1 * b.OffsetY);

            var matrix = new MyMatrix(ab11, ab12, ab21, ab22, abX, abY);
            return matrix;
        }

        public MyMatrix ScaleAt (MyMatrix matrix1, MyMatrix matrix2)
        {
            //return Multiply(matrix1, matrix2);
            return matrix1 * matrix2;
        }

        public MyMatrix Scale(double scaleX, double scaleY)
        {
            var scaleMatrix = new MyMatrix(scaleX, 0, 0, scaleY, 0, 0);
            return scaleMatrix;
        }

        public MyMatrix Translate (double dx, double dy)
        {
            var translateMatrix = new MyMatrix(1, 0, 0, 1, dx, dy);
            return translateMatrix;
        }

        public MyMatrix TranslateAt(MyMatrix matrix1, MyMatrix matrix2)
        {
            //return ScaleAt(matrix1, matrix2);
            return matrix1 * matrix2;
        }

        public static MyMatrix operator * (MyMatrix matrix1, MyMatrix matrix2)
        {

            var multiply = Multiply(matrix1, matrix2);
            return multiply;
        }

        public MyMatrix Rotate(double angle)
        {
            angle = angle * Math.PI / 180;
            var rotateAngle = new MyMatrix(Math.Cos(angle), Math.Sin(angle), -Math.Sin(angle), Math.Cos(angle), 0, 0);
            return rotateAngle;
        }

        public MyMatrix RotateAt(MyMatrix matrix1, MyMatrix matrix2)
        {
            return matrix1 * matrix2;
        }


        //public double Determinant { get; }
        //public bool HasInverse { get; }
        //public bool IsIdentity { get; }
        public double M11 { get; set; }
        public double M12 { get; set; }
        public double M21 { get; set; }
        public double M22 { get; set; }
        public double OffsetX { get; set; }
        public double OffsetY { get; set; }
    }
}

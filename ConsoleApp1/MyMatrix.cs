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

        #region Multiplication
        //let the first matrix be denotd as a and the second matrix be denoted as b
        public static MyMatrix Multiply(MyMatrix a, MyMatrix b)
        {
            var ab11 = (a.M11 * b.M11) + (a.M12 * b.M21) + 0;
            var ab12 = (a.M11 * b.M12) + (a.M12 * b.M22) + 0;

            var ab21 = (a.M21 * b.M11) + (a.M22 * b.M21) + 0;
            var ab22 = (a.M21 * b.M12) + (a.M22 * b.M22) + 0;

            var abX = (a.OffsetX * b.M11) + (a.OffsetY * b.M21) + (1 * b.OffsetX);
            var abY = (a.OffsetX * b.M12) + (a.OffsetY * b.M22) + (1 * b.OffsetY);

            var matrix = new MyMatrix(ab11, ab12, ab21, ab22, abX, abY);
            return matrix;
        }
        #endregion

        #region Scale
        public MyMatrix ScaleAt(MyMatrix matrix1, double x, double y)
        {
            var matrix2 = new MyMatrix(x, M12, M21, y, OffsetX, OffsetY);
            return matrix1 * matrix2;
        }

        public MyMatrix ScalePrepend(MyMatrix matrix1, double x, double y)
        {
            var matrix2 = new MyMatrix(x, M12, M21, y, OffsetX, OffsetY);
            return matrix2 * matrix1;
        }
        #endregion

        #region Translation
        public MyMatrix TranslatePrepend(MyMatrix matrix1, double dx, double dy)
        {
            OffsetX += dx;
            OffsetY += dy;
            var matrix2 = new MyMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            return matrix2 * matrix1;
        }

        public MyMatrix TranslateAt(MyMatrix matrix1, double dx, double dy)
        {
            OffsetX += dx;
            OffsetY += dy;
            var matrix2 = new MyMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            return matrix1 * matrix2;
        }
        #endregion

        #region Operator Overloads
        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {

            var multiply = Multiply(matrix1, matrix2);
            return multiply;
        }

        //public static bool operator == (MyMatrix matrix1, MyMatrix matrix2)
        //{

        //    return matrix1.OffsetX == matrix2.OffsetX;

            
        //}
        #endregion

        #region Rotation
        public MyMatrix RotatePrepend(double angle, MyMatrix matrix1)
        {
            angle = angle * Math.PI / 180;
            var rotateAngle = new MyMatrix(Math.Cos(angle), Math.Sin(angle), -Math.Sin(angle), Math.Cos(angle), OffsetX, OffsetY);
            return rotateAngle * matrix1;
        }

        public MyMatrix RotatePrepend(double angle, double x, double y, MyMatrix matrix1)
        {
            angle = angle * Math.PI / 180;
            var rotateAngle = new MyMatrix(Math.Cos(angle), Math.Sin(angle), -Math.Sin(angle), Math.Cos(angle), x, y);
            return rotateAngle * matrix1;
        }

        public MyMatrix RotateAt(double angle, double x, double y, MyMatrix matrix1)
        {
            angle = angle * Math.PI / 180;
            var rotateAngle = new MyMatrix(Math.Cos(angle), Math.Sin(angle), -Math.Sin(angle), Math.Cos(angle), x, y);
            return matrix1 * rotateAngle;
        }
        #endregion

        #region Skew
        public MyMatrix SkewAt(double angleX, double angleY, MyMatrix matrix1)
        {
            angleX = angleX * Math.PI / 180;
            angleY = angleY * Math.PI / 180;
            var skewAngle = new MyMatrix(1, Math.Tan(angleY), Math.Tan(angleX), 1, OffsetX, OffsetY);
            return matrix1 * skewAngle;
        }

        public MyMatrix SkewPrepend(double angleX, double angleY, MyMatrix matrix1)
        {
            angleX = angleX * Math.PI / 180;
            angleY = angleY * Math.PI / 180;
            var skewAngle = new MyMatrix(1, Math.Tan(angleY), Math.Tan(angleX), 1, OffsetX, OffsetY);
            return skewAngle * matrix1;
        }
        #endregion

        public MyMatrix MatrixInvert()
        {
            var determinant = DeterminantOfMatrix();

            var a11 = M11 / determinant;
            var a12 = M12 / determinant;
            var a21 = M21 / determinant;
            var a22 = M22 / determinant;
            var ax = OffsetX / determinant;
            var ay = OffsetY / determinant;

            var newMatrix = new MyMatrix(a11, a12, a21, a22, ax, ay);

            return newMatrix;
        }

        #region Transformation
        public static double[,] TransformMatrixToArray(MyMatrix matrix)
        {
            double[,] arrayMatrix = new double[3, 3];

            arrayMatrix[0, 0] = matrix.M11;
            arrayMatrix[1, 0] = matrix.M21;
            arrayMatrix[2, 0] = matrix.OffsetX;

            arrayMatrix[0, 1] = matrix.M12;
            arrayMatrix[1, 1] = matrix.M22;
            arrayMatrix[2, 1] = matrix.OffsetY;

            arrayMatrix[0, 2] = 0;
            arrayMatrix[1, 2] = 0;
            arrayMatrix[2, 2] = 1;


            return arrayMatrix;

        }

        public static MyMatrix TransformArrayToMatrix(double[,] arr)
        {
            return new MyMatrix(arr[0, 0], arr[0, 1], arr[1, 0], arr[1, 1], arr[2, 0], arr[2, 1]);
        } 
        #endregion

        public double DeterminantOfMatrix()
        {
            var determinant = (M11 * M22) - (M12 * M21);
            return determinant;
        }

        
        //private bool IsMatrixIdentity()
        //{
        //    MyMatrix matrix2 = new MyMatrix(1, 0, 0, 1, 0, 0);
        //    var matrix1 = new MyMatrix(M11, M12, M21, M22, OffsetX, OffsetY);

        //    if (matrix2 == matrix1)
        //    {
        //        return true;
        //    }
        //    return false;
        //}



        public double Determinant 
        {
            get
            {
                return DeterminantOfMatrix();
            } 
                
        }
        //public bool HasInverse { get; }
        //public bool IsIdentity
        //{
        //    get
        //    {
        //        return IsMatrixIdentity();
        //    }
        //}

        public double M11 { get; set; }
        public double M12 { get; set; }
        public double M21 { get; set; }
        public double M22 { get; set; }
        public double OffsetX { get; set; }
        public double OffsetY { get; set; }
    }
}

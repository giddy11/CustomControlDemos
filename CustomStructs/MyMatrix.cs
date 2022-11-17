namespace CustomStructs
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
        public static MyMatrix Multiply(MyMatrix a, MyMatrix b)
        {
            var ab11 = (a.M11 * b.M11) + (a.M12 * b.M21);
            var ab12 = (a.M11 * b.M12) + (a.M12 * b.M22);

            var ab21 = (a.M21 * b.M11) + (a.M22 * b.M21);
            var ab22 = (a.M21 * b.M12) + (a.M22 * b.M22);

            var abX = (a.OffsetX * b.M11) + (a.OffsetY * b.M21) + (1 * b.OffsetX);
            var abY = (a.OffsetX * b.M12) + (a.OffsetY * b.M22) + (1 * b.OffsetY);

            var matrix = new MyMatrix(ab11, ab12, ab21, ab22, abX, abY);
            return matrix;
        }



        public void Scale(double x, double y)
        {

            var matrix1 = new MyMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            var matrix2 = new MyMatrix(x, 0, 0, y, 0, 0);
            var result = Multiply(matrix1, matrix2);
            SetFromMatrix(result);
        }

        private void SetFromMatrix(MyMatrix result)
        {
            M11 = result.M11;
            M12 = result.M12;
            M21 = result.M21;
            M22 = result.M22;
            OffsetX = result.OffsetX;
            OffsetY = result.OffsetY;
        }

        public void ScalePrepend(double x, double y)
        {
            var matrix1 = new MyMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            var matrix2 = new MyMatrix(x, 0, 0, y, 0, 0);
            Multiply(matrix2, matrix1);
        }

        public void TranslatePrepend(double dx, double dy)
        {
            var matrix1 = new MyMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            var matrix2 = new MyMatrix(1, 0, 0, 1, dx, dy);
            Multiply(matrix2, matrix1);
        }

        public void TranslateAt(double dx, double dy)
        {
            var matrix1 = new MyMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            var matrix2 = new MyMatrix(1, 0, 0, 1, dx, dy);
            Multiply(matrix1, matrix2);
        }


        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {

            var multiply = Multiply(matrix1, matrix2);
            return multiply;
        }

        public void Rotate(double angle)
        {
            angle = angle * Math.PI / 180;
            var matrix1 = new MyMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            var matrix2 = new MyMatrix(Math.Cos(angle), Math.Sin(angle), -Math.Sin(angle), Math.Cos(angle), 0, 0);
            Multiply(matrix1, matrix2);
        }
        public void RotatePrepend(double angle)
        {
            var matrix1 = new MyMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            angle = angle * Math.PI / 180;
            var rotateAngle = new MyMatrix(Math.Cos(angle), Math.Sin(angle), -Math.Sin(angle), Math.Cos(angle), 0, 0);
            Multiply(rotateAngle, matrix1);
        }

        public void RotatePrepend(double angle, double x, double y)
        {
            var matrix1 = new MyMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            angle = angle * Math.PI / 180;
            var rotateAngle = new MyMatrix(Math.Cos(angle), Math.Sin(angle), -Math.Sin(angle), Math.Cos(angle), 0, 0);
            Multiply(rotateAngle, matrix1);
        }

        public void RotateAt(double angle, double x, double y)
        {
            var matrix1 = new MyMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            angle = angle * Math.PI / 180;
            var rotateAngle = new MyMatrix(Math.Cos(angle), Math.Sin(angle), -Math.Sin(angle), Math.Cos(angle), 0, 0);
            Multiply(matrix1, rotateAngle);
        }


        public void SkewAt(double angleX, double angleY)
        {
            var matrix1 = new MyMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            angleX = angleX * Math.PI / 180;
            angleY = angleY * Math.PI / 180;
            var skewAngle = new MyMatrix(1, Math.Tan(angleY), Math.Tan(angleX), 1, 0, 0);
            Multiply(matrix1, skewAngle);
        }

        public void SkewPrepend(double angleX, double angleY)
        {
            var matrix1 = new MyMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            angleX = angleX * Math.PI / 180;
            angleY = angleY * Math.PI / 180;
            var skewAngle = new MyMatrix(1, Math.Tan(angleY), Math.Tan(angleX), 1, 0, 0);
            Multiply(skewAngle, matrix1);
        }

        public void MatrixInvert()
        {
            var determinant = DeterminantOfMatrix();

            var a11 = M22;
            var a12  = M21;
            var a21 = M12;
            var a22 = M11;
            var offX =OffsetX;
            var offY = OffsetY;

            a11 = Math.Round(M22 / determinant, 1);
            a12 = Math.Round(-M21 / determinant, 1);
            a21 = Math.Round(-M12 / determinant, 1);
            a22 = Math.Round(M11 / determinant, 1);
            offX = 0;
            offY = 0;

            var adjoint = new MyMatrix(a11, a21, a12, a22, offX, offY);
            SetFromAdjoint(adjoint);

        }

        private void SetFromAdjoint(MyMatrix adjoint)
        {
            M11 = adjoint.M11;
            M12 = adjoint.M12;
            M21 = adjoint.M21;
            M22 = adjoint.M22;
            OffsetX= adjoint.OffsetX;
            OffsetY= adjoint.OffsetY;
        }

        public override string ToString()
        {
            return $"{M11},{M12},{M21},{M22},{OffsetX},{OffsetY}";
        }

        public double DeterminantOfMatrix()
        {
            var determinant = (M11 * M22) - (M12 * M21);
            return determinant;
        }

        public double Determinant
        {
            get
            {
                return DeterminantOfMatrix();
            }

        }

        public double M11 { get; set; }
        public double M12 { get; set; }
        public double M21 { get; set; }
        public double M22 { get; set; }
        public double OffsetX { get; set; }
        public double OffsetY { get; set; }
    }
}

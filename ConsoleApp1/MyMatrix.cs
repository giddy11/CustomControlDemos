namespace ConsoleApp1
{
    public struct MyMatrix
    {

        public MyMatrix(double m11, double m12, double m21, double m22, double offsetX, double offsetY) : this()
        {
            M11 = m11;
            M12 = m12;
            M21 = m21;
            M22 = m22;
            OffsetX = offsetX;
            OffsetY = offsetY;
        }


        public static double[,] Multiply(double[,] A, double[,] B)
        {
            double[,] C = new double[3, 3];
            double sumC = 0;
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    sumC = 0;
                    for (int j = 0; j < 3; j++)
                    {
                        sumC += A[i, j] * B[j, k];
                    }
                    C[i, k] = sumC;
                }
            }
            return C;
        }











        public double Determinant { get; }
        public bool HasInverse { get; }
        public bool IsIdentity { get; }
        public double M11 { get; set; }
        public double M12 { get; set; }
        public double M21 { get; set; }
        public double M22 { get; set; }
        public double OffsetX { get; set; }
        public double OffsetY { get; set; }
    }
}

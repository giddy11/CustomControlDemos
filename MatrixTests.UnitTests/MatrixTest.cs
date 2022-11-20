using CustomStructs;
using Xunit;

namespace MatrixTests.UnitTests
{
    public class MatrixTest
    {
        [Fact]
        public void ShouldMultiplyTwoMatrices()
        {
            // Arrange
            var matrix1 = new MyMatrix(1, 2, 3, 4, 0, 1);
            var matrix2 = new MyMatrix(0, 1, 2, 1, 0, 1);
            var expected = new MyMatrix(4, 3, 8, 7, 2, 2);

            // Act
            var actual = matrix1 * matrix2;

            // Assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void ShouldGetMatrixInvert()
        {
            // Arrange
            var actual = new MyMatrix(1, 2, 3, 4, 0, 0);
            var expected = new MyMatrix(-2, 1, 1.5, -0.5, 0, 0);

            // Act
            actual.MatrixInvert();

            // Assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void ShouldScaleMatrix()
        {
            // Arrange
            var matrix1 = new MyMatrix(1, 2, 3, 4, 0, 1);
            var expected = new MyMatrix(1, 1, 3, 2, 0, 0.5);

            // Act
            matrix1.Scale(1, 0.5);

            // Assert
            Assert.Equal(expected.ToString(), matrix1.ToString());
        }

        [Fact]
        public void ShouldScaleMatrixByPrepend()
        {
            // Arrange
            var matrix1 = new MyMatrix(1, 2, 3, 4, 0, 1);
            var expected = new MyMatrix(1,2,1.5,2,0,1);

            // Act
            matrix1.ScalePrepend(1, 0.5);

            // Assert
            Assert.Equal(expected.ToString(), matrix1.ToString());
        }

        [Fact]
        public void ShouldTranslateMatrix()
        {
            // Arrange
            var matrix1 = new MyMatrix(1, 2, 3, 4, 0, 1);
            var expected = new MyMatrix(1,2,3,4,1,1.5);

            // Act
            matrix1.TranslateAt(1, 0.5);

            // Assert
            Assert.Equal(expected.ToString(), matrix1.ToString());
        }

        [Fact]
        public void ShouldTranslateMatrixByPrepend()
        {
            // Arrange
            var matrix1 = new MyMatrix(1, 2, 3, 4, 0, 1);
            var expected = new MyMatrix(1,2,3,4,2.5,5);

            // Act
            matrix1.TranslatePrepend(1, 0.5);

            // Assert
            Assert.Equal(expected.ToString(), matrix1.ToString());
        }

        [Fact]
        public void ShouldRotateMatrix()
        {
            // Arrange
            var matrix1 = new MyMatrix(1, 2, 3, 4, 0, 1);
            var expected = new MyMatrix(-0.707, 2.121, -0.707, 4.95, -0.707, 0.707);

            // Act
            matrix1.Rotate(45);

            // Assert
            Assert.Equal(expected.ToString(), matrix1.ToString());
        }

        [Fact]
        public void ShouldRotateMatrixByPrepend()
        {
            // Arrange
            var matrix1 = new MyMatrix(1, 2, 3, 4, 0, 1);
            var expected = new MyMatrix(2.828, 4.243, 1.414, 1.414, 0, 1);

            // Act
            matrix1.RotatePrepend(45);

            // Assert
            Assert.Equal(expected.ToString(), matrix1.ToString());
        }

        [Fact]
        public void ShouldRotateMatrixAtPosition()
        {
            // Arrange
            var matrix1 = new MyMatrix(1, 2, 3, 4, 0, 1);
            var expected = new MyMatrix(-0.707, 2.121, -0.707, 4.949, 1, 0.586);

            // Act
            matrix1.RotateAt(45, 1, 2);

            // Assert
            Assert.Equal(expected.ToString(), matrix1.ToString());
        }

        [Fact]
        public void ShouldRotateMatrixAtPointsByPrepend()
        {
            // Arrange
            var matrix1 = new MyMatrix(1, 2, 3, 4, 0, 1);
            var expected = new MyMatrix(2.828, 4.242, 1.414, 1.414, 1.344, 3.93);

            // Act
            matrix1.RotateAtPrepend(45, 1, 2);

            // Assert
            Assert.Equal(expected.ToString(), matrix1.ToString());
        }

        [Fact]
        public void ShouldSkewMatrix()
        {
            // Arrange
            var matrix1 = new MyMatrix(1, 2, 3, 4, 0, 1);
            var expected = new MyMatrix(3, 2.577, 7, 5.732, 1, 1);

            // Act
            matrix1.SkewAt(45, 30);

            // Assert
            Assert.Equal(expected.ToString(), matrix1.ToString());
        }

        [Fact]
        public void ShouldSkewMatrixByPrepend()
        {
            // Arrange
            var matrix1 = new MyMatrix(1, 2, 3, 4, 0, 1);
            var expected = new MyMatrix(2.732, 4.309, 4, 6, 0, 1);

            // Act
            matrix1.SkewPrepend(45, 30);

            // Assert
            Assert.Equal(expected.ToString(), matrix1.ToString());
        }

        //public void ShouldTestForIdentity()
        //{
        //    // Arrange
        //    var matrix1 = new MyMatrix(1, 2, 3, 4, 0, 1);
        //    var matrix2 = new MyMatrix(1, 0, 0, 1, 0, 0);
        //    var expected = true;

        //    // Act
        //    MyMatrix.Equals(matrix1, matrix2);

        //    // Assert
        //    Assert.Equal(expected.ToString(), matrix1.ToString());
        //}
    }
}
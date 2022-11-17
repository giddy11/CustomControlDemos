using CustomClasses;
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
            var expected = new MyMatrix(-2, 1, 1.5, 0.5, 0, 0);

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
            var expected = new MyMatrix(1,1,3,2,0,0.5);

            // Act
            matrix1.Scale(1, 0.5);

            // Assert
            Assert.Equal(expected.ToString(), matrix1.ToString());
        }
    }
}
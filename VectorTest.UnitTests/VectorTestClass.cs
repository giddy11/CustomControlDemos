using CustomStructs;
using Xunit;

namespace VectorTest.UnitTests
{
    public class VectorTestClass
    {
        [Theory]
        [InlineData(4, 3, 5)]
        [InlineData(1.0, 2, 2.24)]
        public void ShouldGetLengthOfVector(double x, double y, double expected)
        {
            var vector = new MyVector(x, y);
            var actual = vector.LengthOfVector;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldAddVectors()
        {
            // Arrange
            var vector1 = new MyVector(2, 4);
            var vector2 = new MyVector(1, 3);
            var expected = new MyVector(3, 7);

            // Act
            MyVector actual = vector1 + vector2;

            // Assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void ShouldSubtractVectors()
        {
            // Arrange
            var vector1 = new MyVector(2, 4);
            var vector2 = new MyVector(1, 3);
            var expected = new MyVector(1, 1);

            // Act
            MyVector actual = vector1 - vector2;

            // Assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void ShouldGetAngleBetweenTwoVectors()
        {
            // Arrange
            var vector1 = new MyVector(20, 10);
            var vector2 = new MyVector(10, 20);
            var expected = 36.87;

            // Act
            var actual = MyVector.AngleBetween(vector1, vector2);

            // Assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void ShouldMultiplyTwoVectors()
        {
            // Arrange
            var vector1 = new MyVector(20, 10);
            var vector2 = new MyVector(10, 20);
            var expected = 400;

            // Act
            var actual = vector1 * vector2;

            // Assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void ShouldGetTheScalarMultiplication()
        {
            // Arrange
            var vector1 = new MyVector(20, 10);
            var expected = new MyVector(40, 20);

            // Act
            var actual = 2 * vector1;

            // Assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void ShouldGetTheScalarDivision()
        {
            // Arrange
            var vector1 = new MyVector(20, 10);
            var expected = new MyVector(10, 5);

            // Act
            var actual = vector1 / 2;

            // Assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void ShouldNormalizeVector()
        {
            // Arrange
            var actual = new MyVector(5, 3);
            var expected = new MyVector(0.9, 0.5);

            // Act
            actual.Normalize();

            // Assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }


        [Fact]
        public void ShouldGetCrossProductOfTwoVectors()
        {
            // Arrange
            var vector1 = new MyVector(20, 10);
            var vector2 = new MyVector(10, 20);
            var expected = 300;

            // Act
            var actual = MyVector.CrossProduct(vector1, vector2);

            // Assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }
    }
}
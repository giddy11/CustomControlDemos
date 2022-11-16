using CustomClasses;
using Xunit;

namespace VectorTest.UnitTests
{
    public class VectorTestClass
    {
        [Theory]
        [InlineData(4,3,5)]
        [InlineData(1,2, 2.23606797749979)]
        public void ShouldGetLengthOfVector(double x, double y, double expected)
        {
            var vector = new MyVector(x, y);
            var actual = vector.LengthOfVector;
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldAddVectors ()
        {
            // Arrange
            var vector1 = new MyVector(2, 4);
            var vector2 = new MyVector(1,3);
            var expected = new MyVector(3,7);

            // Act
            MyVector actual = MyVector.Add(vector1, vector2);

            // Assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }



    }
}
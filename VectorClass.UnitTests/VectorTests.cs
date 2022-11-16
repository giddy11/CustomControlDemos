using NUnit.Framework;
using CustomClasses;

namespace VectorClass.UnitTests
{
    public class VectorTests
    {
        [SetUp]
        public void Setup()
        {
            
        }
        
        // Act
        //[Test]
        [Theory]
        public void ShouldGetLengthOfVector()
        {
            var expected = 5;
            
            var vector = new MyVector(4, 3);
            var actual = vector.LengthOfVector;



            Assert.AreEqual(expected, actual);
        }
    }
}
using System;
using TDD_Demo;
using Xunit;

namespace xUnit_Test
{
    public class xUnit_MyMath
    {
        private MyMath myMath;
        public xUnit_MyMath()
        {
            myMath = new MyMath();
        }
        [Fact]
        public void Additional_001()
        {
            int result = myMath.Additional(10, 40);
            Assert.Equal(50, result);
            Assert.True(result == 50);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(0)]
        [InlineData(-10)]
        public void Additional_002(int value)
        {
            int result = myMath.Additional(10, value);
            Assert.Equal(10, result - value);
            Assert.True(result - value == 10);
        }
    }
}

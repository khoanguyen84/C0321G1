using NUnit.Framework;
using TDD_Demo;

namespace NUnit_Test
{
    public class Test_MyMath
    {
        private MyMath myMath;
        [SetUp]
        public void Setup()
        {
            myMath = new MyMath();
        }

        [Test]
        public void Additional_001()
        {
            int result = myMath.Additional(10, 20);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void Additional_002()
        {
            int result = myMath.Additional(10, 20);
            Assert.AreNotEqual(31,30);
        }

        [Test]
        public void Additional_003()
        {
            int result = myMath.Additional(10, 20);
            Assert.IsTrue(result == 30);
        }

        [TestCase(10)]
        [TestCase(100)]
        [TestCase(0)]
        [TestCase(-10)]
        public void Additional_004(int value)
        {
            int result = myMath.Additional(10, value);
            Assert.IsTrue((result - value) == 10);
        }

        [Test]
        public void Push_001()
        {
            int result = myMath.Push(5);
            Assert.AreEqual(myMath.Int_Arr.Length, result);
        }

        [Test]
        public void Push_002()
        {
            int[] arr = new int[] { 6, 7, 8, 9 };
            int result = 0;
            for (int i=0; i< arr.Length; i++)
            {
                result = myMath.Push(arr[i]);
            }
            
            Assert.AreEqual(myMath.Int_Arr.Length, result);
        }
    }
}

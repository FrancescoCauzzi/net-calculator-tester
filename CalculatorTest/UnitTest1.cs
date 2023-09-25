using net_calculator_tester;
namespace CalculatorTest
{
    [TestFixture]
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDivide()
        {
            float result = Calculator.Divide(144, 12);
            Assert.AreEqual(12, result);
        }

        [Test]
        public void TestDivideForZeroDivisor()
        {
            Assert.Throws<System.ArgumentException>(() => { Calculator.Divide(10, 0); },
            "Deve sollevare IllegalArgumentException per divisione per zero");
        }

        [Test]
        public void TestAdd()
        {
            float result = Calculator.Add(3, 4);  
            Assert.AreEqual(7, result); 
        }

        [Test]
        public void TestMultiply()
        {
            float result = Calculator.Multiply(3, 4);
            Assert.AreEqual(12, result);
        }
        [Test]
        public void TestMultiplyForZeroArgument() {
            float result = Calculator.Multiply(5, 0);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void TestMultiplyOverflow()
        {
            float result = Calculator.Multiply((float)float.MaxValue, 2);
            Assert.AreEqual(float.PositiveInfinity, result);
        }
        [Test]
        public void TestSubtract()
        {
            float result = Calculator.Subtract(-12, 18);
            Assert.AreEqual(-30, result);
        }
        

    }
}
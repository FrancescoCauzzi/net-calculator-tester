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
        // The constraint model is an alternative way to write assertions in NUnit that some find to be more readable and expressive. Instead of using methods like Assert.AreEqual(expected, actual), you use Assert.That(actual, Is.EqualTo(expected)). This model allows you to chain multiple constraints together in a more natural-language style.

        public void TestAdd()
        {
            float result = Calculator.Add(3, 4);  
            Assert.That(result, Is.EqualTo(7)); 
        }
        [Test]
        public void TestCommutativePropertyForAddition()
        {
            float a = 5;
            float b = 9;
            float result1 = Calculator.Add(a, b);
            float result2 = Calculator.Add(b, a);
            Assert.That(result2, Is.EqualTo(result1));
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
        // (a * b) * c = a * (b * c)
        [Test]
        public void TestMultiplicationAssociativeProperty()
        {
            float a = 12;
            float b = 9;
            float c = 5;
            float result1 = Calculator.Multiply(Calculator.Multiply(a, b),c);
            float result2 = Calculator.Multiply(a,Calculator.Multiply(b, c));
            Assert.That(result1, Is.EqualTo(result2));
        }

        [Test]
        public void TestSubtract()
        {
            float result = Calculator.Subtract(-12, 18);
            Assert.AreEqual(-30, result);
        }
        

    }
}
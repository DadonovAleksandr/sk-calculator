using CalculatorCore.Infrastructure;
using NUnit.Framework;

namespace CalculatorCoreTest
{
    public class DivTests
    {
        private Div instance;

        [SetUp]
        public void Setup() => instance = new();
        
        [Test]
        public void ResultTest()
        {
            double x = 1, y = 2; Assert.AreEqual(x/y, instance.Result(x,y));
            x = 1; y = -2; Assert.AreEqual(x/y, instance.Result(x,y));
            x = -1; y = 2; Assert.AreEqual(x/y, instance.Result(x,y));
            x = 1.0; y = -1.2; Assert.AreEqual(x/y, instance.Result(x,y));
            
        }
    }
    
    public class MultTests
    {
        private Mult instance;

        [SetUp]
        public void Setup() => instance = new();
        
        [Test]
        public void ResultTest()
        {
            double x = 1, y = 2; Assert.AreEqual(x*y, instance.Result(x,y));
            x = 1; y = -2; Assert.AreEqual(x*y, instance.Result(x,y));
            x = -1; y = 2; Assert.AreEqual(x*y, instance.Result(x,y));
            x = 1.0; y = -1.2; Assert.AreEqual(x*y, instance.Result(x,y));
            
        }
    }
    
    public class SumTests
    {
        private Sum instance;

        [SetUp]
        public void Setup() => instance = new();
        
        [Test]
        public void ResultTest()
        {
            double x = 1, y = 2; Assert.AreEqual(x+y, instance.Result(x,y));
            x = 1; y = -2; Assert.AreEqual(x+y, instance.Result(x,y));
            x = -1; y = 2; Assert.AreEqual(x+y, instance.Result(x,y));
            x = 1.0; y = -1.2; Assert.AreEqual(x+y, instance.Result(x,y));
            
        }
    }
    
    public class SubTests
    {
        private Sub instance;

        [SetUp]
        public void Setup() => instance = new();
        
        [Test]
        public void ResultTest()
        {
            double x = 1, y = 2; Assert.AreEqual(x-y, instance.Result(x,y));
            x = 1; y = -2; Assert.AreEqual(x-y, instance.Result(x,y));
            x = -1; y = 2; Assert.AreEqual(x-y, instance.Result(x,y));
            x = 1.0; y = -1.2; Assert.AreEqual(x-y, instance.Result(x,y));
            
        }
    }
}
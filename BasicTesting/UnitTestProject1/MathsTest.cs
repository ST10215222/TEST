using BasicTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class MathsTest
    {
        [TestMethod]
        public void TestPrint()
        {
            //arrange 
            string expected = "John Smith";

            //actual -- using basic testing under light bulb
            Maths math = new Maths();
            string actual = math.printMsg("John Smith");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
            
        public void TestaddVals()
        {
            int expected = 500;

            Maths math  = new Maths();
            int actual = math.addVals(400, 100);
            
            Assert.AreEqual(expected, actual);
            
        }
    }
}

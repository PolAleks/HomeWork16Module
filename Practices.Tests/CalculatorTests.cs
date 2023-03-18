using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Additional_40and60_MustReturn100()
        {
            int a = 40;
            int b = 60;
            int expected = 100;

            Calculator calc = new Calculator();
            int actual = calc.Additional(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtraction_100and50_MustReturn50()
        {
            int a = 100;
            int b = 50;
            int expected = 50;

            Calculator calc = new Calculator();
            int actual = calc.Subtraction(a, b);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Miltiplication_5and25_MustReturn125()
        {
            int a = 5;
            int b = 25;
            int expected = 125;

            Calculator calc = new Calculator();
            int actual = calc.Miltiplication(a, b);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Division_100and25_MustReturn4()
        {
            int a = 100;
            int b = 25;
            int expected = 4;

            Calculator calc = new Calculator();
            int actual = calc.Division(a, b);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Division_100and0_MustReturnDivideByZeroException()
        {
            int a = 100;
            int b = 0;
            
            Calculator calc = new Calculator();
            
            Assert.Throws<DivideByZeroException>(() => calc.Division(a, b));
        }
    }
}

using System.IO;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factorial.CLI;

namespace Factorial.Tests
{
    [TestClass]
    public class FactorialProgramTests
    {
        [TestMethod]
        public void Factorial_ShouldReturnFactorial_WhenAllParametersAreValid()
        {
            // Arrange
            uint number = 5, expectedFactorial = 120, actualFactorial;

            // Act
            actualFactorial = Program.Factorial(number);

            // Assert
            Assert.AreEqual(expectedFactorial, actualFactorial);
        }

        [TestMethod]
        public void Main_ShouldPrintFactorialToConsole_WhenAllParametersAreValid()
        {
            // Arrange
            string number = "5", expectedFactorial = "120\r\n";
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            Program.Main(new string[] { number });

            // Assert
            Assert.AreEqual(expectedFactorial, sw.ToString());
        }

        [TestMethod]
        public void Main_ShouldPrintUsageToConsole_WhenInputIsNotAnInteger()
        {
            // Arrange
            string input = "HelloWorld!!!", output = "Usage: Factorial <a positive integer>\r\n";
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            Program.Main(new string[] { input });

            // Assert
            Assert.AreEqual(output, sw.ToString());
        }

        [TestMethod]
        public void Main_ShouldPrintUsageToConsole_WhenArgsLengthIsZero()
        {
            // Arrange
            string expected = "Usage: Factorial <a positive integer>\r\n";
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            Program.Main(new string[] {  });

            // Assert
            Assert.AreEqual(expected, sw.ToString());
        }

        [TestMethod]
        public void Main_ShouldPrintUsageToConsole_WhenArgsLengthIsMoreThanOne()
        {
            // Arrange
            string[] args = new string[] { "1", "Hello", "World!!!" };
            string expected = "Usage: Factorial <a positive integer>\r\n";
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            Program.Main(args);

            // Assert
            Assert.AreEqual(expected, sw.ToString());
        }
    }
}
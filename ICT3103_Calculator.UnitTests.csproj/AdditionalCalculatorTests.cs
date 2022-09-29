using ICT3101_Calculator;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ICT3101_Calculator.Calculator;

namespace ICT3103_Calculator.UnitTests.csproj
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[3] { "42", "42","-21" });
            _calculator = new Calculator();
        }

        [Test]
        public void MagicNumberMock_WithPositiveNumber_ResultOfMagicCalculation()
        {
            double result = _calculator.GenMagicNum(1, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(84));
        }

        [Test]
        public void MagicNumberMock_WithNegativeNumber_ResultOfMagicCalculation()
        {
            double result = _calculator.GenMagicNum(2, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(42));
        }
    }
}

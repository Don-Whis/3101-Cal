using static ICT3101_Calculator.Calculator;

namespace ICT3101_Calculator
{
public class CalculatorTests
{
    private Calculator _calculator;
    private IFileReader _fileReader;
    [SetUp]
    public void Setup() //setup method is being called before any test executes
    {
        // Arrange = create the object
        _calculator = new Calculator();
        _fileReader = new FileReader();
    }

    [Test] 
    public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
    {
        double result = _calculator.Add(10, 20);
        Assert.That(result, Is.EqualTo(30)); 
    }

    [Test]
    public void Subtract_WhenSubtractTwoNumbers_ResultEqualToSubtract()
    {
        // Act = call the object to do smth
        double result = _calculator.Subtract(20, 10);
        // Assert (return true or false) 
        Assert.That(result, Is.EqualTo(10));
    }
    [Test]
    public void Multiply_WhenMultiplyTwoNumbers_ResultEqualToMultiply()
    {
        // Act = call the object to do smth
        double result = _calculator.Multiply(20, 10);
        // Assert (return true or false) 
        Assert.That(result, Is.EqualTo(200));
    }
    [Test]
    public void Divide_WhenDivideTwoNumbers_ResultEqualToDivide() //pass case
    {
        // Act = call the object to do smth
        double result = _calculator.Divide(20, 10);
        // Assert (return true or false) 
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    [TestCase(0, 10)]
    [TestCase(10, 0)]
    public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a,int b) //failed cases
    {
        Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
    }

    [Test]
    public void Factorial_WhenPerformFactorial_ResultOfFactorial() //pass case
    {
        // Act = call the object to do smth
        double result = _calculator.Factorial(5,5);
        // Assert (return true or false) 
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void Factorial_WhenPerformFactorial_ResultThrowArgumentException() //fail case
    {
        Assert.That(() => _calculator.Factorial(-2,0),Throws.ArgumentException);
    }

    //----------TDD--------------
    [Test]
    public void AreaOfTriangle_WhenCalculateArea_ResultEqualToArea()
    {
        // Act = call the object to do smth
        double result = _calculator.CalculateAreaOfTriangle(4, 5);
        // Assert (return true or false) 
        Assert.That(result, Is.EqualTo(10));
        }
        // [Test]
        // public void AreaOfCircle_WhenCalculateArea_ResultEqualToArea()
        // {
        //     // Act = call the object to do smth
        //     double result = _calculator.CalculateAreaOfCircle(5);
        //     // Assert (return true or false) 
        //     Assert.That(result, Is.EqualTo(75));
        // }

        [Test]
        public void AreaOfCircle_WhenCalculateArea_ResultEqualFailure()
        {
            Assert.That(() => _calculator.CalculateAreaOfCircle(-2), Throws.ArgumentException);
        }

        [Test]
        public void MagicNumber_WhenCalculation_ResultOfMagicCalculation()
        {
            double result = _calculator.GenMagicNum(2,_fileReader);
            // Assert (return true or false) 
            Assert.That(result, Is.EqualTo(64));
        }



    }
}
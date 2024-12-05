using NUnit.Framework;

namespace UserTicketService.Tests;
/// <summary>
/// Tests for the Calculator class.
/// </summary>
[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    [TestCase(2, 3, 5)]
    [TestCase(-1, -2, -3)]
    [TestCase(0, 5, 5)]
    public void Additional_ReturnsCorrectSum(int a, int b, int expected)
    {
        Assert.AreEqual(expected, _calculator.Additional(a, b));
    }

    [Test]
    [TestCase(5, 3, 2)]
    [TestCase(-1, -2, 1)]
    [TestCase(0, 5, -5)]
    public void Subtraction_ReturnsCorrectDifference(int a, int b, int expected)
    {
        Assert.AreEqual(expected, _calculator.Subtraction(a, b));
    }

    [Test]
    [TestCase(2, 3, 6)]
    [TestCase(-1, -2, 2)]
    [TestCase(0, 5, 0)]
    public void Multiplication_ReturnsCorrectProduct(int a, int b, int expected)
    {
        Assert.AreEqual(expected, _calculator.Multiplication(a, b));
    }

    [Test]
    [TestCase(6, 3, 2)]
    [TestCase(-10, 2, -5)]
    [TestCase(0, 1, 0)]
    public void Division_ReturnsCorrectQuotient(int a, int b, int expected)
    {
        Assert.AreEqual(expected, _calculator.Division(a, b));
    }

    [Test]
    public void Division_DivideByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Division(5, 0));
    }
}
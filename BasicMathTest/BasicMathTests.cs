namespace BasicMathTest;
using Lab7;

[TestClass]
public class BasicMathTests
{
    [TestMethod]
    public void AddTwoNumbers()
    {
        double number1 = 2;
        double number2 = 2;
        double expected = 4;

        double actual = BasicMath.Add(number1, number2);

        Assert.AreEqual(expected, actual, 0.001, "Numbers not added correctly");
    }
    [TestMethod]
    public void SubtractTwoNumbers()
    {
        double number1 = 10;
        double number2 = 2;
        double expected = 8;

        double actual = BasicMath.Subtract(number1, number2);

        Assert.AreEqual(expected, actual, 0.001, "Numbers not subtracted correctly");
    }
    [TestMethod]
    public void DivideTwoNumbers()
    {
        double number1 = 100;
        double number2 = 2;
        double expected = 50;

        double actual = BasicMath.Divide(number1, number2);

        Assert.AreEqual(expected, actual, 0.001, "Numbers not divided correctly");
    }
    [TestMethod]
    public void MultiplyTwoNumbers()
    {
        double number1 = 10;
        double number2 = 10;
        double expected = 100;

        double actual = BasicMath.Multiply(number1, number2);

        Assert.AreEqual(expected, actual, 0.001, "Numbers not multiplied correctly");
    }
}
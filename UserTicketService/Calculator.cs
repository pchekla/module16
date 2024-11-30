namespace UserTicketService;

public class Calculator
{
    /// <summary>
    /// Adds two integers.
    /// </summary>
    /// <param name="a">The first integer to add.</param>
    /// <param name="b">The second integer to add.</param>
    /// <returns>The sum of the two integers.</returns>
    public int Additional(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Subtracts the second integer from the first integer.
    /// </summary>
    /// <param name="a">The integer to subtract from.</param>
    /// <param name="b">The integer to subtract.</param>
    /// <returns>The difference between the two integers.</returns>
    public int Subtraction(int a, int b)
    {
        return a - b;    
    }

    /// <summary>
    /// Multiplies two integers.
    /// </summary>
    /// <param name="a">The first integer to multiply.</param>
    /// <param name="b">The second integer to multiply.</param>
    /// <returns>The product of the two integers.</returns>
    public int Multiplication(int a, int b)
    {
        return a * b;
    }

    /// <summary>
    /// Divides the first integer by the second integer.
    /// </summary>
    /// <param name="a">The integer to be divided.</param>
    /// <param name="b">The integer to divide by.</param>
    /// <returns>The quotient of the division.</returns>
    /// <exception cref="DivideByZeroException">Thrown when the second integer is zero.</exception>
    public int Division(int a, int b) 
    {
        return a / b;
    }
}

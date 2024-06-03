using Calculator.Models;

namespace Calculator.Tests;

public class CientificFunctionsTests
{
    private readonly CientificFunctions _context = new CientificFunctions();

    [Theory]
    [InlineData(5, 2, 25)]
    [InlineData(2, 3, 8)]
    [InlineData(3, 3, 27)]
    public void VerificarMetodoPotencia(int n1, int n2, int res)
    {
        var x = _context.Potencia(n1, n2);
        Assert.Equal(res, x);
    }

    [Theory]
    [InlineData(25, 5)]
    [InlineData(64, 8)]
    [InlineData(81, 9)]
    public void VerificarMetodoRaizQuadrada(int n1, int res)
    {
        var x = _context.RaizQuadrada(n1);
        Assert.Equal(res, x);
    }


}
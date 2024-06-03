using Calculator.Models;

namespace Calculator.Tests;

public class BasicFunctionsTests
{
    private readonly BasicFunctions _context = new BasicFunctions();

    [Theory]
    [InlineData(5, 6, 11)]
    [InlineData(12, 8, 20)]
    [InlineData(13, 10, 23)]
    public void VerificarMetodoSoma(int n1, int n2, int res)
    {
        var result = _context.Som(n1, n2);
        Assert.Equal(res, result);
    }

    [Theory]
    [InlineData(10, 4, 6)]
    [InlineData(11, 8, 3)]
    [InlineData(12, 9, 3)]
    public void VerificarMetodoSubtracao(int n1, int n2, int res)
    {
        var result = _context.Sub(n1, n2);
        Assert.Equal(res, result);
    }

    [Theory]
    [InlineData(10, 2, 20)]
    [InlineData(11, 5, 55)]
    [InlineData(12, 3, 36)]
    public void VerificarMetodoMultiplicacao(int n1, int n2, int res)
    {
        var result = _context.Mul(n1, n2);
        Assert.Equal(res, result);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(6, 2, 3)]
    [InlineData(12, 3, 4)]
    public void VerificarMetodoDivisao(int n1, int n2, int res)
    {
        var result = _context.Div(n1, n2);
        Assert.Equal(res, result);
    }
}
using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange - montar cenário
        int num1 = 5;
        int num2 = 10;

        // Act - executar ação
        int resultado = _calc.Somar(num1, num2);

        // Assert - validar se resultado foi o esperado
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange - montar cenário
        int num1 = 10;
        int num2 = 10;

        // Act - executar ação
        int resultado = _calc.Somar(num1, num2);

        // Assert - validar se resultado foi o esperado
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EParERetornarVerdadeiro()
    {
        // Arrange
        int num = 4;

        // Act
        bool resultado = _calc.Par(num);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int num)
    {
        // Act
        bool resultado = _calc.Par(num);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosDoArraySaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.Par(num)));
    }
}
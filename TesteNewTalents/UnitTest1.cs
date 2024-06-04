using System;
using Xunit;
using TesteNewTalents;

namespace TesteNewTalents
{
    public class UnitTest1
    {

        public Calculadora construirClasse()
        {
            string data = "03 / 06/2024";
            Calculadora calc = new Calculadora("03 / 06/2024");

            return calc;
        }


        [Theory]
        [InlineData(1, 2, 3)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora Calc = construirClasse();

            int resultadoCalculadora = Calc.somar(val1, val2);

          
            Assert.Equal(3, resultado);
        }


        [Theory]
        [InlineData(8, 5, 3)]
        public void TestSutrair(int val1, int val2, int resultado)
        {
            Calculadora Calc = construirClasse();

            int resultadoCalculadora = Calc.subtrair(val1, val2);

            Assert.Equal(3, resultado);
        }

        [Theory]
        [InlineData(5, 2, 10)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora Calc = construirClasse();

            int resultadoCalculadora = Calc.multiplicar(val1, val2);


            Assert.Equal(3, resultado);
        }


        [Theory]
        [InlineData(10, 2, 5)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora Calc = construirClasse();

            int resultadoCalculadora = Calc.dividir(val1, val2);


            Assert.Equal(3, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();
            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
                ); 
            
        }



        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.somar(1, 2);
            calc.somar(2, 3);
            calc.somar(1, 4);
            calc.somar(5, 2);
            calc.somar(7, 2);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }
    }
}


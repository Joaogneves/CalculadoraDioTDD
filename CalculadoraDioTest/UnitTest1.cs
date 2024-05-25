using Xunit;
using CalculadoraDio;
using System;

namespace CalculadoraDioTest
{
    public class UnitTest1
    {

        public Calculadora ConstruirClasse()
        {
            return new("25/05/2024");
        }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 4, 9)]
        [InlineData(100, 2, 102)]
        public void TesteSomar(int n1, int n2, int result)
        {
            Calculadora calculadora = ConstruirClasse();
            var res = calculadora.Somar(n1, n2);
            Assert.Equal(result, res);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(5, 4, 1)]
        [InlineData(100, 2, 98)]
        public void TesteSubtrair(int n1, int n2, int result)
        {
            Calculadora calculadora = ConstruirClasse();
            var res = calculadora.Subtrair(n1, n2);
            Assert.Equal(result, res);
        }

        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(5, 4, 20)]
        [InlineData(100, 2, 200)]
        public void TesteMultiplicar(int n1, int n2, int result)
        {
            Calculadora calculadora = ConstruirClasse();
            var res = calculadora.Multuplicar(n1, n2);
            Assert.Equal(result, res);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(100, 4, 25)]
        [InlineData(98, 1, 98)]
        public void TesteDividir(int n1, int n2, int result)
        {
            Calculadora calculadora = ConstruirClasse();
            var res = calculadora.Dividir(n1, n2);
            Assert.Equal(result, res);
        }

        [Fact] 
        public void TestDividirPorZero()
        {
            Calculadora calculadora = ConstruirClasse();
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
        }

        [Fact]
        public void TestHistoico()
        {
            Calculadora calculadora = ConstruirClasse();
            calculadora.Somar(1,2);
            calculadora.Somar(1,2);
            calculadora.Somar(1,2);
            calculadora.Somar(1,2);
            var list = calculadora.Historico();
            Assert.NotEmpty(list);
            Assert.Equal(3, list.Count);
        }
    }
}
using Desafio_TDD;

namespace TesteCalculadora
{
    public class UnitTest1
    {
        public Calculadora construirCalculadora()
        {
            DateTime data = DateTime.Now;
            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData(3, 2, 5)]
        [InlineData(2, 5, 7)]
        public void testSomar(int val1, int val2, int res)
        {
            Calculadora calc = construirCalculadora();

            int result = calc.somar(val1, val2);

            Assert.Equal(res, result);
        }
        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(12, 5, 7)]
        public void testSubtrair(int val1, int val2, int res)
        {
            Calculadora calc = construirCalculadora();

            int result = calc.subtrair(val1, val2);

            Assert.Equal(res, result);
        }
        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(2, 5, 10)]
        public void testMultiplicar(int val1, int val2, int res)
        {
            Calculadora calc = construirCalculadora();

            int result = calc.multiplicar(val1, val2);

            Assert.Equal(res, result);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(20, 5, 4)]
        public void testDividir(int val1, int val2, int res)
        {
            Calculadora calc = construirCalculadora();

            int result = calc.dividir(val1, val2);

            Assert.Equal(res, result);
        }

        [Fact]
        public void testDivisaoPorZero()
        {
            Calculadora calc = construirCalculadora();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
                );
        }

        [Fact]
        public void testHistorico()
        {
            Calculadora calc = construirCalculadora();
            calc.somar(1, 5);
            calc.somar(2, 4);
            calc.somar(8, 9);
            calc.somar(3, 6);

            var list = calc.historico();

            Assert.NotEmpty(list);
            Assert.Equal(3, list.Count);
        }
    }
}
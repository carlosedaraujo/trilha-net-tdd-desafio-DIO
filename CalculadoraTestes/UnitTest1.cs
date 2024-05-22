using Calculadora.Services;

namespace CalculadoraImpTestes;

public class UnitTest1
{

public CalculadoraImp construirClasse()
        {
            string data = "22/05/2024";
            CalculadoraImp calc = new CalculadoraImp(data);
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        [InlineData(3, 5, 8)]

        public void TesteSomar(int num1, int num2, int resultado)
        {
            CalculadoraImp calc = construirClasse();

            int resultadoCalculadora = calc.somar(num1, num2);
            Assert.Equal(resultadoCalculadora, resultado);
        }


        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(4, 2, 2)]
        [InlineData(5, 3, 2)]

        public void TesteSUbtrair(int num1, int num2, int resultado)
        {
            CalculadoraImp calc = construirClasse();

            int resultadoCalculadora = calc.subtrair(num1, num2);
            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(4, 2, 8)]
        [InlineData(5, 3, 15)]

        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            CalculadoraImp calc = construirClasse();

            int resultadoCalculadora = calc.multiplicar(num1, num2);
            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(6, 3, 2)]

        public void TesteDividir(int num1, int num2, int resultado)
        {
            CalculadoraImp calc = construirClasse();

            int resultadoCalculadora = calc.dividir(num1, num2);
            Assert.Equal(resultadoCalculadora, resultado);
        }
        [Fact]
        public void TesteListadeOperacoes()
        {
            CalculadoraImp calc = construirClasse();

            calc.somar(1, 2);
            calc.somar(3, 4);
            calc.somar(4, 5);
            calc.somar(5, 6);

            var list = calc.historico();


            Assert.Equal(3, list.Count);

        }

}


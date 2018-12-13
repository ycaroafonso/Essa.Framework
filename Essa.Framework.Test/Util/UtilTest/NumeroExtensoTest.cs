namespace Essa.Framework.Test.Util.UtilTest
{
    using Essa.Framework.Util.Util;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NumeroExtensoTest
    {
        private void Converter(string resultado, decimal valor, NumeroExtenso.TipoValorExtenso tipoValorExtenso)
        {
            // Arranje


            // Act
            var res = new NumeroExtenso()
                .Converter(valor, tipoValorExtenso);

            // Assert
            Assert.AreEqual(resultado, res);
        }

        [TestMethod]
        public void Converter10ponto5emDecimal()
        {
            // Arranje
            decimal valor = 10.5m;
            var tipoValorExtenso = NumeroExtenso.TipoValorExtenso.Decimal;

            // Act

            // Assert
            Converter("DEZ E CINCO", valor, tipoValorExtenso);
        }

        [TestMethod]
        public void Converter10ponto5emMonetario()
        {
            // Arranje
            decimal valor = 10.5m;
            var tipoValorExtenso = NumeroExtenso.TipoValorExtenso.Monetario;

            // Act

            // Assert
            Converter("DEZ REAIS E CINQUENTA CENTAVOS", valor, tipoValorExtenso);

        }


    }
}

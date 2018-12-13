namespace Essa.Framework.Test.Util.UtilTest
{
    using Essa.Framework.Util;
    using Essa.Framework.Util.Extensions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Linq;

    [TestClass]
    public class GeralTest
    {

        [TestMethod]
        public void SimNaoBooleano()
        {
            // Arranje

            // Act
            var res = Geral.SimNaoBooleano();

            // Assert
            Assert.IsTrue(res[true] == "Sim");
            Assert.IsTrue(res[false] == "Não");

            Assert.AreEqual(2, res.Count());
        }

        [TestMethod]
        public void Meses()
        {
            // Arranje

            // Act
            var res = Geral.Meses();

            // Assert
            Assert.IsTrue(res[0] == "Janeiro");
            Assert.IsTrue(res.Last() == "Dezembro");

            Assert.AreEqual(12, res.Count());
        }

        [TestMethod]
        public void MesesComNumero()
        {
            // Arranje

            // Act
            var res = Geral.MesesComNumero();

            // Assert
            Assert.IsTrue(res[0] == "Janeiro");
            Assert.IsTrue(res.Last().Key == 12);
            Assert.IsTrue(res.Last().Value == "Dezembro");

            Assert.AreEqual(12, res.Count());
        }

        [TestMethod]
        public void Anos()
        {
            // Arranje
            var primeiro = 2010;
            var ate = 2018;

            // Act
            var res = Geral.Anos(primeiro, ate);

            // Assert
            Assert.AreEqual(9, res.Count());
            Assert.AreEqual(primeiro, res.First());
            Assert.AreEqual(ate, res.Last());
        }

        [TestMethod]
        public void SimNao()
        {
            // Arranje

            // Act
            var res = Geral.SimNao();

            // Assert
            Assert.IsTrue(res["S"] == "Sim");
            Assert.IsTrue(res["N"] == "Não");

            Assert.AreEqual(2, res.Count());
        }

    }
}

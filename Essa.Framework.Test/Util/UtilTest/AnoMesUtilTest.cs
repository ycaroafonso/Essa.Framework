using System;
using Essa.Framework.Util.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Essa.Framework.Test.Util.UtilTest
{
    [TestClass]
    public class AnoMesUtilTest
    {

        [TestMethod]
        public void Adiciona_1_mes_em_201801()
        {
            // Arranje
            int entrada = 201801;

            // Act
            var res = new AnoMesUtil(entrada);
            res.AddMes(1);

            // Assert
            Assert.AreEqual(2018, res.Ano);
            Assert.AreEqual(2, res.Mes);
            Assert.AreEqual("02/2018", res.ToStringFormatado());
            Assert.AreEqual("2018/02", res.ToStringFormatado("yyyy/MM"));
            Assert.AreEqual(new DateTime(2018, 2, 1), res.ToDateTime());
        }

        [TestMethod]
        public void Adiciona_1_mes_em_201812()
        {
            int entrada = 201812;

            var res = new AnoMesUtil(entrada);
            res.AddMes(1);

            Assert.AreEqual(2019, res.Ano);
            Assert.AreEqual(1, res.Mes);
            Assert.AreEqual("01/2019", res.ToStringFormatado());
            Assert.AreEqual("2019/01", res.ToStringFormatado("yyyy/MM"));
            Assert.AreEqual(new DateTime(2019, 1, 1), res.ToDateTime());
        }
    }
}

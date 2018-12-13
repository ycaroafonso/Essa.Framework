namespace Essa.Framework.Test.Util.UtilTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Essa.Framework.Util.Extensions;


    [TestClass]
    public class DateTimeExtensionTest
    {
        [TestMethod]
        public void Valida_ToFirstDayOfMonth()
        {
            // Arranje
            var entrada = new DateTime(2018, 1, 15);

            // Act
            var res = entrada.ToFirstDayOfMonth();

            // Assert
            Assert.AreEqual(new DateTime(2018, 1, 1), res);
        }


        [TestMethod]
        public void Valida_ToLastDayOfTheMonth()
        {
            // Arranje
            var entrada = new DateTime(2018, 1, 15);

            // Act
            var res = entrada.ToLastDayOfTheMonth();

            // Assert
            Assert.AreEqual(new DateTime(2018, 1, 31), res);
        }


        [TestMethod]
        public void Valida_ToFirstDayOfWeek()
        {
            // Arranje
            var entrada = new DateTime(2018, 1, 15);

            // Act
            var res = entrada.ToFirstDayOfWeek();

            // Assert
            Assert.AreEqual(new DateTime(2018, 1, 14), res);
        }

        [TestMethod]
        public void Valida_ToLastDayOfWeek()
        {
            // Arranje
            var entrada = new DateTime(2018, 1, 15);

            // Act
            var res = entrada.ToLastDayOfWeek();

            // Assert
            Assert.AreEqual(new DateTime(2018, 1, 20), res);
        }

        [TestMethod]
        public void Valida_SetYear()
        {
            // Arranje
            var entrada = new DateTime(2018, 1, 15);

            // Act
            var res = entrada.SetYear(2019);

            // Assert
            Assert.AreEqual(new DateTime(2019, 1, 15), res);
        }

        [TestMethod]
        public void Valida_ToAnoMes()
        {
            // Arranje
            var entrada = new DateTime(2018, 1, 15);

            // Act
            var res = entrada.ToAnoMes();

            // Assert
            Assert.AreEqual(201801, res);
        }

        [TestMethod]
        public void Valida_IsAniversario()
        {
            // Arranje
            var entrada = new DateTime(2018, 1, 15);

            // Act
            var res = entrada.IsAniversario(new DateTime(2019, 1, 15));

            // Assert
            Assert.IsTrue(res);
        }
    }
}

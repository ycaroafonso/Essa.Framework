namespace Essa.Framework.Test.Util.ExtensionsTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Essa.Framework.Util.Extensions;


    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void GetExtensaoArquivo()
        {
            // Arranje

            // Act

            // Assert
            Assert.AreEqual("pdf", "nome_arquivo.pdf".GetExtensaoArquivo());
            Assert.AreEqual(10.IfZero(1), 10);
        }

        [TestMethod]
        public void ToMd5()
        {
            // Arranje
            var ent = "123456";

            // Act
            var res = ent.ToMd5();

            // Assert
            Assert.AreEqual("E10ADC3949BA59ABBE56E057F20F883E", res);
        }

        [TestMethod]
        public void RemoveAcentos()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
        }

        [TestMethod]
        public void RemoveMascara()
        {
            // Arranje
            var ent = "(67) 9999-1111";
            // Act
            var res = ent.RemoveMascara();


            // Assert
            Assert.AreEqual("67 99991111", res);
        }

        [TestMethod]
        public void SoNumeros()
        {
            // Arranje
            var ent = "(67) 9999-1111";
            // Act
            var res = ent.SoNumeros();


            // Assert
            Assert.AreEqual("6799991111", res);
        }

        [TestMethod]
        public void ValidarCpfCnpj()
        {
            // Arranje
            var ent = "216.894.211-00";
            // Act
            var res = ent.ValidarCpfCnpj();


            // Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void SubstringComReticencia()
        {
            // Arranje
            var ent = "Ycaro Afonso de Sá Moraes Souza";
            // Act
            var res = ent.SubstringComReticencia(4);


            // Assert
            Assert.AreEqual("Ycar...", res);
        }

        [TestMethod]
        public void PadRight()
        {
            // Arranje
            var ent = "Ycaro";
            // Act
            var res = ent.PadRight(7, "0");


            // Assert
            Assert.AreEqual("Ycaro00", res);
        }


        [TestMethod]
        public void ToInt32Null()
        {
            // Arranje
            var ent = "123";
            // Act
            var res = ent.ToInt32Null();


            // Assert
            Assert.AreEqual((int?)123, res);
        }


        [TestMethod]
        public void DefaultIfEmpty()
        {
            // Arranje
            var ent = string.Empty;
            // Act
            var res = ent.DefaultIfEmpty("oi");


            // Assert
            Assert.AreEqual("oi", ent.DefaultIfEmpty("oi"));
            Assert.AreEqual("1", "1".DefaultIfEmpty("oi"));
        }


        [TestMethod]
        public void FormataCEP()
        {
            // Arranje
            var ent = "79034034";
            // Act
            var res = ent.FormataCEP();


            // Assert
            Assert.AreEqual("79.034-034", res);
        }
    }
}

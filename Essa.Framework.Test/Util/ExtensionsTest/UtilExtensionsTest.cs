namespace Essa.Framework.Test.Util.ExtensionsTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Essa.Framework.Util.Extensions;

    [TestClass]
    public class UtilExtensionsTest
    {



        [TestMethod]
        //public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        public void DistinctBy()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
        }

        [TestMethod]
        //public static int ToInt32(this object valor)
        public void ToInt32()
        {
            // Arranje
            object ent = 1234;

            // Act
            var res = ent.ToInt32();

            // Assert
            Assert.AreEqual(1234, res);
        }

        [TestMethod]
        //public static decimal IfNegative(this decimal value, Func<decimal, decimal> actionReturn)
        public void IfNegative()
        {
            // Arranje
            decimal ent = -11;

            // Act
            var res = ent.IfNegative(c => c * -1);

            // Assert
            Assert.AreEqual(11, res);
        }

        [TestMethod]
        //public static T IfNull<T>(this T value, T ret)
        public void IfNull()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
            Assert.AreEqual("aseiuaeoa1234", res);
        }


        #region IfOnly

        [TestMethod]
        //public static T IfOnly<T>(this T value, bool condit, T ret)
        public void IfOnly()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
            Assert.AreEqual("aseiuaeoa1234", res);
            Assert.AreEqual("aseiuaeoa1234", res);
            Assert.AreEqual("aseiuaeoa1234", res);
        }

        #endregion


        [TestMethod]
        //public static string MaiorMenorOuZero(this decimal valor, string seMaior, string seMenor, string seZero)
        public void MaiorMenorOuZero()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
        }

        [TestMethod]
        //public static string ToMesExtenso(this int mes)
        public void ToMesExtenso()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
        }

        [TestMethod]
        //public static byte[] ToByteArray(this Stream input)
        public void ToByteArray()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
        }


        [TestMethod]
        //public static Dictionary<int, T> ToDictionary<T>(this T[] lista)
        public void ToDictionary()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
        }


        [TestMethod]
        //public static string FormataCpf(this string valor)
        public void FormataCpf()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
        }

        [TestMethod]
        //public static string FormataCnpj(this string valor)
        public void FormataCnpj()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
        }

        [TestMethod]
        //public static string FormataCpfCnpj(this string valor)
        public void FormataCpfCnpj()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
        }

        [TestMethod]
        //public static String DateToStr(this DateTime valor)
        public void DateToStr()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
            Assert.AreEqual("aseiuaeoa1234", res);
        }

        [TestMethod]
        //public static string FormatarTelefone(this string telefone)
        public void FormatarTelefone()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
        }

        [TestMethod]
        //public static T IfContainsOnlyOne<T>(this IEnumerable<T> lista)
        public void IfContainsOnlyOne()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
        }

        [TestMethod]
        //public static T[] Remove<T>(this T[] arr, T itemRemover)
        public void Remove()
        {
            // Arranje
            var ent = "áséíùâêõa1234";

            // Act
            var res = ent.RemoveAcentos();

            // Assert
            Assert.AreEqual("aseiuaeoa1234", res);
        }

    }
}

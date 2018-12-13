namespace Essa.Framework.Test.Util.ExtensionsTest
{
    using Essa.Framework.Util.Extensions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]
    public class IntExtensionsTest
    {


        [TestMethod]
        public void Valida_IfZero()
        {
            // Arranje

            // Act

            // Assert
            Assert.AreEqual(0.IfZero(1), 1);
            Assert.AreEqual(10.IfZero(1), 10);
        }

        [TestMethod]
        public void IfZeroThenNull()
        {
            // Arranje

            // Act

            // Assert
            Assert.IsNull(0.IfZeroThenNull());
            Assert.IsNotNull(10.IfZeroThenNull());
            Assert.AreEqual(10, 10.IfZeroThenNull());
        }
    }
}

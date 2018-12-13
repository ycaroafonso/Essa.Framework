namespace Essa.Framework.Test.Util.ExtensionsTest
{
    using Essa.Framework.Util.Extensions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]
    public class BoolExtensionsTest
    {

        [TestMethod]
        public void Converte_123string_para_inteiro()
        {
            Assert.IsTrue("123".IsNumber());
        }

    }
}

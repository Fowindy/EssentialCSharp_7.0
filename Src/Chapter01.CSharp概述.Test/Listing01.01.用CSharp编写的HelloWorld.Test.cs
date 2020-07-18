using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter01.Listing01_01
{
    [TestClass]
    public class Listing01_01
    {
        [TestMethod]
        public void Main_HelloWorld()
        {
            const string expected =
                @"Hello.My name is Fowindy.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter01.CSharp概述.Listing01_01.Listing01_01.Main);
        }
    }
}
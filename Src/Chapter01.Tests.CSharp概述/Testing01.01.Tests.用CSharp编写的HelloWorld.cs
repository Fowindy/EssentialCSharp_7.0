using Fowindy.Chapter01.CSharp概述.Listing01_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter01.Testing01_01
{
    [TestClass]
    public class Testing01_01
    {
        [TestMethod]
        public void Main_HelloWorld()
        {
            const string expected =
                @"Hello.My name is Fowindy.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Listing01_01.Main);
        }
    }
}
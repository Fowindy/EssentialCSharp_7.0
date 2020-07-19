/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月19日 星期日 18:45:07
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月19日 星期日 18:45:07
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter01.CSharp概述.Test.Listing01_04
{
    [TestClass]
    public class Listing01_04
    {
        [TestMethod]
        public void Main_Listing01_04()
        {
            const string expected =
                @"Hello,My name is Fowindy.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter01.CSharp概述.Listing01_04.Listing01_04.Main);
        }
    }
}
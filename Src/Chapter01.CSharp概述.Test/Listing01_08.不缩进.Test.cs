/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月20日 星期一 04:52:18
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月20日 星期一 04:52:18
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter01.CSharp概述.Test.Listing01_08
{
    [TestClass]
    public class Listing01_08
    {
        [TestMethod]
        public void Main_Listing01_08()
        {
            const string expected =
                @"Hello,My name is Fowindy.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter01.CSharp概述.Listing01_08.Listing01_08.Main);
        }
    }
}
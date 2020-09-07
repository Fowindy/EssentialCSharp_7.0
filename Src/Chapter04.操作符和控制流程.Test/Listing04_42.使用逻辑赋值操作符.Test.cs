/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月7日 星期一 13:37:35
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月7日 星期一 13:37:35
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_42
{
    [TestClass]
    public class Listing04_42
    {
        [TestMethod]
        public void Main_Listing04_42()
        {
            const string expected =
                @"and = 4
or = 15
xor = 11";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_42.Listing04_42.Main);
        }
    }
}
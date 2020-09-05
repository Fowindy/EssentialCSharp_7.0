/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月5日 星期六 10:22:38
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月5日 星期六 10:22:38
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_07
{
    [TestClass]
    public class Listing04_07
    {
        [TestMethod]
        public void Main_Listing04_07()
        {
            const string expected =
                @"4.2 != 4.2000002861023
4.2 != 4.20000028610229
4.2M != 4.2F
4.20000028610229 != 4.2
4.2F != 4.2D
4.19999980926514 != 4.2
14.2F != 4.2D";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_07.Listing04_07.Main);
        }
    }
}
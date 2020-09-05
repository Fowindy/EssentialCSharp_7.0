/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月5日 星期六 10:37:46
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月5日 星期六 10:37:46
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_09
{
    [TestClass]
    public class Listing04_09
    {
        [TestMethod]
        public void Main_Listing04_09()
        {
            const string expected =
                @"-∞
∞";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_09.Listing04_09.Main);
        }
    }
}
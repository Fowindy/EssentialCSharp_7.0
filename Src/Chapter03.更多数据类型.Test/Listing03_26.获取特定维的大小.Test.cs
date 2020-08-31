/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月31日 星期一 08:52:54
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月31日 星期一 08:52:54
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter03.更多数据类型.Test.Listing03_26
{
    [TestClass]
    public class Listing03_26
    {
        [TestMethod]
        public void Main_Listing03_26()
        {
            const string expected =
                @"2
3";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter03.更多数据类型.Listing03_26.Listing03_26.Main);
        }
    }
}
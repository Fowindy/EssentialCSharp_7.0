/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月5日 星期六 15:39:18
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月5日 星期六 15:39:18
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_19_03
{
    [TestClass]
    public class Listing04_19_03
    {
        [TestMethod]
        public void Main_Listing04_19_03()
        {
            const string expected =
                @"count = 0
count = 1
count = 2
count = 3
count = 4";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_19_03.Listing04_19_03.Main);
        }
    }
}
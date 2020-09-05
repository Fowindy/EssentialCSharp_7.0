/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月5日 星期六 17:28:39
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月5日 星期六 17:28:39
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_19_05
{
    [TestClass]
    public class Listing04_19_05
    {
        [TestMethod]
        public void Main_Listing04_19_05()
        {
            const string expected =
                @"count = 1
count = 2
count = 3
count = 4
count = 5
count = 6
count = 7
count = 8
count = 9
count = 10";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_19_05.Listing04_19_05.Main);
        }
    }
}
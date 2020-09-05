/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月5日 星期六 11:43:20
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月5日 星期六 11:43:20
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_14
{
    [TestClass]
    public class Listing04_14
    {
        [TestMethod]
        public void Main_Listing04_14()
        {
            const string expected =
                @"120";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_14.Listing04_14.Main);
        }
    }
}
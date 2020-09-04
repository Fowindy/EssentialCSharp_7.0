/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月4日 星期五 22:59:14
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月4日 星期五 22:59:14
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_04
{
    [TestClass]
    public class Listing04_04
    {
        [TestMethod]
        public void Main_Listing04_04()
        {
            const string expected =
                @"The original Tacoma Bridge in Washington
was brought down by a windSpeed mile/hour wind.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_04.Listing04_04.Main);
        }
    }
}
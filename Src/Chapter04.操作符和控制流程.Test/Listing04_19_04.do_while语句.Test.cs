/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月5日 星期六 16:46:53
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月5日 星期六 16:46:53
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_19_04
{
    [TestClass]
    public class Listing04_19_04
    {
        [TestMethod]
        public void Main_Listing04_19_04()
        {
            const string expected =
                @"Enter name:<<exit";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_19_04.Listing04_19_04.Main);
        }
    }
}
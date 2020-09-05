/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 06:48:51
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 06:48:51
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_20
{
    [TestClass]
    public class Listing04_20
    {
        [TestMethod]
        public void Main_Listing04_20()
        {
            const string expected =
                @"1---Play against the computer
2---Play against another player.
Choose:<<1
>>Play against computer selected.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_20.Listing04_20.Main);
        }
    }
}
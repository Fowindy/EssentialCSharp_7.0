/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 07:07:21
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 07:07:21
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_21
{
    [TestClass]
    public class Listing04_21
    {
        [TestMethod]
        public void Main_Listing04_21()
        {
            const string expected =
                @"What is the maximum number of turns in tic-tac-toe?(Enter 0 to exit.):<<8
>>Tic-tac-toe has more than 8 maximum turns.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_21.Listing04_21.Main);
        }
    }
}
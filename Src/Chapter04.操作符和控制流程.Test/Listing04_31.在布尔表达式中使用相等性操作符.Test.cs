/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 13:31:30
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 13:31:30
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_31
{
    [TestClass]
    public class Listing04_31
    {
        [TestMethod]
        public void Main_Listing04_31()
        {
            const string expected =
                @"Please enter player number:<<1
>>Please enter command:<<quit
>>Player 1 quit!!";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_31.Listing04_31.Main);
        }
    }
}
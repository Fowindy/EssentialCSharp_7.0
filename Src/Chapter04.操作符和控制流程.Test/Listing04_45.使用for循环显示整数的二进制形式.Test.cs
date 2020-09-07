/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月7日 星期一 16:31:25
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月7日 星期一 16:31:25
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_45
{
    [TestClass]
    public class Listing04_45
    {
        [TestMethod]
        public void Main_Listing04_45()
        {
            const string expected =
                @"Please enter an integer:<<-42
>>1111111111111111111111111111111111111111111111111111111111010110";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_45.Listing04_45.Main);
        }
    }
}
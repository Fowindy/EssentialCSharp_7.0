/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月7日 星期一 16:01:57
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月7日 星期一 16:01:57
 *          修改理由：使用while循环寻找比输入的数大的第一个斐波那契数
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_43
{
    [TestClass]
    public class Listing04_43
    {
        [TestMethod]
        public void Main_Listing04_43()
        {
            const string expected =
                @"Enter a positive integer:<<8
>>The Fibonacci number following this is 13";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_43.Listing04_43.Main);
        }
    }
}
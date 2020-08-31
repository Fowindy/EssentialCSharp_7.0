/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月31日 星期一 09:17:15
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月31日 星期一 09:17:15
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter03.更多数据类型.Test.Listing03_29
{
    [TestClass]
    public class Listing03_29
    {
        [TestMethod]
        public void Main_Listing03_29()
        {
            const string expected =
                @"Please enter a palindrome:<<asd d s a
>>asd d s a is a palindrome.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter03.更多数据类型.Listing03_29.Listing03_29.Main);
        }
    }
}
/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月27日 星期四 11:05:31
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月27日 星期四 11:05:31
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter02.数据类型.Test.Listing02_32
{
    [TestClass]
    public class Listing02_32
    {
        [TestMethod]
        public void Main_Listing02_32()
        {
            const string expected =
                @"Please enter a number:<<42
>>Converted correctly,the number is:42";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter02.数据类型.Listing02_32.Listing02_32.Main);
        }
    }
}
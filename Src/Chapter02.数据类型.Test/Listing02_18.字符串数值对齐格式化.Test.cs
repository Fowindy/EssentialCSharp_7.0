/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月15日 星期六 07:31:47
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月15日 星期六 07:31:47
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter02.数据类型.Test.Listing02_18
{
    [TestClass]
    public class Listing02_18
    {
        [TestMethod]
        public void Main_Listing02_18()
        {
            const string expected =
                @"Please enter a decimal value:<<123456789012.345678
>>￥123,456,789,012.35";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter02.数据类型.Listing02_18.Listing02_18.Main);
        }
    }
}
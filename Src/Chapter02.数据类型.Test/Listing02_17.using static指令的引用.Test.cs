/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月14日 星期五 23:37:43
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月14日 星期五 23:37:43
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter02.数据类型.Test.Listing02_17
{
    [TestClass]
    public class Listing02_17
    {
        [TestMethod]
        public void Main_Listing02_17()
        {
            const string expected =
                @"Hey you!
Please enter your first name:<<wang
>>Please enter your last name:<<yue
>>Your full name is wang yue.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter02.数据类型.Listing02_17.Listing02_17.Main);
        }
    }
}
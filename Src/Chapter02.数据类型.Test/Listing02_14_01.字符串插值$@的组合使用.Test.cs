/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月11日 星期二 08:09:01
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月11日 星期二 08:09:01
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter02.数据类型.Test.Listing02_14_01
{
    [TestClass]
    public class Listing02_14_01
    {
        [TestMethod]
        public void Main_Listing02_14_01()
        {
            const string expected =
                @"Please enter your first name:<<王
>>Please enter your last name:<<崇
>>Your full name is:
王 崇
>>Your full name is:王 崇";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter02.数据类型.Listing02_14_01.Listing02_14_01.Main);
        }
    }
}
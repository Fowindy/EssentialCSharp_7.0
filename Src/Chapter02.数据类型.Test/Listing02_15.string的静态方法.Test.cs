/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月12日 星期三 07:28:59
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月12日 星期三 07:28:59
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter02.数据类型.Test.Listing02_15
{
    [TestClass]
    public class Listing02_15
    {
        [TestMethod]
        public void Main_Listing02_15()
        {
            const string expected =
                @"Please enter your first name:<<王
>>Please enter your last name:<<岳
>>Your full name is 王 岳.
>>王岳";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter02.数据类型.Listing02_15.Listing02_15.Main);
        }
    }
}
/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月16日 星期日 10:33:52
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月16日 星期日 10:33:52
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter02.数据类型.Test.Listing02_23
{
    [TestClass]
    public class Listing02_23
    {
        [TestMethod]
        public void Main_Listing02_23()
        {
            const string expected =
                @"longNumber is 50918309109
intNumber is -621298443";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter02.数据类型.Listing02_23.Listing02_23.Main);
        }
    }
}
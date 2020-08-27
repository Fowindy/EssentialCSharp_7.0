/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月26日 星期三 21:54:55
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月26日 星期三 21:54:55
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter02.数据类型.Test.Listing02_30
{
    [TestClass]
    public class Listing02_30
    {
        [TestMethod]
        public void Main_Listing02_30()
        {
            const string expected =
                @"261.626
True";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter02.数据类型.Listing02_30.Listing02_30.Main);
        }
    }
}
/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月24日 星期五 01:15:17
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月24日 星期五 01:15:17
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter02.数据类型.Test.Listing02_13
{
    [TestClass]
    public class Listing02_13
    {
        [TestMethod]
        public void Main_Listing02_13()
        {
            const string expected =
                "\"Truly,you have a dizzying intellect.\"\n\"Wait till I get going!\"";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter02.数据类型.Listing02_13.Listing02_13.Main);
        }
    }
}
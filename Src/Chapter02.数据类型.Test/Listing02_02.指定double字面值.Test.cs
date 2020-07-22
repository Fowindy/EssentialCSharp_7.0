/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月22日 星期三 17:38:30
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月22日 星期三 17:38:30
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter02.数据类型.Test.Listing02_02
{
    [TestClass]
    public class Listing02_02
    {
        [TestMethod]
        public void Main_Listing02_02()
        {
            const string expected =
                @"1618.03398874989";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter02.数据类型.Listing02_02.Listing02_02.Main);
        }
    }
}
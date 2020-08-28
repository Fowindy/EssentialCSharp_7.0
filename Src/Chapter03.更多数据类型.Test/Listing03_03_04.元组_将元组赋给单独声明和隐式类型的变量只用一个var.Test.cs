/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月28日 星期五 11:42:04
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月28日 星期五 11:42:04
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter03.更多数据类型.Test.Listing03_03_04
{
    [TestClass]
    public class Listing03_03_04
    {
        [TestMethod]
        public void Main_Listing03_03_04()
        {
            const string expected =
                @"The poorest country in the world in 2017 was Malawi,Lilongwe:226.5";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter03.更多数据类型.Listing03_03_04.Listing03_03_04.Main);
        }
    }
}
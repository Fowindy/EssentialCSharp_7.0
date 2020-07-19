/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月20日 星期一 05:07:10
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月20日 星期一 05:07:10
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter01.CSharp概述.Test.Listing01_10
{
    [TestClass]
    public class Listing01_10
    {
        [TestMethod]
        public void Main_Listing01_10()
        {
            const string expected =
                @"Have fun storming the castle!";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter01.CSharp概述.Listing01_10.Listing01_10.Main);
        }
    }
}
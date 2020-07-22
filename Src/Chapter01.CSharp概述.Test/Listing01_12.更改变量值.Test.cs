/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月22日 星期三 07:47:16
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月22日 星期三 07:47:16
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter01.CSharp概述.Test.Listing01_12
{
    [TestClass]
    public class Listing01_12
    {
        [TestMethod]
        public void Main_Listing01_12()
        {
            const string expected =
                @"Have fun storming the castle!
Think it will work?
It would take a miracle.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter01.CSharp概述.Listing01_12.Listing01_12.Main);
        }
    }
}
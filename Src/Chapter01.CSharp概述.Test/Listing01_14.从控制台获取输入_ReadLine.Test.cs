/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月22日 星期三 09:12:43
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月22日 星期三 09:12:43
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter01.CSharp概述.Test.Listing01_14
{
    [TestClass]
    public class Listing01_14
    {
        [TestMethod]
        public void Main_Listing01_14()
        {
            const string expected =
@"Hey you!
Please enter your first name:<<yue
>>Please enter your last name:<<wang";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter01.CSharp概述.Listing01_14.Listing01_14.Main);
        }
    }
}
/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 10:02:31
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 10:02:31
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_24
{
    [TestClass]
    public class Listing04_24
    {
        [TestMethod]
        public void Main_Listing04_24()
        {
            const string expected =
                @"请输入圆的半径:<<35
>>The radius of the circle is:35.00
The area of circle is:3848.45
The circumstance of circle is:219.91";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_24.Listing04_24.Main);
        }
    }
}
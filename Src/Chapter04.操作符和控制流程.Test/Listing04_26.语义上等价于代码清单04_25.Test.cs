/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 11:13:53
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 11:13:53
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_26
{
    [TestClass]
    public class Listing04_26
    {
        [TestMethod]
        public void Main_Listing04_26()
        {
            const string expected =
                @"请输入圆的半径:<<33
>>The radius of the circle is:33.00
The area of circle is:3421.19
The circumstance of circle is:207.35";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_26.Listing04_26.Main);
        }
    }
}
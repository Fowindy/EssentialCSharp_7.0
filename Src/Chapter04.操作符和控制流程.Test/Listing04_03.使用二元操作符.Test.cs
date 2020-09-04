/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月1日 星期二 13:06:29
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月1日 星期二 13:06:29
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_03
{
    [TestClass]
    public class Listing04_03
    {
        [TestMethod]
        public void Main_Listing04_03()
        {
            const string expected =
                @"Please Enter the numerator:<<23
>>Please Enter the denominator:<<4
>>23 / 4 = 5 with remainder 3";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_03.Listing04_03.Main);
        }
    }
}
/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月8日 星期二 10:13:44
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月8日 星期二 10:13:44
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_48
{
    [TestClass]
    public class Listing04_48
    {
        [TestMethod]
        public void Main_Listing04_48()
        {
            const string expected =
                @"Please enter move command:<<exit
>>
ERROR:Enter a value from 1-9.Push ENTER to quit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_48.Listing04_48.Main);
        }
    }
}
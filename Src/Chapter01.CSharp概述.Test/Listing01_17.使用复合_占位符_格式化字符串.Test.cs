/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月22日 星期三 11:15:28
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月22日 星期三 11:15:28
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter01.CSharp概述.Test.Listing01_17
{
    [TestClass]
    public class Listing01_17
    {
        [TestMethod]
        public void Main_Listing01_17()
        {
            const string expected =
                @"Hey You!
Please enter your first name:<<yue
>>Please enter your last name:<<wang
>>Your full name is yue wang.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter01.CSharp概述.Listing01_17.Listing01_17.Main);
        }
    }
}
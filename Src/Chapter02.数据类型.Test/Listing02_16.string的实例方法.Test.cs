/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月12日 星期三 08:08:02
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月12日 星期三 08:08:02
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter02.数据类型.Test.Listing02_16
{
    [TestClass]
    public class Listing02_16
    {
        [TestMethod]
        public void Main_Listing02_16()
        {
            const string expected =
                @"Please enter your user name:<<  wang yue  
>>wang yue  
>>wang yue
>>True
>>True
>>wang yue
>>WANG YUE";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter02.数据类型.Listing02_16.Listing02_16.Main);
        }
    }
}
/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月31日 星期五 13:33:39
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月31日 星期五 13:33:39
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter02.数据类型.Test.Listing02_14
{
    [TestClass]
    public class Listing02_14
    {
        [TestMethod]
        public void Main_Listing02_14()
        {
            const string expected =@"begin
                /\
               /  \
              /    \
             /      \
            /        \
           /          \
          /____________\
end";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter02.数据类型.Listing02_14.Listing02_14.Main);
        }
    }
}
/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月29日 星期六 11:32:59
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月29日 星期六 11:32:59
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter03.更多数据类型.Test.Listing03_04_01
{
    [TestClass]
    public class Listing03_04_01
    {
        [TestMethod]
        public void Main_Listing03_04_01()
        {
            const string expected =
                @"C#
COBOL
C++
Java
Visual Basic
Pascal
Fortran
Lisp
J#";
            
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter03.更多数据类型.Listing03_04_01.Listing03_04_01.Main);
        }
    }
}
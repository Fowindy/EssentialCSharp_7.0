/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月31日 星期一 08:12:18
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月31日 星期一 08:12:18
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter03.更多数据类型.Test.Listing03_25
{
    [TestClass]
    public class Listing03_25
    {
        [TestMethod]
        public void Main_Listing03_25()
        {
            const string expected = @"The wave of the future, COBOL, is at index 2.

First Element       	Last Element        
-------------       	------------        
C#                  	Visual Basic        
Visual Basic        	C#                  
                    	                    
After clearing, the array size is: 9";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter03.更多数据类型.Listing03_25.Listing03_25.Main);
        }
    }
}
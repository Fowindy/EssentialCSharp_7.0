/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月23日 星期四 00:17:18
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月23日 星期四 00:17:18
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter02.数据类型.Test.Listing02_09
{
    [TestClass]
    public class Listing02_09
    {
        [TestMethod]
        public void Main_Listing02_09()
        {
            const string netCoreApp2expected =
@"1.61803398974989 == 1.61803398974989:False
1.61803398974989 == 1.61803398974989:True";
            
            string expected = // netcoreapp3.0 and later
@"1.618033988749895 == 1.618033988749895:True
1.618033988749895 == 1.618033988749895:True";

            string netCoreVersion = NetCore.GetNetCoreVersion();
            if (string.Compare(netCoreVersion, "3") < 0)
            {
                expected = netCoreApp2expected;
            }
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter02.数据类型.Listing02_09.Listing02_09.Main);
        }
    }
}
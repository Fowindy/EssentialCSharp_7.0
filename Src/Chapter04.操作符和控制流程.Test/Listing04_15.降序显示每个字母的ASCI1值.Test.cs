/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月5日 星期六 11:51:04
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月5日 星期六 11:51:04
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_15
{
    [TestClass]
    public class Listing04_15
    {
        [TestMethod]
        public void Main_Listing04_15()
        {
            const string expected =
                "z=122\ty=121\tx=120\tw=119\tv=118\tu=117\tt=116\ts=115\tr=114\tq=113\tp=112\to=111\tn=110\tm=109\tl=108\tk=107\tj=106\ti=105\th=104\tg=103\tf=102\te=101\td=100\tc=99\tb=98\ta=97\t";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_15.Listing04_15.Main);
        }
    }
}
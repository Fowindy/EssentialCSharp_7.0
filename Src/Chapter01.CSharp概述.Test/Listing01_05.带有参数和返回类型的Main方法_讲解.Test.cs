/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月22日 星期三 07:59:31
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月22日 星期三 07:59:31
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fowindy.Shared;

namespace Fowindy.Chapter01.CSharp概述.Test.Listing01_05
{
    [TestClass]
    public class Listing01_05
    {
        [TestMethod]
        public void Main_Listing01_05()
        {
            const int expected = 0;
            int value = Chapter01.CSharp概述.Listing01_05.Listing01_05.Main(new string[0]);
            Assert.AreEqual(expected, value);
        }
    }
}
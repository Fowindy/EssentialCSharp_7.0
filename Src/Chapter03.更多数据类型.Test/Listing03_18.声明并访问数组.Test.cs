﻿/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月30日 星期日 23:02:46
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月30日 星期日 23:02:46
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter03.更多数据类型.Test.Listing03_18
{
    [TestClass]
    public class Listing03_18
    {
        [TestMethod]
        public void Main_Listing03_18()
        {
            const string expected =
                @"Visual Basic";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter03.更多数据类型.Listing03_18.Listing03_18.Main);
        }
    }
}
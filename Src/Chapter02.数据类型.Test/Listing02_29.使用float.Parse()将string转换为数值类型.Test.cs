﻿/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月17日 星期一 19:11:33
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月17日 星期一 19:11:33
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter02.数据类型.Test.Listing02_29
{
    [TestClass]
    public class Listing02_29
    {
        [TestMethod]
        public void Main_Listing02_29()
        {
            const string expected =
                @"9.11E-31";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter02.数据类型.Listing02_29.Listing02_29.Main);
        }
    }
}
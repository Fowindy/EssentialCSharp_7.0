﻿/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 16:55:16
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 16:55:16
 *          修改理由：创建文档
 * ==============================================================================*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fowindy.Chapter04.操作符和控制流程.Test.Listing04_35
{
    [TestClass]
    public class Listing04_35
    {
        [TestMethod]
        public void Main_Listing04_35()
        {
            const string expected =
                @"Turn Player 2 move!
Turn Player 1 move!
Turn Player 2 move!
Turn Player 1 move!
Turn Player 2 move!
Turn Player 1 move!
Turn Player 2 move!
Turn Player 1 move!
Turn Player 2 move!
Turn Player 1 move!";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Chapter04.操作符和控制流程.Listing04_35.Listing04_35.Main);
        }
    }
}
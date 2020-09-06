/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 16:55:02
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 16:55:02
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_35
{
    public class Listing04_35
    {
        public static void Main()
        {
            int currentPlayer = 1;
            for (int turn = 1;turn <= 10;turn++)
            {
                currentPlayer = (currentPlayer == 2) ? 1 : 2;
                Console.WriteLine($"Turn Player {currentPlayer} move!");
            }
        }
    }
}

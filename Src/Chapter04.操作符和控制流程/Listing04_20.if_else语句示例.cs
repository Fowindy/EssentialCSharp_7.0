/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 06:41:17
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 06:41:17
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_20
{
    public class Listing04_20
    {
        public static void Main()
        {
            string input;
            Console.Write("1---Play against the computer\n"+
                "2---Play against another player.\n"+
                "Choose:");
            input = Console.ReadLine();
            if (input == "1")
                Console.WriteLine("Play against computer selected.");
            else
                Console.WriteLine("Play against another player.");
        }
    }
}

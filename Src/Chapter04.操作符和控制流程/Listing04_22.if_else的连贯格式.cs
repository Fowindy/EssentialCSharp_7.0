/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 07:20:16
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 07:20:16
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_22
{
    public class Listing04_22
    {
        public static void Main()
        {
            Console.Write("What is the maximum number of turns in tic-tac-toe?(Enter 0 to exit.):");
            int input = int.Parse(Console.ReadLine());
            if (input < 0)
                Console.WriteLine("Exiting...");
            else if (input < 9)
                Console.WriteLine($"Tic-tac-toe has more than {input} " +
    "maximum turns.");
            else if (input > 9)
                Console.WriteLine($"Tic-tac-toe has fewer than {input} " +
    "maximum turns.");
            else
                Console.WriteLine("Correct,tic-tac-toe " +
    "has a maximum of 9 turns.");
        }
    }
}

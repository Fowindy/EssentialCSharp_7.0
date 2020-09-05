/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 06:52:32
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 06:52:32
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_21
{
    public class Listing04_21
    {
        public static void Main()
        {
            int input;//声明变量,存储输入
            Console.Write("What is the maximum number " +
                "of turns in tic-tac-toe?" +
                "(Enter 0 to exit.):");
            //将用户输入转换成int类型
            input = int.Parse(Console.ReadLine());

            if (input <= 0)
                Console.WriteLine("Exiting...");
            else
                if (input < 9)
                Console.WriteLine($"Tic-tac-toe has more than {input} " +
                    "maximum turns.");
                else
                if (input > 9)
                Console.WriteLine($"Tic-tac-toe has fewer than {input} " +
    "maximum turns.");
                else
                Console.WriteLine("Correct,tic-tac-toe " +
                    "has a maximum of 9 turns.");
        }
    }
}

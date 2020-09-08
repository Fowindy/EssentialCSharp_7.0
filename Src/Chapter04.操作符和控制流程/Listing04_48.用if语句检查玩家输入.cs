/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月7日 星期一 21:26:12
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月7日 星期一 21:26:12
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_48
{
    public class Listing04_48
    {
        public static void Main()
        {
            Console.Write("Please enter move command:");
            string input = Console.ReadLine();
            bool valid = false;
            if ((input == "1") ||
                (input == "2") ||
                (input == "3") ||
                (input == "4") ||
                (input == "5") ||
                (input == "6") ||
                (input == "7") ||
                (input == "8") ||
                (input == "9"))
            {
                valid = true;
            }
            else if ((input == "") || (input == "quit"))
            {
                valid = false;
            }
            else
            {
                Console.WriteLine("\nERROR:Enter a value from 1-9." +
                    "Push ENTER to quit.");
            }
        }
    }
}

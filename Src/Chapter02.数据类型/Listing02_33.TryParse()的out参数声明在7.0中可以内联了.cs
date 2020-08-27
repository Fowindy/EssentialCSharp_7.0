/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月27日 星期四 11:15:28
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月27日 星期四 11:15:28
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_33
{
    public class Listing02_33
    {
        public static void Main()
        {
            string input;
            Console.Write("Please enter a number:");
            input = Console.ReadLine(); 
            if (double.TryParse(input,out double number))
            {
                Console.WriteLine("Converted correctly.the number is:{0}",number);
            }
            else
            {
                Console.WriteLine("The text entered was not a valid number.");
            }
        }
    }
}

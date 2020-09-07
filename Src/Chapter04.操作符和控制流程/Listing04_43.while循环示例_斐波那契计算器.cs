/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月7日 星期一 16:00:18
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月7日 星期一 16:00:18
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_43
{
    public class Listing04_43
    {
        public static void Main()
        {
            decimal current;
            decimal previous;
            decimal temp;
            decimal input;
            Console.Write("Enter a positive integer:");
            input = decimal.Parse(Console.ReadLine());
            //初始化current和previous为1,斐波那契数列最前两项
            current = previous = 1;
            while (current <= input)
            {
                temp = current;
                current = previous + current;
                previous = temp;
                //1 1 2 3 5 8 13  
            }
            Console.WriteLine($"The Fibonacci number following this is {current}");
        }
    }
}

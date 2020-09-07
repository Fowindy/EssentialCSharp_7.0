/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月7日 星期一 11:49:19
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月7日 星期一 11:49:19
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_41_01
{
    public class Listing04_41_01
    {
        public static void Main()
        {
            Console.Write("Please enter an integer:");
            long value = long.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(value, 2));
            Console.WriteLine(Convert.ToString(value, 8));
            Console.WriteLine(Convert.ToString(value, 16));
        }
    }
}

/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 16:39:09
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 16:39:09
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_33
{
    public class Listing04_33
    {
        public static void Main()
        {
            Console.Write("请输入现在是几点:");
            int hourofTheDay = int.Parse(Console.ReadLine());
            if (10 < hourofTheDay && hourofTheDay < 24)
            {
                Console.WriteLine("Hi-Ho, Hi-Ho, it's off to work we go.");
            }
        }
    }
}

/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 13:45:27
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 13:45:27
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_32
{
    public class Listing04_32
    {
        public static void Main()
        {
            Console.Write("请输入现在是几点:");
            int hourofTheDay = int.Parse(Console.ReadLine());
            if ((hourofTheDay > 23) || (hourofTheDay < 0))
            Console.WriteLine("The time you entered is invalid.");
        }
    }
}

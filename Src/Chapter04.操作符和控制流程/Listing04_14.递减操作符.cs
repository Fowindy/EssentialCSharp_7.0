/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月5日 星期六 11:42:17
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月5日 星期六 11:42:17
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_14
{
    public class Listing04_14
    {
        public static void Main()
        {
            int lines = 123;
            lines = lines - 1;
            lines -= 1;
            lines--;
            Console.WriteLine(lines);
        }
    }
}

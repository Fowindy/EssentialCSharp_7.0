/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月7日 星期一 16:34:04
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月7日 星期一 16:34:04
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_46
{
    public class Listing04_46
    {
        public static void Main()
        {
            for (int x = 0,y= 5;((x<=5)&&(y>=0));y--,x++)
            {
                Console.Write($"{x}{((x > y) ? '>':'<')}{y}\t");
            }
        }
    }
}

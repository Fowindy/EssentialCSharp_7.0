/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月7日 星期一 17:44:23
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月7日 星期一 17:44:23
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_47
{
    public class Listing04_47
    {
        public static void Main()
        {
            char[] cells = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Console.Write("The available moves are as follows:");
            foreach (char cell in cells)
            {
                if (cell != '0' && cell != 'X')
                {
                    Console.Write($"{cell},");
                }
            }
        }
    }
}

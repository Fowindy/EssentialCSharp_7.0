/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月5日 星期六 15:40:56
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月5日 星期六 15:40:56
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_19_04
{
    public class Listing04_19_04
    {
        public static void Main()
        {
            string input;
            do 
            {
                Console.Write("Enter name:");
                input = Console.ReadLine();
            } while (input != "exit");
        }
    }
}

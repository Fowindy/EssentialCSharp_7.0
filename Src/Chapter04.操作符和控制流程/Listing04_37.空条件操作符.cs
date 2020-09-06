/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 19:44:20
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 19:44:20
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_37
{
    public class Listing04_37
    {
        public static void Main(string[] args)
        {
            if (args?.Length==0)
            {
                Console.WriteLine("Error:File missing."
    + "Use:\n\tfind.exe file:<filename>");
            }
            else
            {
                if (args[0]?.ToLower().StartsWith("file:")??false)
                {
                    string fileName = args[0]?.Remove(0, 5);
                }
            }

        }
    }
}

/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月23日 星期四 07:26:39
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月23日 星期四 07:26:39
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_10
{
    public class Listing02_10
    {
        public static void Main()
        {
            string option = "/HElp";
            int comparison = string.Compare(option, "/Help", false);
            Console.WriteLine(comparison==1?"相同":"不同");
        }
    }
}

/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月16日 星期日 08:28:23
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月16日 星期日 08:28:23
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_22
{
    public class Listing02_22
    {
        public static void Main()
        {
            string faxNumber;
            Console.Write("Please enter faxNumber:");
            faxNumber = Console.ReadLine();
            Console.WriteLine(faxNumber);
            faxNumber = null;
            Console.WriteLine(faxNumber);
        }
    }
}

/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月16日 星期日 10:22:36
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月16日 星期日 10:22:36
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_23
{
    public class Listing02_23
    {
        public static void Main()
        {
            long longNumber = 50918309109;
            Console.WriteLine($"longNumber is {longNumber}");
            int intNumber = (int)longNumber;
            Console.WriteLine($"intNumber is {intNumber}");
        }
    }
}

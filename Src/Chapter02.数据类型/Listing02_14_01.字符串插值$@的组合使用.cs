/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月10日 星期一 18:53:00
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月10日 星期一 18:53:00
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_14_01
{
    public class Listing02_14_01
    {
        public static void Main()
        {
            Console.Write("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name:");
            string lastName = Console.ReadLine();
            //$解析引用变量_2逐字解析换行空格等等(引用外的换行解析成换行)
            Console.WriteLine($@"Your full name is:
                {firstName} {lastName}");
        }
    }
}

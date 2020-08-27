/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月27日 星期四 01:25:10
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月27日 星期四 01:25:10
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_31
{
    public class Listing02_31
    {
        public static void Main()
        {
            bool boolean = true;
            string text = boolean.ToString();
            Console.WriteLine(text);//True
        }
    }
}

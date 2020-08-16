/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月16日 星期日 08:10:44
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月16日 星期日 08:10:44
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_20
{
    public class Listing02_20
    {
        public static void Main()
        {
            string text;
            Console.Write("Please enter text:");
            text = Console.ReadLine();
            //因为字符串的不可变,此处并不会转换成大写
            text.ToUpper();
            Console.WriteLine(text);//text还是小写不会发生改变
        }
    }
}

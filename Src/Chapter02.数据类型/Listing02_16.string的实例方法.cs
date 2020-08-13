/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月12日 星期三 07:57:12
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月12日 星期三 07:57:12
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_16
{
    public class Listing02_16
    {
        public static void Main()
        {
            //bool StartsWith(string value)_判断是否以目标字符开始
            string fullName;
            Console.Write("Please enter your full name:");
            fullName = Console.ReadLine();
            bool isWang = fullName.StartsWith("wang");
            Console.WriteLine(isWang);
            //bool StartsWith(string value)_判断是否以目标字符结束
            bool isYue = fullName.EndsWith("yue");
            Console.WriteLine(isYue);
            //string ToLower()_字符串全部转换成小写
            Console.WriteLine(fullName.ToLower());
            //string ToUp()_字符串全部转换成大写
            Console.WriteLine(fullName.ToUpper());
        }
    }
}

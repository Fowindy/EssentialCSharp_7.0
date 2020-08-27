/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月22日 星期三 23:08:28
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月22日 星期三 23:08:28
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_09
{
    public class Listing02_09
    {
        public static void Main()
        {
            const double number = 1.618033989749895;
            double result;
            string text;

            text = $"{number}";
            result = double.Parse(text);
            Console.WriteLine($"{result} == {number}:{result == number}");

            text = string.Format("{0:R}", number);
            result = double.Parse(text);
            Console.WriteLine($"{result} == {number}:{result == number}");
        }
    }
}

/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月4日 星期五 23:03:44
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月4日 星期五 23:03:44
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_05
{
    public class Listing04_05
    {
        public static void Main()
        {
            //相加的是字符的Unicode值
            int n = '3' + '4';
            char c = (char)n;
            Console.WriteLine(c);
        }
    }
}

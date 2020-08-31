/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月28日 星期五 10:30:26
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月28日 星期五 10:30:26
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter03.更多数据类型.Listing03_03
{
    public class Listing03_03
    {
        public static void Main()
        {
            var patent1 =
                new
                {
                    Title = "Bifocals",
                    YearOfPublication = 1784
                };
            var patent2 =
                new
                {
                    Title = "Phonograph",
                    YearOfPublication = 1877
                };
            Console.WriteLine($"{patent1.Title}---{patent1.YearOfPublication+1}");
            Console.WriteLine($"{patent2.Title}---{patent2.YearOfPublication+2}");
        }
    }
}

/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月15日 星期六 07:27:12
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月15日 星期六 07:27:12
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_18
{
    public class Listing02_18
    {
        public static void Main()
        {
            //$"{price,20:c2}"_金融数值格式化
            double price;
            Console.Write("Please enter a decimal value:");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine($"{price,20:c2}");
            //￥1,234,567,890.46
            //string.Format("{0,20:C2}",price)_金融数值格式化
            Console.WriteLine(string.Format("{0,20:C2}", price));        }
    }
}

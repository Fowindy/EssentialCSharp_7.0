/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月26日 星期三 21:50:14
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月26日 星期三 21:50:14
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_30
{
    public class Listing02_30
    {
        public static void Main()
        {
            string middleCText = "261.626";
            double middleC = System.Convert.ToDouble(middleCText);
            bool boolean = System.Convert.ToBoolean(middleC);
            Console.WriteLine(middleC);//261.626
            Console.WriteLine(boolean);//True
        }
    }
}

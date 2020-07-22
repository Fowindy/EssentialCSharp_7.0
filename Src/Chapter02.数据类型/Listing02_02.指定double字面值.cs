/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月22日 星期三 17:34:42
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月22日 星期三 17:34:42
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_02
{
    public class Listing02_02
    {
        public static void Main()
        {
            Console.WriteLine(1618.033988749895);
            //输出    1618.03398874989
            //double精度为16位有效数字,所以最后数字5丢失了
        }
    }
}

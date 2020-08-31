/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月31日 星期一 00:22:02
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月31日 星期一 00:22:02
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter03.更多数据类型.Listing03_23
{
    public class Listing03_23
    {
        public static void Main()
        {
            string[] languages = new string[9];
            //错误:索引越界,8是最高索引
            languages[4] = languages[9];
        }
    }
}

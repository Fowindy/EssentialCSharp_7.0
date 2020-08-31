/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月31日 星期一 08:50:49
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月31日 星期一 08:50:49
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter03.更多数据类型.Listing03_26
{
    public class Listing03_26
    {
        public static void Main()
        {
            bool[,,] cells;
            cells = new bool[2, 3, 3];
            //获取一维元素的长度
            Console.WriteLine(cells.GetLength(0));
            //获取整个数组的维数
            Console.WriteLine(cells.Rank);
        }
    }
}

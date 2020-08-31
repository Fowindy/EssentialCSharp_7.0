/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月31日 星期一 00:12:43
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月31日 星期一 00:12:43
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter03.更多数据类型.Listing03_21
{
    public class Listing03_21
    {
        public static void Main()
        {
            int[][] cells = {
                new int[]{ 1,0,2},
                new int[]{ 0,2,0},
                new int[]{ 1,2,1}
            };
            cells[1][0] = 1;
        }
    }
}

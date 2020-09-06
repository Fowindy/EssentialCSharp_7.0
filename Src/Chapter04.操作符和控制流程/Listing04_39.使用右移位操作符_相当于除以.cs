/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 21:19:36
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 21:19:36
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_39
{
    public class Listing04_39
    {
        public static void Main()
        {
            int x;
            x = (-7 >> 2);//11111001
                          //11111110
                          //-1-1 = -2
                          //右移相当于除2的2次方
                          //-7/4 = -2
            Console.WriteLine($"x = {x}");

        }
    }
}

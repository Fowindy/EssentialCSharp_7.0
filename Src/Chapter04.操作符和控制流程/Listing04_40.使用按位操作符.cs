/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月7日 星期一 09:39:56
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月7日 星期一 09:39:56
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_40
{
    public class Listing04_40
    {
        public static void Main()
        {
            byte and, or, xor;
            and = 12 & 7;
            or = 12 | 7;
            xor = 12 ^ 7;
            Console.WriteLine($"and = {and}\nor = {or}\nxor = {xor}");
        }
    }
}

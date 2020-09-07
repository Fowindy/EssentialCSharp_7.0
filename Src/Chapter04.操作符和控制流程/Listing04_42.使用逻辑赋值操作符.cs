/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月7日 星期一 13:34:08
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月7日 星期一 13:34:08
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_42
{
    public class Listing04_42
    {
        public static void Main()
        {
            byte and = 12, or = 12, xor = 12;
            and &= 7;//and = 4
            or |= 7;//or = 15
            xor ^= 7;//xor = 11
            Console.WriteLine($"and = {and}\nor = {or}\nxor = {xor}");
        }
    }
}

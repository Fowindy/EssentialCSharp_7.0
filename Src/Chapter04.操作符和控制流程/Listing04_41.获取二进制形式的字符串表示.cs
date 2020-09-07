/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月7日 星期一 10:26:37
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月7日 星期一 10:26:37
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_41
{
    public class Listing04_41
    {
        public static void Main()
        {
            const int size = 64;
            ulong value;
            char bit;
            Console.Write("Please enter an integer:");
            //使用long.Parse()支持负数
            //声明无符号的ulong
            value = (ulong)long.Parse(Console.ReadLine());
            ulong mask = 1UL << size - 1;
            //1UL:
            //000000000000000000000000000000000000000000000000000000000000001
            //1UL << 63
            //100000000000000000000000000000000000000000000000000000000000000
            //000000000000000000000000000000000000000000000000000000000000111 假如7
            for (int count = 0;count < size;count++)
            {
                bit = ((mask & value) != 0) ? '1' : '0';
                Console.Write(bit);
                mask >>= 1;//右移一位
            }
        }
    }
}

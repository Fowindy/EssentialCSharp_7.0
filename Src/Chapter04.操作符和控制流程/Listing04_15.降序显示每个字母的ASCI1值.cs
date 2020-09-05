/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月5日 星期六 11:45:10
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月5日 星期六 11:45:10
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_15
{
    public class Listing04_15
    {
        public static void Main()
        {
            char current;
            int unicodeValue;
            current = 'z';
            do 
            {
                //把当前的字符转换为int类型的unicode
                unicodeValue = current;
                Console.Write($"{current}={unicodeValue}\t");
                //到字母表中的前一个字符
                current--;
            } while (current >= 'a');
        }
    }
}

/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月5日 星期六 17:30:10
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月5日 星期六 17:30:10
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_19_06
{
    public class Listing04_19_06
    {
        public static void Main()
        {
            Console.Write("Please enter your email address:");
            string email = Console.ReadLine();
            bool insideDomain = false;
            foreach (char letter in email)
            {
                if (!insideDomain)
                {
                    if (letter == '@')
                    {
                        insideDomain = true;
                    }
                    continue;
                }
                Console.Write(letter);
            }
        }
    }
}

/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月22日 星期三 10:18:40
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月22日 星期三 10:18:40
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter01.CSharp概述.Listing01_15_01
{
    public class Listing01_15_01
    {
        public static void Main()
        {
            ConsoleKeyInfo inputKey;
            do
            {
                inputKey = Console.ReadKey();
                if (inputKey.KeyChar < 48 || inputKey.KeyChar > 57)
                {
                    Console.WriteLine("输入的不是数字,请重输");
                }
                else
                {
                    Console.WriteLine("输入的是数字,退出");
                }
            } while (inputKey.KeyChar < 48 || inputKey.KeyChar > 57);
        }
    }
}

﻿/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月16日 星期日 20:10:02
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月16日 星期日 20:10:02
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_26
{
    public class Listing02_26
    {
        public static void Main()
        {
            unchecked
            {
                //int.MaxValue==2147483647
                int n = int.MaxValue;
                n++;
                Console.WriteLine(n);
            }
        }
    }
}

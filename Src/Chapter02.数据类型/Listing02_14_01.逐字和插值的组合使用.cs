﻿/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月31日 星期五 13:55:24
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月31日 星期五 13:55:24
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_14_01
{
    public class Listing02_14_01
    {
        public static void Main()
        {
            Console.Write("请输入你的名字:");
            string firstName = Console.ReadLine();
            Console.Write("请输入你的姓氏:");
            string lastName = Console.ReadLine();
            Console.WriteLine($@"你的全名是:{
                lastName}{firstName}");
        }
    }
}

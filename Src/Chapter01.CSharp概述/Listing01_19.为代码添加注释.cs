/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月22日 星期三 12:56:40
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月22日 星期三 12:56:40
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter01.CSharp概述.Listing01_19
{
    public class Listing01_19
    {
        public static void Main()
        {
            string firstName;//定义存储名字的变量
            string lastName;//定义存储姓氏的变量
            Console.WriteLine("Hey You!");//输出招呼语
            Console.Write/*不自动换行*/("Please enter your first name:");
            firstName = Console.ReadLine();
            Console.Write/*不自动换行*/("Please enter your last name:");
            lastName = Console.ReadLine();
            /*以占位符的方式显示
             * 打招呼的方法
             */
            Console.WriteLine("Your full name is {0} {1}.",firstName,lastName);
        }
    }
}

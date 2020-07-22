/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月22日 星期三 11:00:07
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月22日 星期三 11:00:07
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter01.CSharp概述.Listing01_16
{
    public class Listing01_16
    {
        public static void Main()
        {
            Console.WriteLine("Hey You!");
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Your full name is {firstName} {lastName}.");
        }
    }
}

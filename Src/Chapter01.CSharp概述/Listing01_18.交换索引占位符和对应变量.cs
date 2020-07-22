/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月22日 星期三 11:24:26
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月22日 星期三 11:24:26
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter01.CSharp概述.Listing01_18
{
    public class Listing01_18
    {
        public static void Main()
        {
            Console.WriteLine("Hey You!");
            Console.Write("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Your full name is {1} {0}.", firstName,lastName);
        }
    }
}

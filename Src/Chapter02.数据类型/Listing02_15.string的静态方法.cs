/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月12日 星期三 07:22:27
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月12日 星期三 07:22:27
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_15
{
    public class Listing02_15
    {
        public static void Main()
        {
            //string.Format(string format,...)
            string text, firstName, lastName;
            Console.Write("Please enter your first name:");
            firstName = Console.ReadLine();
            Console.Write("Please enter your last name:");
            lastName = Console.ReadLine();
            text = string.Format("Your full name is {0} {1}.", firstName, lastName);
            Console.WriteLine(text);
            /************************************************************************/
            /* Your full name is wang yue.                                                                     */
            /************************************************************************/

            //string.Concat(string str0,string str1)_连接字符串无空格
            text = string.Concat(firstName, lastName);
            Console.WriteLine(text);
            /************************************************************************/
            /* wangyue                                                                     */
            /************************************************************************/

            //int string.Compare(string str0,string str1)_区分大小写的字符串比较
            string option;
            Console.Write("Please enter help:");
            option = Console.ReadLine();
            //区分大小写的字符串比较
            int result = string.Compare(option, "help");
            Console.WriteLine(result);
            //相等---显示0
            //option < help---显示-1
            //option > help---显示1
        }
    }
}

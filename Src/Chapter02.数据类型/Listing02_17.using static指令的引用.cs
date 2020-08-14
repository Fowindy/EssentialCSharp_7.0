/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月14日 星期五 23:25:57
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月14日 星期五 23:25:57
 *          修改理由：创建文档
 * ==============================================================================*/
//使用using指令可允许在代码中省略命名空间
using static System.Console;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_17
{
    public class Listing02_17
    {
        public static void Main()
        {
            string firstName;
            string lastName;
            WriteLine("Hey you!");
            Write("Please enter your first name:");
            firstName = ReadLine();
            Write("Please enter your last name:");
            lastName = ReadLine();
            WriteLine($"Your full name is {firstName} {lastName}.");
        }
    }
}

/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月31日 星期一 09:05:57
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月31日 星期一 09:05:57
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter03.更多数据类型.Listing03_29
{
    public class Listing03_29
    {
        public static void Main()
        {
            string reverse, palindrome;
            char[] temp;
            Console.Write("Please enter a palindrome:");
            palindrome = Console.ReadLine();

            //移除用户输入字符串中的空格
            reverse = palindrome.Replace(" ", "");
            //转换为小写
            reverse = reverse.ToLower();
            //转换为字符数组
            temp = reverse.ToCharArray();
            //反转字符数组
            Array.Reverse(temp);
            //将反转后的字符数组转换成字符串并检查是否为回文
            if (reverse == new string(temp))
            {
                Console.WriteLine($"{palindrome} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{palindrome} is NOT a palindrome.");
            }
        }
    }
}

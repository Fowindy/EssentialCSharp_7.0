/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月1日 星期二 12:55:39
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月1日 星期二 12:55:39
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_03
{
    public class Listing04_03
    {
        public static void Main()
        {
            int numerator;
            int denominator;
            int quotient;
            int remainder;

            Console.Write("Please Enter the numerator:");
            numerator = int.Parse(Console.ReadLine());

            Console.Write("Please Enter the denominator:");
            denominator = int.Parse(Console.ReadLine());

            quotient = numerator / denominator;
            remainder = numerator % denominator;

            Console.WriteLine($"{numerator} / {denominator} = {quotient} with remainder {remainder}");
        }
    }
}

/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月31日 星期一 00:36:11
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月31日 星期一 00:36:11
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter03.更多数据类型.Listing03_25
{
    public class Listing03_25
    {
        public static void Main()
        {
            string[] languages = new string[]{
                "C#", "COBOL", "Java",
                "C++", "Visual Basic", "Pascal",
                "Fortran", "Lisp", "J#"};

            Array.Sort(languages);

            string searchString = "COBOL";
            int index = Array.BinarySearch(
                languages, searchString);
            Console.WriteLine(
                "The wave of the future, "
                + $"{ searchString }, is at index { index }.");

            Console.WriteLine();
            Console.WriteLine(
                $"{ "First Element",-20 }\t{ "Last Element",-20 }");
            Console.WriteLine(
                $"{ "-------------",-20 }\t{ "------------",-20 }");
            Console.WriteLine(
                    $"{ languages[0],-20 }\t{ languages[languages.Length - 1],-20 }");
            Array.Reverse(languages);
            Console.WriteLine(
                    $"{ languages[0],-20 }\t{ languages[languages.Length - 1],-20 }");
            Array.Clear(languages, 0, languages.Length);
            Console.WriteLine(
                    $"{ languages[0],-20 }\t{ languages[languages.Length - 1],-20 }");
            Console.WriteLine(
                $"After clearing, the array size is: { languages.Length }");

        }
    }
}

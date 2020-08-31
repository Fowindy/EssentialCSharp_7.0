/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月30日 星期日 23:20:22
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月30日 星期日 23:20:22
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter03.更多数据类型.Listing03_19
{
    public class Listing03_19
    {
        public static void Main()
        {
            string[] languages = new string[9]{ "C#","COBOL","Java","C++","Visual Basic",
            "Pascal","Fortran","Lisp","J#"};
            //将索引为3的元素赋值给language变量
            string language = languages[3];
            //将索引为2的元素赋值给索引为3的变量
            languages[3] = languages[2];
            //将language变量赋值给索引为2的变量
            languages[2] = language;
            for (int i=0;i<languages.Length;i++)
            {
                Console.WriteLine(languages[i]);
            }
        }
    }
}

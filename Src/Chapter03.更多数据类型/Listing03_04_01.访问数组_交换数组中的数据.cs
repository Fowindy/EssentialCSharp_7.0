/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月29日 星期六 06:30:50
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月29日 星期六 06:30:50
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter03.更多数据类型.Listing03_04_01
{
    public class Listing03_04_01
    {
        public static void Main()
        {
            string[] languages = new string[9] {
                "C#", "COBOL", "Java", "C++", "Visual Basic", "Pascal", "Fortran", "Lisp", "J#"
            };
            //保存"C++"到变量language
            string language = languages[3];
            //将language的数据赋值给languages[3]
            languages[3] = languages[2];
            //将变量language的数据赋值给languages[2]
            languages[2] = language;
            for (int i= 0;i<languages.Length;i++)
            {
                Console.WriteLine(languages[i]);
            }
        }
    }
}

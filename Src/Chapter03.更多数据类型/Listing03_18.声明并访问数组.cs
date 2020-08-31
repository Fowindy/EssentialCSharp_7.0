/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月30日 星期日 22:58:00
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月30日 星期日 22:58:00
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter03.更多数据类型.Listing03_18
{
    public class Listing03_18
    {
        public static void Main()
        {
            string[] languages = new string[9]{ "C#","COBOL","Java","C++","Visual Basic",
            "Pascal","Fortran","Lisp","J#"};
            //将数组索引为4的元素赋值给变量language
            string language = languages[4];
            Console.WriteLine(language);
        }
    }
}

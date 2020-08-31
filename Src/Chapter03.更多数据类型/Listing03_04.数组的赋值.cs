/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月28日 星期五 23:44:04
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月28日 星期五 23:44:04
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter03.更多数据类型.Listing03_04
{
    public class Listing03_04
    {
        public static void Main()
        {
            string[] languages = { "C#", "COBOL", "Java", "C++", "Visual Basic", "Pascal", "Fortran", "Lisp", "J#" };
            languages = new string[9];
            languages = new string[] { "C#", "COBOL", "Java", "C++", "Visual Basic", "Pascal", "Fortran", "Lisp", "J#" };
            //多维数组赋值和初始化(二维)
            int[,] cells = new int[2, 3] { {0,1,2},{1,2,3}}; 
        }
    }
}

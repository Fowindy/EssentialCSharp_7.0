/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月17日 星期一 19:08:16
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月17日 星期一 19:08:16
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter02.数据类型.Listing02_29
{
    public class Listing02_29
    {
        public static void Main()
        {
            string text = "9.11E-31";
            float kgElectronMass = float.Parse(text);
            Console.WriteLine(kgElectronMass);
        }
    }
}

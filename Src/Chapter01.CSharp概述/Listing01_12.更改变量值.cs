/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年7月21日 星期二 23:57:56
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年7月21日 星期二 23:57:56
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter01.CSharp概述.Listing01_12
{
    public class Listing01_12
    {
        public static void Main()
        {
            string valerie;     //声明未初始化的变量valerie
            string miracleMax = "Have fun storming the castle!";    //声明初始化的变量miracleMax
            valerie = "Think it will work?";        //为为初始化的变量valerie赋初值
            Console.WriteLine(miracleMax);      //打印输出miracleMax
            Console.WriteLine(valerie);         //打印输出valerie

            miracleMax = "It would take a miracle.";    //覆盖miracleMax的初始值
            Console.WriteLine(miracleMax);              //打印输出miracleMax变量
        }
    }
}

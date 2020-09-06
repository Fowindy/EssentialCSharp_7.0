/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 11:21:30
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 11:21:30
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_27
{
    public class Listing04_27
    {
        public static void Main()
        {
            int playerCount;
            Console.Write("Enter the number of players(1 or 2):");
            playerCount = int.Parse(Console.ReadLine());
            if (playerCount != 1 && playerCount != 2)
            {
                string message = "You entered an invalid number of players.";
            }
            else
            {
                //...
            }
            //错误:message不在作用域
            //Console.WriteLine(message);
        }
    }
}

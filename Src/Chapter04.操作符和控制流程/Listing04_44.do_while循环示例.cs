/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月7日 星期一 16:17:36
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月7日 星期一 16:17:36
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_44
{
    public class Listing04_44
    {
        public static void Main()
        {
            bool valid;
            string input;
            int currentPlayer = 1;
            do 
            {
                valid = false;
                Console.Write($"\nPlayer {currentPlayer}:Enter move:");
                input = Console.ReadLine(); 
                if (int.Parse(input) > 5)
                {
                    valid = true;
                }
            } while (!valid);
        }
    }
}

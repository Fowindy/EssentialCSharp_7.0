/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月5日 星期六 17:40:20
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月5日 星期六 17:40:20
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_19_07
{
    public class Listing04_19_07
    {
        public static void Main()
        {
            Console.Write("Please enter command:");
            string input = Console.ReadLine();
            switch (input)
            {
                case "exit":
                case "quit":
                    Console.WriteLine("Exiting app...");
                    break;
                case "restart":
                    Reset();
                    goto case "start";
                case "start":
                    GetMove();
                    break;
                default:
                    Console.WriteLine(input);
                    break;
            }
        }

        private static void GetMove()
        {
            throw new NotImplementedException();
        }

        private static void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

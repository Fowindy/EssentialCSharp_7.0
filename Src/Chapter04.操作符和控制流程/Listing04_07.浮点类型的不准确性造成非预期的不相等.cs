/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月5日 星期六 08:44:08
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月5日 星期六 08:44:08
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_07
{
    public class Listing04_07
    {
        public static void Main()
        {
            decimal decimalNumber = 4.2M;
            double doubleNumber1 = 0.1F * 42F;
            double doubleNumber2 = 0.1D * 42D;
            float floatNumber = 0.1F * 42F;

            Trace.Assert(decimalNumber != (decimal)doubleNumber1);
            Console.WriteLine($"{decimalNumber} != {(decimal)doubleNumber1}");
            //4.2 != 4.2000002861023

            Trace.Assert((double)decimalNumber != doubleNumber1);
            Console.WriteLine($"{(double)decimalNumber} != {doubleNumber1}");

            Trace.Assert((float)decimalNumber != floatNumber);
            Console.WriteLine($"{(float)decimalNumber}M != {floatNumber}F");

            //Trace.Assert(doubleNumber1 != (double)floatNumber);
            //Console.WriteLine($"{doubleNumber1} != {(double)floatNumber}");

            Trace.Assert(doubleNumber1 != doubleNumber2);
            Console.WriteLine(
            $"{doubleNumber1} != {doubleNumber2}");

            Trace.Assert(floatNumber != doubleNumber2);
            Console.WriteLine(
            $"{floatNumber}F != {doubleNumber2}D");

            Trace.Assert((double)4.2F != 4.2D);
            Console.WriteLine($"{(double)4.2F} != {4.2D}");

            Trace.Assert(4.2F != 4.2D);
            Console.WriteLine(
            $"{14.2F}F != {4.2D}D");
        }
    }
}

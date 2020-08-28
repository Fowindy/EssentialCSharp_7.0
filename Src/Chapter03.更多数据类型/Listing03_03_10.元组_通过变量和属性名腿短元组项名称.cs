/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月28日 星期五 12:13:53
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月28日 星期五 12:13:53
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter03.更多数据类型.Listing03_03_10
{
    public class Listing03_03_10
    {
        public static void Main()
        {
            string country = "Malawi";
            string capital = "Lilongwe";
            double gdpPerCapital = 226.50;
            var countryInfo = (country, capital, gdpPerCapital);
            //C# 7.1版本
//            Console.WriteLine($@"The poorest country in the world in 2017 was {
//countryInfo.country},{countryInfo.capital}:{countryInfo.gdpPerCapital}");
        }
    }
}

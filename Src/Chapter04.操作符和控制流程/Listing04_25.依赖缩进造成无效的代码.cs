/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月6日 星期日 10:06:47
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月6日 星期日 10:06:47
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter04.操作符和控制流程.Listing04_25
{
    public class Listing04_25
    {
        public static void Main()
        {
            double radius;//声明变量,存储半径
            double area = 0;//声明变量,存储面积
            double circumstance = 0;//声明变量,存储周长
            Console.Write("请输入圆的半径:");
            //将输入的半径转换为double类型
            radius = double.Parse(Console.ReadLine());
            if (radius >= 0)
                //计算圆的面积和周长
                area = Math.PI * radius * radius;
            circumstance = 2 * Math.PI * radius;
            Console.WriteLine($"The radius of the circle is:{radius:0.00}\n" +
                $"The area of circle is:{area:0.00}\n" +
                $"The circumstance of circle is:{circumstance:0.00}");
        }
    }
}
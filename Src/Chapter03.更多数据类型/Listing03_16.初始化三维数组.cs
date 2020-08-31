/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年8月30日 星期日 22:32:05
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年8月30日 星期日 22:32:05
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Chapter03.更多数据类型.Listing03_16
{
    public class Listing03_16
    {
        public static void Main()
        {
            bool[,,] cells;
            cells = new bool[2, 3, 3]
                {
                    //Player 1 moves
                    {
                        { true,false,false},
                        { true,false,false},
                        { true,false,true}
                    }
                    ,
                    //Player 2 moves
                    {
                        { false,false,true},
                        {false,true,false },
                        {false,true,false }
                    }
                };
        }
    }
}

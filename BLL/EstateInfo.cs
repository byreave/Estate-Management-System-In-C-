using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class EstateInfo
    {
        public static string CheckEstateOutInfo(string Username, string EstateID, string OutDate, string Usage, string comment, string admin)
        {
            int result = EstateOperation.EstateOut(Username, EstateID, OutDate, Usage, comment, admin);
            string resStr = ""; //结果的字符串
            switch(result)
            {
                case 0:
                    resStr = "数据库操作错误,请检查网络连接";
                    break;
                case 1:
                    resStr = "出租成功~";
                    break;
                case 2:
                    resStr = "该资产已被占用！";
                    break;
                case 3:
                    resStr = "该资产在维修或者已报废！";
                    break;
                case 4:
                    resStr = "没有该用户！";
                    break;
                default:
                    resStr = "Unknown Error!";
                    break;
                    
            }
            return resStr;
        }
    }
}

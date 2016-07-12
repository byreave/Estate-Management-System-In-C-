using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace DAL
{
    public class AdminOperation
    {
        /// <summary>
        /// 判断是否登陆成功
        /// </summary>
        /// <param name="adm"></param>
        /// <returns></returns>
        public static bool Login(Admin adm)
        {
            string sql = "SELECT * FROM Admin WHERE Username = '" + adm.Username + "' AND Password = '" + adm.Password + "'";
            int result = (int)dbHelper.GetScalar(sql);
            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="newPwd"></param>
        /// <returns></returns>
        public static bool ModifyPassword(string Username, string newPwd)
        {
            string sql = "UPDATE TABLE Admin SET Password = '" + newPwd + "' WHERE Username = '" + Username + "'";
            int result = dbHelper.ExecuteCommand(sql);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

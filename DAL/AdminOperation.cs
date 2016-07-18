using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
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
            //string sql = "SELECT * FROM Admin WHERE Username = '" + adm.Username + "' AND Password = '" + adm.Password + "'";
            string sql = "SELECT * FROM Admin WHERE Username = @Username AND Password = @Password";  //加入防注入
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@Username", adm.Username), new SqlParameter("@Password", adm.Password) };
            //int result = (int)dbHelper.GetScalar(sql)
            int result = (int)dbHelper.GetScalar(sql, paras);
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
            //string sql = "UPDATE TABLE Admin SET Password = '" + newPwd + "' WHERE Username = '" + Username + "'";
            string sql = "UPDATE Admin SET Password = @Password WHERE Username = @Username";  //加入防注入
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@Username", Username), new SqlParameter("@Password", newPwd) };

            //int result = dbHelper.ExecuteCommand(sql);
            int result = dbHelper.ExecuteCommand(sql, paras);

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataSet GetAllAdmin()
        {
            string sql = "SELECT Username FROM Admin";
            return dbHelper.GetDataSet(sql);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class UserOperation
    {
        /// <summary>
        /// 新增人员
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public static bool UserAdd(User newUser)
        {
            string sql = "INSERT INTO UserInfo (Name, Career, Comment) VALUES ('" + newUser.Name + "', '" + newUser.Career + "', '" + newUser.Comment + "')";
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
        /// <summary>
        /// 编辑人员
        /// </summary>
        /// <param name="newInfo"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool UserEdit(User newInfo, string id)
        {
            string sql = "UPDATE UserInfo SET Name = '" + newInfo.Name + "', Career = '" + newInfo.Career + "', Comment = '" + newInfo.Comment + "'";
            sql += " WHERE UID = '" + id + "'";
            int result = dbHelper.ExecuteCommand(sql);
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
        /// 删除人员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool UserDelete(string id)
        {
            string sql = "DELETE FROM UserInfo WHERE UID = '" + id + "'";
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
        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAllUser()
        {
            string sql = "SELECT * FROM UserInfo";
            return dbHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 获取所有用户的名字
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAllUserName()
        {
            string sql = "SELECT Name From UserInfo";
            return dbHelper.GetDataSet(sql);
        }
    }
}

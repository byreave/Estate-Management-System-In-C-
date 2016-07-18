using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class EstateOperation
    {
        /// <summary>
        /// 增加一个大的分类
        /// </summary>
        /// <param name="TypeAName"></param>
        /// <returns></returns>
        public static bool EstateTypeAAdd(string TypeAName)
        {
            string sql = "INSERT INTO EstateTypeA (TypeAName) VALUES ('" + TypeAName + "')";
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
        /// 插入一个小类
        /// </summary>
        /// <param name="TypeAName"></param>
        /// <param name="TypeBName"></param>
        /// <returns></returns>
        public static bool EstateTypeBAdd(string TypeAName, string TypeBName)
        {
            //先查找有没有该大类
            string sqlSearch = "SELECT TypeID FROM EstateTypeA WHERE TypeAName = '" + TypeAName + "'";
            if(dbHelper.GetScalar(sqlSearch)!=null)
            {
                int typeA = (int)dbHelper.GetScalar(sqlSearch);
                string sqlInsert = "INSERT INTO EstateTypeB (TypeIDA, TypeBName) VALUES('"+typeA.ToString()+"', '"+TypeBName+"')";
                int insertRes = dbHelper.ExecuteCommand(sqlInsert);
                if(insertRes > 0)
                    return true;
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 添加一个资产
        /// </summary>
        /// <param name="newEstate"></param>
        /// <returns></returns>
        public static bool EstateAdd(Estate newEstate)
        {
            string sql = "INSERT INTO Estate (EstateName, TypeBID, Model, Price, PurchaseDate, Status, Username, Comment)";
            sql += " VALUES(@EstateName, '" + newEstate.TypeBID + "', @Model, @Price, '" + newEstate.PurchaseDate + "', '" + newEstate.Status + "', '" + newEstate.Username + "', @Comment)";
            //加入防注入
            //sql += " VALUES('"+newEstate.EstateName+"', '"+newEstate.TypeBID+"', '"+newEstate.Model+"', '"+newEstate.Price.ToString()+"', '"+newEstate.PurchaseDate+"', '"+newEstate.Status+"', '"+newEstate.Username+"', '"+newEstate.Comment+"')";
            SqlParameter[] paras = new SqlParameter[]{new SqlParameter("@EstateName", newEstate.EstateName), new SqlParameter("@Model", newEstate.Model), new SqlParameter("@Price", newEstate.Price.ToString()), new SqlParameter("@Comment", newEstate.Comment)};
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
        /// <summary>
        /// 更改资产的信息
        /// </summary>
        /// <param name="editEstate"></param>
        /// <param name="EstateID"></param>
        /// <returns></returns>
        public static bool EstateEdit(Estate editEstate, string EstateID)
        {
            string sql = "UPDATE Estate SET EstateName = @EstateName, TypeBID = '"+editEstate.TypeBID+"', Model=@Model, Price=@Price, PurchaseDate='"+editEstate.PurchaseDate+"', Status='"+editEstate.Status+"', Username='"+editEstate.Username+"', Comment = @Comment";
            sql += " WHERE EID = '"+EstateID+"'";
            //加入防注入
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@EstateName", editEstate.EstateName), new SqlParameter("@Model", editEstate.Model), new SqlParameter("@Price", editEstate.Price.ToString()), new SqlParameter("@Comment", editEstate.Comment) };

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
        /// <summary>
        /// 删除一个资产记录
        /// </summary>
        /// <param name="EstateID"></param>
        /// <returns></returns>
        public static bool EstateDelete(string EstateID)
        {
            string sql = "DELETE FROM Estate WHERE EID = '" + EstateID + "'";

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
        /// 出租资产
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="EstateID"></param>
        /// <param name="OutDate"></param>
        /// <param name="Usage"></param>
        /// <param name="comment"></param>
        /// <param name="admin"></param>
        /// <returns>1成功 2被占用 3状态不正常 0数据库操作失败 4无该用户</returns>
        public static int EstateOut(string Username, string EstateID, string OutDate, string Usage, string comment, string admin)
        {
            //先查询是否有该用户
            string selectSql = "SELECT * FROM UserInfo WHERE Name = '" + Username + "'";
            if(dbHelper.GetScalar(selectSql) != null)
            {
                //查看资产是否被人占用
                string selectIfAvailable = "SELECT Username, Status FROM Estate WHERE EID = '" + EstateID + "'";
                SqlDataReader dr = dbHelper.GetReader(selectIfAvailable);
                while(dr.Read())
                {
                    if (dr["Username"].ToString() != "")
                    {
                        dr.Close();
                        return 2;
                    }
                    if (dr["Status"].ToString() != "正常")
                    {
                        dr.Close();
                        return 3;
                    }
                }
                dr.Close();
                //插入租出资产的表
                string sql = "INSERT INTO EstateOut (EID, OutDate, AdminUser, Usage, Comment) VALUES ('" + EstateID + "', '" + OutDate + "', '" + admin + "', @Usage, @Comment)";
                SqlParameter[] paras = new SqlParameter[]{new SqlParameter("@Usage", Usage), new SqlParameter("@Comment", comment)};
                int result1 = dbHelper.ExecuteCommand(sql, paras);
                //把用户名字插入资产信息的表
                sql = "UPDATE Estate SET Username = '"+Username+"' WHERE EID = '"+EstateID+"'";
                int result2 = dbHelper.ExecuteCommand(sql);
                if(result1+result1 > 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                //throw (new Exception("No Such User"));
                return 4;
            }
        }
        /// <summary>
        /// 归还资产
        /// </summary>
        /// <param name="EstateID"></param>
        /// <param name="reDate"></param>
        /// <param name="admin"></param>
        /// <returns></returns>
        public static bool EstateReturn(string EstateID, string reDate, string admin)
        {
            //将资产设为无人占有
            string sql = "UPDATE Estate SET Username = '' WHERE EID = '" + EstateID + "'";
            int result = dbHelper.ExecuteCommand(sql);
            if(result > 0)
            {
                //插入归还记录表
                string delSql = "DELETE FROM EstateOut WHERE EID = '" + EstateID + "'";
                int result1 = dbHelper.ExecuteCommand(delSql);
                string insertSql = "INSERT INTO EstateReturn (EID, ReturnDate, AdminUser) VALUES('" + EstateID + "', '" + reDate + "', '" + admin + "')";
                int result2 = dbHelper.ExecuteCommand(insertSql);
                if(result2+result1 > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 通过大类'A'或者小类'B'来获取所有资产
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static DataSet GetAllEstateByCatagory(string keyword, char type)
        {
            string catSqlA, catSqlB, sql;
            if(type == 'A')
            {
                //可以查出所有大类的ID
                catSqlA = "SELECT TypeID FROM EstateTypeA WHERE TypeAName LIKE '%"+keyword+"%'";
                //可以查出符合条件的大类中所有小类的ID
                catSqlB = "SELECT TypeIDB FROM EstateTypeB WHERE TypeIDA IN ("+catSqlA+")";
                sql = "SELECT * FROM Estate WHERE TypeBID IN ("+catSqlB+")";
            }
            else if(type == 'B')
            {
                //直接查出所有符合条件的小类
                catSqlB = "SELECT TypeIDB FROM EstateTypeB WHERE TypeBName LIKE '%"+keyword+"%'";
                sql = "SELECT * FROM Estate WHERE TypeBID IN (" + catSqlB + ")";
            }
            else
            {
                return null;
            }

            return dbHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 根据ID查找资产详细信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataSet GetEstateByID(string id)
        {
            string sql = "SELECT * FROM Estate WHERE EID = '" + id + "'";
            return dbHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 根据使用者查找资产信息
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static DataSet GetEstateByUser(string username)
        {
            string sql = "SELECT * FROM Estate WHERE Username LIKE '%" + username + "%'";
            return dbHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 获得所有资产信息
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAllEstate()
        {
            string sql = "SELECT * FROM Estate";
            return dbHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 获取所有大类
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAllTypeA()
        {
            string sql = "SELECT * FROM EstateTypeA";
            return dbHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 根据大类获取所有小类
        /// </summary>
        /// <param name="typeAname"></param>
        /// <returns></returns>
        public static DataSet GetTypeBByTypeA(string typeAname)
        {
            try
            {
                Convert.ToInt32(typeAname);//是数字就用ID搜索
                return GetTypeBByTypeAID(typeAname);
            }
            catch
            {
                string sqlA = "SELECT TypeID FROM EstateTypeA WHERE TypeAName = '" + typeAname + "'";
                string sqlB = "SELECT * FROM EstateTypeB WHERE TypeIDA IN (" + sqlA + ")";
                return dbHelper.GetDataSet(sqlB);
            }
        }

        public static DataSet GetTypeBByTypeAID(string typeAID)
        {
            string sql = "SELECT * FROM EstateTypeB WHERE TypeIDA = '" + typeAID + "'";
            return dbHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 获取所有小类
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAllTypeB()
        {
            string sql = "SELECT TypeBName FROM EstateTypeB";
            return dbHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 根据名字获取小类ID
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetTypeBIDByName(string name)
        {
            string sql = "SELECT TypeIDB FROM EstateTypeB WHERE TypeBName = '" + name + "'";
            SqlDataReader dr = dbHelper.GetReader(sql);
            string result = "";
            while(dr.Read())
            {
                result = dr["TypeIDB"].ToString();

            }
            dr.Close();
            return result;
        }
        /// <summary>
        /// 获取所有正在出租的资产
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAllRentEstate()
        {
            string sql = "SELECT * FROM EstateOut";
            return dbHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 根据ID搜索正在出租的资产
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataSet GetRentEstateByID(string id)
        {
            string sql = "SELECT * FROM EstateOut WHERE EID = '" + id + "'";
            return dbHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 获取所有归还记录
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAllReturnEstate()
        {
            string sql = "SELECT * FROM EstateReturn";
            return dbHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 根据资产编号搜索资产归还记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataSet GetReturnEstateByID(string id)
        {
            string sql = "SELECT * FROM EstateReturn WHERE EID = '" + id + "'";
            return dbHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 删除大类 同时删除所有小类
        /// </summary>
        /// <param name="typeID"></param>
        /// <returns></returns>
        public static bool TypeADelete(string typeID)
        {
            string delSqlA = "DELETE FROM EstateTypeB Where TypeIDA = '"+typeID+"'";
            string delSqlB = "DELETE FROM EstateTypeA WHERE TypeID = '" + typeID + "'";
            int result = dbHelper.ExecuteCommand(delSqlB);
            int result2 = dbHelper.ExecuteCommand(delSqlA);
            if(result > 0 && result2 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除小类
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool TypeBDelete(string name)
        {
            int num;
            string sql;
            try
            {
                num = Convert.ToInt32(name);
                sql = "DELETE FROM EstateTypeB WHERE TypeIDB = '" + name + "'";//是数字则按照编号删除
            }
            catch
            {
                sql = "DELETE FROM EstateTypeB WHERE TypeBName = '" + name + "'";
            }
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

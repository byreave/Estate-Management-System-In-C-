using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

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
            string sql = "INSERT INTO EstateTypeA (Name) VALUES ('" + TypeAName + "')";
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
            int result = dbHelper.ExecuteCommand(sqlSearch);
            if (result > 0)
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
            sql += " VALUES('"+newEstate.EstateName+"', '"+newEstate.TypeBID+"', '"+newEstate.Model+"', '"+newEstate.Price.ToString()+"', '"+newEstate.PurchaseDate+"', '"+newEstate.Status+"', '"+newEstate.Username+"', '"+newEstate.Comment+"')";
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
        /// 更改资产的信息
        /// </summary>
        /// <param name="editEstate"></param>
        /// <returns></returns>
        public static bool EstateEdit(Estate editEstate)
        {
            string sql = "UPDATE Estate SET ";
            return true; //to do
        }
    }
}

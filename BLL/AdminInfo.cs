using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class AdminInfo
    {
        /// <summary>
        /// 验证修改密码是否成功
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="newPas"></param>
        /// <param name="oldPas"></param>
        /// <param name="conPas"></param>
        /// <returns>返回 0 旧密码错误 1成功 2确认密码错误</returns>
        public static int checkChangePwd(string admin, string newPas, string oldPas, string conPas)
        {
            Admin a = new Admin();
            a.Username = admin;
            a.Password = oldPas;
            if(AdminOperation.Login(a))
            {
                if(newPas == conPas)
                {
                    AdminOperation.ModifyPassword(admin, newPas);
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}

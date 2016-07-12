using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Estate
    {
        public string EstateName { set; get; } //资产名称
        public string TypeBID { set; get; } //小类的ID
        public string Model { set; get; }   //型号
        public float Price { set; get; }    //价格
        public string PurchaseDate { set; get; } //购买日期
        public string Status { set; get; } // 状态
        public string Username { set; get; } //领用的用户
        public string Comment { set; get; }//备注
    }
    //TypeBID int not null,
	//Model varchar(50) not null,
	//Price float not null,
	//PurchaseDate date not null,
	//Status varchar(30) not null,
	//User varchar(30),
	//Comment varchar(255),

}

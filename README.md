# CSharp Final

##to do:
+基本写完了 现在测试+DEBUG~

+加入了更加好看的UI

+app.config中的数据库信息要改.

+应作业要求加入了泛型集合的使用 并且成功地降低了程序的效率:-)

+增加了一些关键输入窗口的防注入
##资产管理系统 
三层架构设计<br>
Pre + DAL + BLL<br>
并不知道是什么鬼...
##数据库设计
本来是准备用MySQL的...但是被强制用了SQL SERVER 数据库如下


    CREATE TABLE admin(
    	UID int not null auto_increment,
    	Username varchar(30) not null,
    	Password varchar(30) not null,
    	PRIMARY KEY(UID)
    );
    //大类
    CREATE TABLE EstateTypeA(
    	TypeID int not null auto_increment,
    	TypeAName varchar(30) not null
    );
    //小类
    CREATE TABLE EstateTypeB(
    	TypeIDB int not null auto_increment,
    	TypeIDA int not null,
    	TypeBName varchar(30) not null,
    	PRIMARY KEY(TypeIDB)
    );
    
    CREATE TABLE Estate(
    	EID int not null auto_increment,
    	EstateName varchar(50) not null,
    	TypeBID int not null,
    	Model varchar(50) not null,
    	Price float not null,
    	PurchaseDate date not null,
    	Status varchar(30) not null,
    	Username varchar(30),
    	Comment varchar(255),
    	PRIMARY KEY(EID)
    );
    
    CREATE TABLE UserInfo(
    	UID int not null auto_increment,
    	Name varchar(30) not null,
    	Career varchar(30),
    	Comment varchar(255),
    	PRIMARY KEY(UID)
    );
    
    CREATE TABLE EstateOut(
    	EID int not null,
    	OutDate date not null,
    	AdminUser varchar(30) not null,
    	Usage varchar(255),
    	Comment varchar(255)
    );
    
    CREATE TABLE EstateReturn(
    	EID int not null,
    	ReturnDate date not null,
    	AdminUser varchar(30) not null
    );

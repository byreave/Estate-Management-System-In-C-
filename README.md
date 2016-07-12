# CSharp Final

##to do:
+各种表的各种按钮功能<br>
+归还记录搜索
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

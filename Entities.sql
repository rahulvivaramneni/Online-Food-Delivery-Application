/*creating database*/
create database OnlineFoodDelivery

create table Users(
[ID] [int] IDENTITY(1,1) NOT NULL,
[PreFix] [varchar](7) default 'UC' NOT NULL,
[UserId]  AS ([PreFix]+ RIGHT('000' + CAST(Id AS VARCHAR(3)), 3)) PERSISTED primary key,
FirstName varchar(50) not null,
LastName varchar(50) not null,
PhoneNumber varchar(10) not null,
EmailId varchar(50) unique not null,
UserPassword varchar(50) not null,
UserAddress varchar(100) not null,
City varchar(50) not null,
UserRole bit not null,
)

insert into Users(FirstName,LastName,PhoneNumber,EmailId,UserPassword,UserAddress,City,UserRole) values('Tina','Smith','9123456789','Tina@gmail.com','Tin@123','sadsfsdgrdfhgfgfxgdsfdf','Pune',0)
select * from Users

create table Restaurants(
[ID] [int] IDENTITY(1,1) NOT NULL,
[PreFix] [varchar](7) default 'RC' NOT NULL,
[RestaurantId]  AS ([PreFix]+ RIGHT('000' + CAST(Id AS VARCHAR(3)), 3)) PERSISTED primary key,
RestaurantName varchar(50) not null,
PhoneNumber varchar(10) not null,
RestaurantAddress varchar(100) not null,
City varchar(50) not null,
UserId varchar(10) foreign key references Users(UserId)
)
insert into Restaurants(RestaurantName,PhoneNumber,RestaurantAddress,City,UserId) values('Park Inn','987456321','Cannaught place','New Delhi','UC001')
select * from Restaurants

create table Items(
[ID] [int] IDENTITY(1,1) NOT NULL,
[PreFix] [varchar](7) default 'IC' NOT NULL,
[ItemId]  AS ([PreFix]+ RIGHT('000' + CAST(Id AS VARCHAR(3)), 3)) PERSISTED primary key,
RestaurantId varchar(10) foreign key references Restaurants(RestaurantId),
ItemName varchar(50) not null,
Price decimal not null,
ItemDescription varchar(200) not null,
isAvailable bit not null default 1
)

insert into Items(RestaurantId,ItemName,Price,ItemDescription) values('RC001','Maggie',40.00,'this is a delicious maggie')
select * from Items


create table DeliveryAgents(
[ID] [int] IDENTITY(1,1) NOT NULL,
[PreFix] [varchar](7) default 'AC' NOT NULL,
[AgentId]  AS ([PreFix]+ RIGHT('000' + CAST(Id AS VARCHAR(3)), 3)) PERSISTED primary key,
RestarauntId varchar(10) foreign key references Restaurants(RestaurantId),
AgentName varchar(30) not null,
AgentPhone varchar(11) not null)

insert into DeliveryAgents(RestarauntId,AgentName,AgentPhone) values('RC001','Rev','9678991234')
select * from DeliveryAgents

create table Orders(
[ID] [int] IDENTITY(1,1) NOT NULL,
[PreFix] [varchar](7) default 'OC' NOT NULL,
[OrderId]  AS ([PreFix]+ RIGHT('000' + CAST(Id AS VARCHAR(3)), 3)) PERSISTED primary key,
RestarauntId varchar(10) foreign key references Restaurants(RestaurantId),
AgentId varchar(10) foreign key references DeliveryAgents(AgentId),
UserId varchar(10) foreign key references Users(UserId),
PaymentMode varchar(20) not null,
Quantity int default 1,
TotalPrice decimal not null,
OrderStatus varchar(20) not null
)

insert into Orders(RestarauntId,AgentId,UserId,PaymentMode,Quantity,TotalPrice,OrderStatus) values('RC001','AC001','UC001','NetBanking',2,40.00,'Delivered')
select * from Orders

select * from Users
select *from Restaurants
select * from Items
select * from DeliveryAgents
select * from Orders

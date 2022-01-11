
/*creating database*/
create database OnlineFoodDelivery
use OnlineFoodDelivery
/*user table*/
/*Role-0-Customer,Role-1-Owner*/
create table Users(
UserId bigint identity primary key,
FirstName varchar(50) not null,
LastName varchar(50) not null,
PhoneNumber varchar(10) not null,
EmailId varchar(50) unique not null,
UserPassword varchar(50) not null,
UserAddress varchar(100) not null,
City varchar(50) not null,
UserRole varchar(10) not null,
)

create table Restaurants(
RestaurantId bigint identity primary key,
RestaurantName varchar(50) not null,
PhoneNumber varchar(10) not null,
RestaurantAddress varchar(100) not null,
City varchar(50) not null,
RestaurantImg varchar(255),
UserId bigint foreign key references Users(UserId)
)


create table Items(
ItemId bigint identity primary key,
RestaurantId bigint foreign key references Restaurants(RestaurantId),
ItemName varchar(50) not null,
Price decimal not null,
ItemDescription varchar(200) not null,
ItemImg varchar(255),
isAvailable bit not null default 1
)

create table DeliveryAgents(
AgentId bigint identity primary key,
RestaurantId bigint foreign key references Restaurants(RestaurantId),
AgentName varchar(30) not null,
AgentPhone varchar(11) not null)

create table Orders(
OrderId  bigint identity primary key,
RestaurantId bigint foreign key references Restaurants(RestaurantId),
AgentId bigint foreign key references DeliveryAgents(AgentId),
UserId bigint foreign key references Users(UserId),
PaymentMode varchar(20) not null,
TotalPrice decimal not null,
OrderStatus varchar(20) not null
)
create table OrderDetails(
OrderDetailsId bigint identity primary key,
OrderId bigint foreign key references Orders(OrderId),
ItemId bigint foreign key references Items(ItemId),
ItemPrice numeric,
Quantity int
)

/*drop table Users*/
insert into Users values('Tina','Smith','9123456789','Tina@gmail.com','Tin@123','sadsfsdgrdfhgfgfxgdsfdf','Pune','Customer')
insert into Users values('Priya','Smith','9123456789','Priya@gmail.com','Priy@123','sadsfsdgrdfhgfgfxgdsfdf','Pune','Admin')

insert into Restaurants values('Park Inn','987456321','Cannaught place','New Delhi','img1.jpg',1)
insert into Restaurants values('Central Park','907456321','Cannaught place','New Delhi','img2.jpg',1)



insert into Items values(1,'Maggie',40.00,'this is a delicious maggie','img3.jpg',0)
insert into Items values(1,'Sandwich',30.00,'this is a delicious sandwich','img4.jpg',0)


insert into DeliveryAgents values(1,'Rev','9678991234')
insert into DeliveryAgents values(2,'Ramesh','8956859658')


insert into Orders values(1,1,2,'NetBanking',40.00,'Delivered')
select * from Users
select *from Restaurants
select * from Items
select * from DeliveryAgents
select * from Orders
select * from OrderDetails
insert into Orders values(2,1,2,'NetBanking',40.00,'On the way')

/*Please run below command, no need to drop table*/
ALTER TABLE Users
ALTER COLUMN UserRole varchar(10)

UPDATE Users
SET UserRole = 'Owner'
WHERE UserId=1;

UPDATE Users
SET UserRole = 'Customer'
WHERE UserId=2;
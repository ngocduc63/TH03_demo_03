create database EShop
go
use EShop
go
create table Category(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name nvarchar(50),
	nameVN nvarchar(50)
)
go
create table Product(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name nvarchar(50),
	unitPrice float,
	image nvarchar(50),
	productDate date,
	available int,
	categoryId int,
	description nvarchar(50)
	
	foreign key (categoryId) references Category (id)
) 
go
create table Customer(
	id INT IDENTITY(1,1) PRIMARY KEY,
	password nvarchar(50),
	fullName nvarchar(50),
	email nvarchar(50),
	photo nvarchar(50),
	activated nvarchar(50)
)
go
create table [Order](
	id INT IDENTITY(1,1) PRIMARY KEY,
	customerId int,
	orderDate date,
	address nvarchar(50),
	amount nvarchar(50),
	description nvarchar(50),

	foreign key (customerId) references customer (id)
)
go
create table OrderDetail(
	id INT IDENTITY(1,1) PRIMARY KEY,
	orderId int,
	productId int,
	unitPrice float,
	quantity int,

	foreign key (orderId) references [order] (id),
	foreign key (productId) references product (id)
)
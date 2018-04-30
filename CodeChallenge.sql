use CodeChallenge;

create table Products
(
	Id int primary key,
	Name nvarchar(200),
	Price int
);

create table Customers
(
	Id int primary key,
	Firstname nvarchar(200),
	Lastname nvarchar(200),
	CardNumber nvarchar(100)
);

create table Orders
(
	Id int primary key,
	ProductId int foreign key references Products(Id),
	CustomerId int foreign key references Customers(Id)
);

insert into Products (Id, Name, Price) values (1, 'Something', 10);
insert into Products (Id, Name, Price) values (2, 'Another', 5);
insert into Products (Id, Name, Price) values (3, 'Other', 8);
insert into Products (Id, Name, Price) values (4, 'IPhone', 200);

insert into Customers (Id, FirstName, Lastname, CardNumber) values (1, 'John', 'Johnson', 147290);
insert into Customers (Id, FirstName, Lastname, CardNumber) values (2, 'Jack', 'Anderson', 930295);
insert into Customers (Id, FirstName, Lastname, CardNumber) values (3, 'Jane', 'Jackson', 440368);
insert into Customers (Id, FirstName, Lastname, CardNumber) values (4, 'Tina', 'Smith', 123456);

insert into Orders (Id, ProductId, CustomerId) values (1, 1, 1);
insert into Orders (Id, ProductId, CustomerId) values (2, 3, 1);
insert into Orders (Id, ProductId, CustomerId) values (3, 1, 2);
insert into Orders (Id, ProductId, CustomerId) values (4, 4, 4);

select Orders.Id, Orders.ProductId, Orders.CustomerId
from Customers
join Orders on Customers.Id = Orders.CustomerId
where Customers.Firstname = 'Tina' and Customers.Lastname = 'Smith';

select sum(Products.Price)
from Products
join Orders on Products.Id = Orders.ProductId
where Products.Name = 'IPhone'
group by Orders.ProductId;

update Products
set Price = 250
where Name = 'IPhone';
(1) Create Table Role
(
	RoleId int primary key identity,
	RoleName varchar(20) not null
);
(2)create table Login
(
	UserId int primary key identity,
	UserEmail varcahr (100) not null,
	UserPass varchar(max) not null,
	DateCrated dateTime not null,
	isDeleted bit default (0) Null,
	isActive bit default (0) null,
	unique email,
	RoleId int not null,
	foreign key (RoleId) references Role(RoleId)
);
(3)create table UserDetails(
	UserDetailId int primary key identity,
	UserId int not null,
	UserFirstName varchar(50) null,
	UserMiddleame varchar(50) null,
	UserLastName varcahr(50) null,
	UserMobile varcahr(20) null,
        UserAddress varcahr(max) null,
	UserGender varchar(6) null,
	UserAlternateEmail varcahr(50) null,
	foreign key (UerId) references Login(UserId)
);
(4)create table Unit
(
	UnitId int primary key identity,
	UnitANme varcahr(50) not null,
	IsDeleted bit not null
);
(5)create table Category(
	CategoryId int primary key identity,
	CategoryName varchar(100) not null,
	IdDeleted bit not null,
);
(6)create table Product
(
	ProductId int primary key identity,
	ProductName varchar (100) not null,
	CategoryId int not null,
	UnitId int not null,
	ProductDesc varchar(max) not null,
	IsAvail bit not null,
	IsDeleted bit not null,
	ProductPriceIn Decimal(18,6) not null,
	ProductPriceOut Decimal(18,6) not null,
	foreign key (CategoryId) references Category(CategoryId),
	foreign key (UnitId) references Unit(UnitId)
);
(7)CREATE TABLE CustomerOrder (
    OrderId INT      IDENTITY (1, 1) NOT NULL,
    UserId    INT      NULL,
    OrderDateDATETIME NOT NULL,
    IsDeleted BIT      NOT NULL,
    OrderStatus INT      NOT NULL,
    DispachDate DATETIME NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC),
    FOREIGN KEY (UserId) REFERENCES Login(UserId)
);
(8)CREATE TABLE CustomerOrderDetail(
    DetailId INT  IDENTITY (1, 1) NOT NULL,
    OrderId INT             NULL,
    ProductId INT             NULL,
    OrderQuantity DECIMAL (18, 3) NOT NULL,
    PRIMARY KEY CLUSTERED ([DetailId] ASC),
    FOREIGN KEY ([OrderId]) REFERENCES CustomerOrder([OrderId]),
    FOREIGN KEY ([ProductId]) REFERENCES [Product] ([ProductId])
);


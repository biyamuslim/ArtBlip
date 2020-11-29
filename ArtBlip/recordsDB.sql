drop table if exists Admins;
drop table if exists  Artist;
drop table if exists Artwork;
drop table if exists  Customer;
drop table if exists Employees;


CREATE TABLE Admins(
UserName varchar(30) primary key,
email varchar (30),
pass varchar(40),
);


CREATE TABLE Artist(
ArtistName varchar(30),
ArtistID varchar(30)  primary key,
DOB date,
TypeOfArt varchar(40),
);
 
 CREATE TABLE Artwork(
 artworkTitle varchar(30),
 artworkID varchar(30) primary key,
 ArtistID varchar(30) foreign key references Artist(ArtistID),
 artworkDate date,
 artworkPrice int,
 );

 CREATE TABLE Customer(
 customerName varchar(30),
 customerID varchar(30) primary key,
 artworkID varchar(30) foreign key references Artwork(artworkID),
 phoneNumber varchar(30),
 cardNo  varchar(30),
 bill int,
 );

 CREATE TABLE Employees(
empID int primary Key,
firstName varchar(30),
lastName varchar(30),
empAddress varchar(100),
CNIC  varchar(13),
email varchar(30),
phoneNumber varchar(30) ,
salary int,
joinDate date,
endDate date,
);

select * from Admins;
select * from Artist;
select * from Artwork;
select * from Customer;
select * from Employees;



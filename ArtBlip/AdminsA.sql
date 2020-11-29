
drop table if exists Admins;
drop table if exists  Artist;

CREATE TABLE Admins(
UserName varchar(30),
email varchar (30),
pass varchar(40),
confirmPass varchar(40)
);


CREATE TABLE Artist(
ArtistName varchar(30),
ArtistID varchar (30),
DOB date,
TypeOfArt varchar(40)
);
 


select * from Admins;

select * from Artist;

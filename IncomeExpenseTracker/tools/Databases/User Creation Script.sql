create table users(
	id int primary key identity(1,1),
	username varchar(MAX) null,
	password varchar(MAX) null,
	date_created date null
);
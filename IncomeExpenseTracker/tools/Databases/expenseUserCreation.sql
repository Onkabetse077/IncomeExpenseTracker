﻿CREATE TABLE users(
id INT PRIMARY KEY IDENTITY(1,1),
username VARCHAR(MAX) NULL,
password VARCHAR(MAX) NULL,
date_created DATE NULL
);

SELECT * FROM users;

CREATE TABLE categories
(
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	type VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_inserted DATE NULL
);

SELECT * FROM categories;

DELETE FROM categories WHERE id = 2;

DELETE FROM categories WHERE id = 3;

SELECT * FROM categories;

CREATE TABLE income(
id INT PRIMARY KEY IDENTITY(1,1),
category VARCHAR(MAX) NULL,
item VARCHAR(MAX) NULL,
income FLOAT NULL,
description TEXT NULL,
date_income DATE NULL,
date_inserted DATe NULL
);

SELECT * FROM income;
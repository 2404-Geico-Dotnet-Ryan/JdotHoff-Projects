--comments in SQL
--CREATE - DDL command
CREATE	TABLE movies (
	Id int, 
	Title varchar(50), 
	Price numeric(12,2),
	Available bit, 
	ReturnDate bigint
	);

	--Add in some new Data
	--Insert command- DML statement
Insert INTO movie VALUES (1, 'IRON Man', 5,1,0);

--SELECT -DQL
SELECT * FROM Movie; 

--comments in SQL
--CREATE - DDL command
CREATE	TABLE movie (
	Id int, 
	Title varchar(50), 
	Price numeric(12,2),
	Available bit, 
	ReturnDate bigint
	);

	--drop table movie

	--Add in some new Data
	--Insert command- DML statement
Insert INTO movie VALUES (1, 'Iron Man', 5,1,0);
Insert INTO Movie Values (2, 'The Avengers', 6.5,1,0);
Insert INTO movie VALUES (3,'Ant-Man', 4.5,1,0);
Insert INTO movie VALUES (4, 'Black Widow', 7, 1, 0), ( 5, 'Black Panther', 7, 1, 0), 
(6, 'Thor', 4, 1, 0), (7, 'Iron Man 2', 4, 1, 0); 

--SELECT -DQL
SELECT * FROM Movie; 
select Title from movie; 


--Update - dml
update movie set available=1;

--Where Clause -> allows us to pick and choose which
--records we weant to apply the statement to.
--uses a Predicate: Field =value

--SELECT
Select * From Movie Where Price =5; 
SELECT * From movie Where Price >=5;
SELECT * From Movie Where Available = 0;  
--since no booleans in T-SQL 
---> must test BIT against the value 0 or 1.

--UPDATE
UPDATE Movie SET Price = 6 WHERE Id = 2; 
UPDATE Movie SET Price = 7 WHERE Title = 'The Avengers'; 

--DELETE
DELETE FROM Movie WHERE Title = 'Iron Man'; 


--Other Predicates for our Where Clause
SELECT * FROM Movie;
SELECT * FROM movie WHERE Title = 'Iron Man';
SELECT * FROM Movie Where Title LIKE 'Iron Man%';
SELECT * FROM MOvie Where Title LIKE 'Black%'; 
SELECT * FROM Movie Where Title Like '%r';
SELECT * FROM Movie WHERE Title LIKE '%a%';

SELECT LOWER (Title) FROM Movie WHERE Title LIke '%a%';
SELECT UPPER (Title) FROM Movie WHERE Title LIke '%a%';
--LOWER() and UPPER()
--These are SCALAR Functions
--Function that accepts 1 input (record ) and produces 1 output 
--lower, upper, round, mod, etc...

SELECT ROUND (Price, 0) FROM Movie; 

--Aggregate Functions
--Caculate some value (1 output) using multiple 
--records (many inputs)
--AVG, MAX, MIN, SUM, COUNT
SELECT MAX (Price) FROM Movie; 
SELECT MIN (Price) FROM Movie; 
SELECT AVG (Price) FROM Movie; 
SELECT ROUND (AVG(Price),2) FROM Movie;
SELECT SUM (Price) FROM Movie WHERE Available = 0; 

UPDATE Movie SET Available = 0 WHERE Title = 'Ant-Man'; 

UPDATE Movie SET Title = NULL WHERE Title = 'Thor'; 
SELECT Count (Title) FROM Movie;
SELECT Count (Id) FROM Movie; 
SELECT COUNT(*) FROM Movie;

--GROUP BY - is used with Aggregate Functions to Break
--records into values of that category - groups/buckets
SELECT SUM(Price) FROM  Movie Group By Available;
SELECT Available, SUM(Price) AS Total FROM  Movie Group By Available;
SELECT Available, COUNT(*) AS COUNT,SUM(Price) AS Total FROM  Movie Group By Available;

SELECT COUNT (*), Price FROM Movie GROUP By Price; 
SELECT COUNT (*), Price FROM Movie WHERE Price >= 5 GROUP By Price; 
SELECT SUM(Price) FROM Movie GROUP BY Available HAVING Available =1; 
SELECT COUNT (*), Price FROM Movie GROUP BY Price HAVING COUNT (*) >=2;


--ORDER BY-Changes the way in which the View/Cursor is 
--displayed/returned. It does not filter records, just 
--organizes them. Does not affect their order as stored in the 
--Database. 
SELECT * FROM Movie ORDER BY Price; 
--It is in Ascending order by default
SELECT * FROM Movie ORDER BY Price DESC; --Descending

SELECT * FROM Movie ORDER BY Available,Price; 

--OF Availabe Movies, get me the top 2 cheapest rentals.

SELECT TOP 2 * FROM Movie Where Available =1 ORDER BY Price;


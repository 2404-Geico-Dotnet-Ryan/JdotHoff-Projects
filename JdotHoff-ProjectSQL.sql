-- CREATE - DDL
CREATE TABLE LabSystem (
	Id int,
	ItemName varchar(50),
	CurrentBloodCount numeric,
	CurrentLabKitCount numeric,
	);

	--DROP -DDL
	--DROP TABLE LabSystem

	--Add in new Data
	INSERT INTO LabSystem VALUES
	(1, 'Blood', 50, 0),
	(2, 'LabKit', 0, 50);

	select * From LabSystem

	--DROP TABLE [User];

	CREATE TABLE [User](
	Id INT,
	UserType int,
	UserLogin int,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	Title VARCHAR(50) NOT NULL,
);

INSERT INTO [User] VALUES
(1,1, 123, 'John', 'Jones', 'Scientist'),
(2,1, 123, 'Jackie', 'Smith', 'Scientist'),
(3, 2, 456, 'Jimmy', 'Butler', 'Lab Assitant'),
(4, 2, 456, 'Natalie', 'Curry', 'Lab Assitant');

select * from [User]


USE master
GO

-- 01. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), 
--PersonId(FK), Balance).
--Insert few records for testing.
--Write a stored procedure that selects the full names of all persons.

CREATE Database BankSystem
GO

USE BankSystem
GO

CREATE TABLE Persons (
	Id int IDENTITY NOT NULL PRIMARY KEY,
	FirstName nvarchar(50) NOT NULL UNIQUE,
	LastName nvarchar(50) NULL,
	SSN nvarchar(50) NOT NULL,
	)
GO

CREATE TABLE Accounts (
	Id int IDENTITY NOT NULL PRIMARY KEY,
	PersonID int NOT NULL FOREIGN KEY REFERENCES Persons(Id),
	Balance money NOT NULL
	)
GO

DECLARE @counter tinyint
SET @counter = 20
WHILE @counter > 0
	BEGIN
		INSERT INTO Persons(FirstName, LastName, SSN)
		VALUES ('Pesho ' + CAST(@counter AS varchar(10)),
				'Peshov ' + CAST(@counter AS varchar(10)),
				@counter + 1000000)
		SET @counter = @counter - 1
	END
GO

DECLARE @counter tinyint
SET @counter = 20
WHILE @counter > 0
	BEGIN
		DECLARE @randomNumber int
		SELECT @randomNumber = ABS(CAST(NEWID() AS binary(6)) % 10000) + 1
		INSERT INTO Accounts(PersonID, Balance)
		VALUES (@counter, @randomNumber)
		SET @counter = @counter - 1
	END
GO

CREATE PROC dbo.usp_SelectFullNamesPersons
AS
  SELECT CONCAT(FirstName,' ', LastName) AS [Full Name]
  FROM Persons
GO

EXEC dbo.usp_SelectFullNamesPersons
GO

-- 02. Create a stored procedure that accepts a number as a parameter and returns all persons who have more 
-- money in their accounts than the supplied number.

CREATE PROC dbo.usp_MoreMoneyThenGivenInput(
	@parameter int)
AS
  SELECT CONCAT(p.FirstName,' ', p.LastName) AS [Full Name], a.Balance
  FROM Persons p
  Join Accounts a
  ON a.PersonID = p.Id
  WHERE a.Balance > @parameter
GO

EXEC dbo.usp_MoreMoneyThenGivenInput 5000
GO
-- 03. Create a function that accepts as parameters � sum, yearly interest rate and number of months.
-- It should calculate and return the new sum.
-- Write a SELECT to test whether the function works as expected.

CREATE FUNCTION dbo.ufn_CalcBonus(@sum money, @interestRate float, @months tinyint)
  RETURNS money
AS
BEGIN
DECLARE @newSum money = @sum * (1 + @interestRate / 12) * @months
  RETURN @newSum
END

GO

SELECT Balance, dbo.ufn_CalcBonus(Balance, 3.5, 5) AS Bonus
FROM Accounts
GO
-- 04. Create a stored procedure that uses the function from the previous example to give an interest to a 
-- person's account for one month.
-- It should take the AccountId and the interest rate as parameters.

CREATE PROC dbo.usp_InterestForAMonth(@accountId int, @interest money)
AS
  SELECT CONCAT(p.FirstName,' ', p.LastName) AS [Full Name], a.Id, dbo.ufn_CalcBonus(a.Balance, @interest, 1) as Interest
  FROM Persons p
  Join Accounts a
  ON a.PersonID = p.Id
  WHERE a.Id = @accountId
GO

EXEC dbo.usp_InterestForAMonth 1, 2.5
GO

-- 05. Add two more stored procedures WithdrawMoney(AccountId, money) and DepositMoney(AccountId, money) that 
-- operate in transactions.

CREATE PROC dbo.usp_WithdrawMoney(@accountId int, @money money)
AS
	BEGIN TRAN
		UPDATE Accounts
		SET Balance -= @money
		WHERE Accounts.Id = @accountId
	COMMIT TRAN
		 
GO

CREATE PROC dbo.usp_DepositMoney(@accountId int, @money money)
AS
	BEGIN TRAN
		UPDATE Accounts
		SET Balance += @money
		WHERE Accounts.Id = @accountId
	COMMIT TRAN
		 
GO

-- 06. Create another table � Logs(LogID, AccountID, OldSum, NewSum).
-- Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an 
-- account changes.

CREATE TABLE Logs (
	LogID int IDENTITY NOT NULL PRIMARY KEY,
	AccountID int NOT NULL FOREIGN KEY REFERENCES Accounts(Id),
	OldSum money NOT NULL,
	NewSum money NOT NULL,
	)
GO

CREATE TRIGGER tr_LogTrans ON Accounts FOR UPDATE
AS
  DECLARE @oldSum money;
  SELECT @oldSum = Balance FROM deleted;

  INSERT INTO Logs(AccountId, OldSum, NewSum)
      SELECT Accounts.Id, @oldSum, Balance
        FROM inserted
GO

EXEC usp_WithdrawMoney 1, 1000

EXEC usp_DepositMoney 2, 2000

-- 07. Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or 
-- last name) and all town's names that are comprised of given set of letters.
-- Example: 'oistmiahf' will return 'Sofia', 'Smith', � but not 'Rob' and 'Guy'.

USE TelerikAcademy
GO

CREATE FUNCTION ufn_SearchForWordsInGivenPattern(@pattern nvarchar(255))
	RETURNS @MatchedNames TABLE (Name varchar(50))
AS
BEGIN
	INSERT @MatchedNames
	SELECT * 
	FROM
		(SELECT e.FirstName FROM Employees e
        UNION
        SELECT e.LastName FROM Employees e
        UNION 
        SELECT t.Name FROM Towns t) as temp(name)
    WHERE PATINDEX('%[' + @pattern + ']', Name) > 0
	RETURN
END
GO

SELECT * FROM dbo.ufn_SearchForWordsInGivenPattern('oistmiahf')
GO

-- 08. Using database cursor write a T-SQL script that scans all employees and their addresses and prints all 
-- pairs of employees that live in the same town.

DECLARE empCursor CURSOR READ_ONLY FOR
    SELECT emp1.FirstName, emp1.LastName, t1.Name, emp2.FirstName, emp2.LastName
    FROM Employees emp1
    JOIN Addresses a1
        ON emp1.AddressID = a1.AddressID
    JOIN Towns t1
        ON a1.TownID = t1.TownID,
        Employees emp2
    JOIN Addresses a2
        ON emp2.AddressID = a2.AddressID
    JOIN Towns t2
        ON a2.TownID = t2.TownID
    WHERE t1.TownID = t2.TownID AND emp1.EmployeeID != emp2.EmployeeID
    ORDER BY emp1.FirstName, emp2.FirstName

OPEN empCursor

DECLARE @firstName1 nvarchar(50), 
        @lastName1 nvarchar(50),
        @townName nvarchar(50),
        @firstName2 nvarchar(50),
        @lastName2 nvarchar(50)
FETCH NEXT FROM empCursor INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2

DECLARE @counter int;
SET @counter = 0;

WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @counter = @counter + 1;

		PRINT @firstName1 + ' ' + @lastName1 + 
			  '     ' + @townName + '       ' +
			  @firstName2 + ' ' + @lastName2;

		FETCH NEXT FROM empCursor 
		INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2
	END

print 'Total records: ' + CAST(@counter AS nvarchar(10));

CLOSE empCursor
DEALLOCATE empCurso

-- 09. *Write a T-SQL script that shows for each town a list of all employees that live in it.
-- Sample output:
-- Sofia -> Martin Kulov, George Denchev
-- Ottawa -> Jose Saraiva

-- TODO:

-- 10. Define a .NET aggregate function StrConcat that takes as input a sequence of strings and return a single string that consists of the input strings separated by ','.
-- For example the following SQL statement should return a single string:
-- SELECT StrConcat(FirstName + ' ' + LastName)
-- FROM Employees

IF NOT EXISTS (
    SELECT value
    FROM sys.configurations
    WHERE name = 'clr enabled' AND value = 1
)
BEGIN
    EXEC sp_configure @configname = clr_enabled, @configvalue = 1
    RECONFIGURE
END
GO

-- Remove the aggregate and assembly if they're there
IF (OBJECT_ID('dbo.concat') IS NOT NULL) 
    DROP Aggregate concat; 
GO 

IF EXISTS (SELECT * FROM sys.assemblies WHERE name = 'concat_assembly') 
    DROP assembly concat_assembly; 
GO      

CREATE Assembly concat_assembly 
   AUTHORIZATION dbo 
   FROM 'C:\SqlStringConcatenation.dll' --- CHANGE THE LOCATION
   WITH PERMISSION_SET = SAFE; 
GO 

CREATE AGGREGATE dbo.concat ( 
    @Value NVARCHAR(MAX),
    @Delimiter NVARCHAR(4000) 
) 
    RETURNS NVARCHAR(MAX) 
    EXTERNAL Name concat_assembly.concat; 
GO 

SELECT dbo.concat(FirstName + ' ' + LastName, ', ')
FROM Employees
GO

DROP Aggregate concat; 
DROP assembly concat_assembly; 
GO
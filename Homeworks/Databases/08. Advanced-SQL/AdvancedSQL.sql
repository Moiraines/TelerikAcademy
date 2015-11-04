USE TelerikAcademy
--01. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the 
--company. Use a nested SELECT statement.
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary = 
  (SELECT MIN(Salary) FROM Employees)

--02. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% 
--higher than the minimal salary for the company.
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary <= 
  1.1 * (SELECT MIN(Salary) FROM Employees)

--03. Write a SQL query to find the full name, salary and department of the employees that take the minimal 
--salary in their department. 
--Use a nested SELECT statement.
SELECT e.FirstName + ' ' + e.LastName AS [Full Name], d.Name AS Department, e.Salary
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees 
		WHERE DepartmentID = e.DepartmentID)
	ORDER BY Department
	
--04. Write a SQL query to find the average salary in the department #1.
SELECT AVG(Salary) Average
FROM Employees
WHERE DepartmentID = 1 

--05. Write a SQL query to find the average salary in the "Sales" department.
SELECT AVG(Salary) Average
FROM Employees e
	JOIN Departments d
ON e.DepartmentID = d.DepartmentID AND d.Name = 'Sales' 

--06. Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(*) Cnt
FROM Employees e
	JOIN Departments d
ON e.DepartmentID = d.DepartmentID AND d.Name = 'Sales'

--07. Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(*) Cnt
FROM Employees e
WHERE e.ManagerID IS NOT NULL

--08. Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(*) Cnt
FROM Employees e
WHERE e.ManagerID IS NULL

--09. Write a SQL query to find all departments and the average salary for each of them.
SELECT AVG(Salary) AS [Average Salary], d.Name AS Department
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	GROUP BY d.Name

--10. Write a SQL query to find the count of all employees in each department and for each town.
SELECT COUNT(e.EmployeeID) AS [Employees Count], d.Name AS [Department], t.Name AS [Town]
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	JOIN Addresses a
	ON a.AddressID = e.AddressID
	JOIN Towns t
	ON t.TownID = a.TownID
	GROUP BY d.Name, t.Name
	ORDER BY d.Name

--11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and 
--last name.
SELECT e.EmployeeID AS [Manager ID],
	   CONCAT(e.FirstName, ' ', e.LastName) AS [Manager Name],
	   COUNT(e.EmployeeID) AS [Employees Count]
	FROM Employees e
	JOIN Employees emp
		ON emp.ManagerID = e.EmployeeID
	GROUP BY e.EmployeeID, e.FirstName, e.LastName
	HAVING COUNT(e.EmployeeID) = 5

--12. Write a SQL query to find all employees along with their managers. For employees that do not have 
--manager display the value "(no manager)".
SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], ISNULL(m.FirstName + ' ' + m.LastName, 'no manager') AS [Manager Name]
FROM Employees e
	LEFT JOIN Employees m
	ON m.EmployeeID = e.ManagerID

--13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. 
--Use the built-in LEN(str) function.
SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], LEN(e.LastName) AS [Letters Count]
FROM Employees e
WHERE LEN(e.LastName) = 5

--14. Write a SQL query to display the current date and time in the following format 
--"day.month.year hour:minutes:seconds:milliseconds".
--Search in Google to find how to format dates in SQL Server.
SELECT CONVERT(VARCHAR(24),GETDATE(),113)
--or
SELECT FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:ss:fff')

--15. Write a SQL statement to create a table Users. Users should have username, password, full name and last 
--login time.
--Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
--Define the primary key column as identity to facilitate inserting records.
--Define unique constraint to avoid repeating usernames.
--Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE Users (
	UserID int IDENTITY,
	Username nvarchar(30) NOT NULL UNIQUE,
	Pass nvarchar(100) NULL CHECK (LEN(Pass) > 5),
	[Full Name] nvarchar(100) NOT NULL,
	[Login Time] date,
	CONSTRAINT PK_Users PRIMARY KEY(UserID)
	)
GO

--16. Write a SQL statement to create a view that displays the users from the Users table that have been in 
--the system today.
--Test if the view works correctly.
CREATE VIEW [Logged Users Today] AS
	SELECT Username
	FROM Users
	WHERE DATEDIFF(DAY, [Login time], GETDATE()) = 0
GO

--17. Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
--Define primary key and identity column.
CREATE TABLE Groups(
	GroupID int IDENTITY,
	Name nvarchar(30) NOT NULL UNIQUE,
	CONSTRAINT PK_Groups PRIMARY KEY(GroupID)
)
GO

--18. Write a SQL statement to add a column GroupID to the table Users.
--Fill some data in this new column and as well in the `Groups table.
--Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.
ALTER TABLE Users
	ADD GroupID int
GO

ALTER TABLE Users
	ADD CONSTRAINT FK_Users_Groups
	FOREIGN KEY (GroupID)
	REFERENCES Groups(GroupID)
GO

--19. Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Groups VALUES
    ('Facebook'),
    ('Twitter'),
    ('LinkedIn'),
    ('Gmail'),
    ('Telerik Academy'),
    ('SoftUni')

INSERT INTO Users VALUES
	('username1', 'qwerty1', 'Unnamed1', '2010-3-06 00:00:00', 1),
    ('username2', 'qwerty2', 'Unnamed2', '2010-3-07 00:00:00', 2),
    ('username3', 'qwerty3', 'Unnamed3', '2010-3-08 00:00:00', 3),
    ('username4', 'qwerty4', 'Unnamed4', '2010-3-09 00:00:00', 4),
    ('username5', 'qwerty5', 'Unnamed5', '2010-3-10 00:00:00', 5),
    ('username6', 'qwerty6', 'Unnamed6', '2010-3-11 00:00:00', 6),
    ('username7', 'qwerty7', 'Unnamed7', '2010-3-12 00:00:00', 3),
    ('username8', 'qwerty8', 'Unnamed8', '2010-3-13 00:00:00', 2),
    ('username9', 'qwerty9', 'Unnamed9', '2010-3-14 00:00:00', 1)

--20. Write SQL statements to update some of the records in the Users and Groups tables.
UPDATE Users
	SET Username = 'Jon Snow'
	WHERE UserID = 2 

--21. Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE
FROM Users
Where Username = 'username9'

--22. Write SQL statements to insert in the Users table the names of all employees from the Employees table.
--Combine the first and last names as a full name.
--For username use the first letter of the first name + the last name (in lowercase).
--Use the same for the password, and NULL for last login time.
INSERT INTO Users (Username, Pass, [Full Name])
	SELECT  CONCAT(LEFT(FirstName, 1), LOWER(LastName)), CONCAT(LEFT(FirstName, 1), LOWER(LastName)), (Firstname + ' ' + LastName)
	FROM Employees
GO

--23. Write a SQL statement that changes the password to NULL for all users that have not been in the system 
--since 10.03.2010.
UPDATE Users
	SET Pass = NULL
	WHERE DATEDIFF(DAY, [Login time], '2010-3-10 00:00:00') > 0
GO

--24. Write a SQL statement that deletes all users without passwords (NULL password).
DELETE 
FROM Users
WHERE Pass IS NULL
GO

SELECT *
FROM Users

--25. Write a SQL query to display the average employee salary by department and job title.
SELECT AVG(Salary) AS [Average Salary], d.Name AS Department, e.JobTitle
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	GROUP BY d.Name, e.JobTitle
	ORDER BY d.Name

--26. Write a SQL query to display the minimal employee salary by department and job title along with the name 
--of some of the employees that take it.
SELECT MIN(Salary) AS [Minimal Salary], MIN(CONCAT(e.FirstName, ' ', e.LastName)) AS [Employee], d.Name AS Department, e.JobTitle
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	GROUP BY d.Name, e.JobTitle
	ORDER BY d.Name

--27. Write a SQL query to display the town where maximal number of employees work.
SELECT TOP 1 t.Name, COUNT(e.EmployeeID) AS [Number of Employees]
	FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
		JOIN Towns t
		ON a.TownID = t.TownID
		GROUP BY t.Name
		ORDER BY [Number of Employees] DESC


--28. Write a SQL query to display the number of managers from each town.
SELECT t.Name, COUNT(DISTINCT e.ManagerID) AS [Number of Managers]
	FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
		JOIN Towns t
		ON a.TownID = t.TownID
		GROUP BY t.Name
		ORDER BY [Number of Managers] DESC

--29. Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, 
--hours, comments).
--Don't forget to define identity, primary key and appropriate foreign key.
--Issue few SQL statements to insert, update and delete of some data in the table.
--Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
--For each change keep the old record data, the new record data and the command (insert / update / delete).
CREATE TABLE WorkHours (
	WorkHoursID int IDENTITY,
	EmployeeID int NOT NULL,
	[Date] date,
	Task nvarchar(100),
	HoursOfWork int,
	Comments nvarchar,
	CONSTRAINT PK_WorkHours PRIMARY KEY(WorkHoursID),
	CONSTRAINT FK_WorkHours_Employees FOREIGN KEY (EmployeeID)
	REFERENCES Employees(EmployeeID)
	)
GO

DECLARE @counter int;
SET @counter = 20;
WHILE @counter > 0
BEGIN
    INSERT INTO WorkHours(EmployeeId, [Date], Task, HoursOfWork)
    VALUES (@counter, GETDATE(), 'TASK: ' + CONVERT(varchar(10), @counter), @counter)
    SET @counter = @counter - 1
END

UPDATE WorkHours
    SET Comments = 'Work hard or go home!'
    WHERE HoursOfWork > 10

DELETE
    FROM WorkHours
    WHERE EmployeeID IN (1, 3, 5, 7, 13)

CREATE TABLE WorkHoursLogs (
    WorkLogID int,
    EmployeeID Int NOT NULL,
    [Date] DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    HoursOfWork Int NOT NULL,
    Comments nvarchar(256),
    [Action] nvarchar(50) NOT NULL,
    CONSTRAINT FK_Employees_WorkHoursLogs
        FOREIGN KEY (EmployeeID)
        REFERENCES Employees(EmployeeID),
    CONSTRAINT [CC_WorkReportsLogs] CHECK ([Action] IN ('Insert', 'Delete', 'DeleteUpdate', 'InsertUpdate'))
) 
GO

--Triggers

CREATE TRIGGER tr_InsertWorkReports ON WorkHours FOR INSERT
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeID, [Date], Task, HoursOfWork, Comments, [Action])
    SELECT WorkHoursID, EmployeeID, [Date], Task, HoursOfWork, Comments, 'Insert'
    FROM inserted
GO

CREATE TRIGGER tr_DeleteWorkReports ON WorkHours FOR DELETE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeID, [Date], Task, HoursOfWork, Comments, [Action])
    SELECT WorkHoursID, EmployeeID, [Date], Task, HoursOfWork, Comments, 'Delete'
    FROM deleted
GO

CREATE TRIGGER tr_UpdateWorkReports ON WorkHours FOR UPDATE
AS
INSERT INTO WorkHoursLogs(WorkLogID, EmployeeID, [Date], Task, HoursOfWork, Comments, [Action])
    SELECT WorkHoursID, EmployeeID, [Date], Task, HoursOfWork, Comments, 'InsertUpdate'
    FROM inserted

INSERT INTO WorkHoursLogs(WorkLogId, EmployeeID, [Date], Task, HoursOfWork, Comments, [Action])
    SELECT WorkHoursID, EmployeeID, [Date], Task, HoursOfWork, Comments, 'DeleteUpdate'
    FROM deleted
GO

DELETE 
    FROM WorkHoursLogs

INSERT INTO WorkHours(EmployeeId, [Date], Task, HoursOfWork)
    VALUES (25, GETDATE(), 'TASK: 25', 25)

DELETE 
    FROM WorkHours
    WHERE EmployeeId = 25

UPDATE WorkHours
    SET Comments = 'Updated'
    WHERE EmployeeId = 2

--30. Start a database transaction, delete all employees from the 'Sales' department along with all dependent 
--records from the pother tables.
--At the end rollback the transaction.
BEGIN TRAN
ALTER TABLE Departments
DROP CONSTRAINT FK_Departments_Employees
ALTER TABLE EmployeesProjects
DROP CONSTRAINT FK_EmployeesProjects_Employees
DELETE FROM Employees
		SELECT d.Name
		FROM Employees e
        JOIN Departments d
            ON e.DepartmentID = d.DepartmentID
        WHERE d.Name = 'Sales'
ROLLBACK TRAN

--31. Start a database transaction and drop the table EmployeesProjects.
--Now how you could restore back the lost table data?
BEGIN TRAN
ALTER TABLE EmployeesProjects
DROP CONSTRAINT FK_EmployeesProjects_Employees
DROP TABLE EmployeesProjects
ROLLBACK TRAN

--32. Find how to use temporary tables in SQL Server.
--Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and 
--re-creating the table.

BEGIN TRAN

SELECT *  INTO  #Temp_EmployeesProjects
FROM EmployeesProjects

DROP TABLE EmployeesProjects

SELECT * INTO EmployeesPRojects
FROM #Temp_EmployeesProjects

ROLLBACK TRAN
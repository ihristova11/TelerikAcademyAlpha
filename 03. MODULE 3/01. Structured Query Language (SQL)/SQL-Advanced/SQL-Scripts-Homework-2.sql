--01. Write a SQL query to find the names and salaries 
--of the employees that take the minimal salary in the company.
--Use a nested SELECT statement.
SELECT e.FirstName, e.LastName, e.Salary
FROM Employees e
WHERE e.Salary = (SELECT MIN(Salary) FROM Employees)

--02. Write a SQL query to find the names and salaries of the employees 
--that have a salary that is up to 10% higher than the minimal salary for the company.
SELECT e.FirstName, e.LastName, e.Salary
FROM Employees e
WHERE e.Salary < (SELECT MIN(Salary) FROM Employees) * 1.1

--03. Write a SQL query to find the full name, 
--salary and department of the employees that take the minimal salary in their department.
--Use a nested SELECT statement.
SELECT e.FirstName, e.LastName, e.Salary, d.Name
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE e.Salary = 
	(SELECT MIN(Salary) FROM Employees
	WHERE DepartmentID = e.DepartmentID)
ORDER BY d.DepartmentID

--04. Write a SQL query to find the average salary in the department #1.
SELECT AVG(e.Salary) AS [Average Salary]
FROM Employees e
WHERE e.DepartmentId = 1

--05. Write a SQL query to find the average salary in the "Sales" department.
SELECT AVG(e.Salary) AS [Average Salary in Sales]
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--06. Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(e.EmployeeID) AS [Number of employees from Sales department]
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales' 

--07. Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(e.EmployeeID) AS [Employees with manager]
FROM Employees e
WHERE e.ManagerID IS NOT NULL 

--08. Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(e.EmployeeID) AS [Employees without manager]
FROM Employees e
WHERE e.ManagerID IS NULL

--09. Write a SQL query to find all departments and the average salary for each of them.
SELECT AVG(e.Salary) AS [Average salary], d.Name AS Department
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

--10. Write a SQL query to find the count of all employees in each department and for each town.
SELECT d.Name AS Department, t.Name AS Town, COUNT(*) AS Employees
FROM Employees e
JOIN Departments d 
	ON e.DepartmentID = d.DepartmentID
JOIN Addresses a
	ON e.AddressID = a.AddressID
JOIN Towns t
	ON a.TownID = t.TownID
GROUP BY t.Name, d.Name

--11. Write a SQL query to find all managers that have exactly 5 employees. 
--Display their first name and last name.
SELECT m.FirstName, m.LastName
FROM Employees m
JOIN Employees e
	ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName, m.LastName
	HAVING (COUNT(e.ManagerID) = 5)

--12. Write a SQL query to find all employees along with their managers. 
--For employees that do not have manager display the value "(no manager)".
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS Employee,
		ISNULL(m.FirstName + ' '+  m.LastName, 'no manager') AS Manager
FROM Employees e
LEFT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID

--13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. 
--Use the built-in LEN(str) function.
SELECT e.FirstName, e.LastName
FROM Employees e
WHERE LEN(e.LastName) = 5

--14. Write a SQL query to display the current date and time 
--in the following format "day.month.year hour:minutes:seconds:milliseconds".
--Search in Google to find how to format dates in SQL Server.
SELECT FORMAT(GETDATE(), 'dd.MM.yy HH:mm:ss:mm') AS Date

--15. Write a SQL statement to create a table Users. 
--Users should have username, password, full name and last login time.
--Choose appropriate data types for the table fields. 
--Define a primary key column with a primary key constraint.
--Define the primary key column as identity to facilitate inserting records.
--Define unique constraint to avoid repeating usernames.
--Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE Users(
		Id int IDENTITY,
		Username nvarchar(20) UNIQUE NOT NULL, 
		UserPassword nvarchar(20), 
		FullName nvarchar(40) NOT NULL,
		LastLogin datetime,
		CONSTRAINT PK_Users PRIMARY KEY(Id), 
		CONSTRAINT PasswordMinLen Check ((DATALENGTH([UserPassword]) > 4))
		)
INSERT INTO Users(Username, UserPassword, FullName, LastLogin)
		VALUES('IRINA', 'mynewpass', 'irina irina', GETDATE()),
				('someone here', 'passhere', 'name name name', GETDATE() - 1)
GO

--16. Write a SQL statement to create a view that displays the users 
--from the Users table that have been in the system today.
--Test if the view works correctly.
CREATE VIEW [Last Been Here] AS	
SELECT *
FROM Users 
WHERE DATEPART(YEAR, LastLogin) <= DATEPART(YEAR, GETDATE())
GO

--17. Write a SQL statement to create a table Groups. 
--Groups should have unique name (use unique constraint).
--Define primary key and identity column.	
CREATE TABLE Groups(
			Id int IDENTITY,
			Name nvarchar(20) UNIQUE,
			CONSTRAINT PK_Groups PRIMARY KEY(Id)
			)
GO

--18. Write a SQL statement to add a column GroupID to the table Users.
--Fill some data in this new column and as well in the `Groups table.
--Write a SQL statement to add a foreign key constraint between 
--tables Users and Groups tables.
ALTER TABLE Users
	ADD GroupID int
ALTER TABLE Users
	ADD CONSTRAINT FK_Users_Groups FOREIGN KEY(GroupId)
		REFERENCES Groups(Id)

--19. Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Groups(Name)
VALUES ('somegroup'),
		('anothergroup')
INSERT INTO Users(Username, UserPassword, FullName, LastLogin)
		VALUES('newnewrecord', 'mynewpass', 'irina H', GETDATE())

--20. Write SQL statements to update some of the records in the Users and Groups tables.
UPDATE Users 
SET Username = 'set the user here'
WHERE Username = 'IRINA'

--21. Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE 
FROM Users
WHERE Username = 'set the user here'

--22. Write SQL statements to insert in the Users table the names of all employees 
--from the Employees table.
--Combine the first and last names as a full name.
--For username use the first letter of the first name + the last name (in lowercase).
--Use the same for the password, and NULL for last login time.
INSERT INTO Users(FullName, Username, UserPassword)
SELECT (e.FirstName + ' ' + e.LastName),
		(SUBSTRING(e.FirstName, 0, 4) + LOWER(e.LastName)),
		(SUBSTRING(e.FirstName, 0, 2) + LOWER(e.LastName))
FROM Employees e

--23. Write a SQL statement that changes the password to NULL 
--for all users that have not been in the system since 10.03.2010.
UPDATE Users
SET UserPassword = NULL
--WHERE DATEDIFF(DAY, LastLogin, CAST('2010-03-10' AS DATE)) > 0

--24. Write a SQL statement that deletes all users without passwords (NULL password).
DELETE FROM Users
WHERE UserPassword IS NULL

--25. Write a SQL query to display the average employee salary by department and job title.
SELECT AVG(e.Salary) AS [Average salary], d.Name AS Department, e.JobTitle
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle

--26. Write a SQL query to display the minimal employee salary by department and 
--job title along with the name of some of the employees that take it.
SELECT MIN(e.Salary) AS [Average salary], 
		d.Name AS [Department], 
		e.JobTitle, 
		e.FirstName, 
		e.LastName
FROM Employees e 
JOIN Departments d 
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle, e.FirstName, e.LastName

--27. Write a SQL query to display the town where maximal number of employees work.
SELECT TOP 1 t.Name, COUNT(t.Name) AS [Number of employees]
FROM Employees e
JOIN Addresses a
	ON a.AddressID = e.AddressID
JOIN Towns t
	ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY [Number of employees] DESC
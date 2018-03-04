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
--Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
--Define the primary key column as identity to facilitate inserting records.
--Define unique constraint to avoid repeating usernames.
--Define a check constraint to ensure the password is at least 5 characters long.

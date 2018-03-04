--01. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
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
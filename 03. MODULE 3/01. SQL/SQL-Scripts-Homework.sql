--02. Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
SELECT * 
FROM Departments

--03. Write a SQL query to find all department names.
SELECT Name 
FROM Departments

--04. Write a SQL query to find the salary of each employee.
SELECT CONCAT(FirstName, ' ', LastName, ' receives $', Salary)
FROM Employees

--05. Write a SQL to find the full name of each employee.
SELECT CONCAT(FirstName, ' ', LastName) AS FullName
FROM Employees

--06. Write a SQL query to find the email addresses of each employee (by his first and last name). 
--Consider that the mail domain is telerik.com. 
--Emails should look like “John.Doe@telerik.com". 
--The produced column should be named "Full Email Addresses".
SELECT CONCAT(FirstName, '.', LastName, '@telerik.com') AS FullEmailAddresses
FROM Employees

--07. Write a SQL query to find all different employee salaries.
SELECT DISTINCT Salary
FROM Employees

--08. Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
SELECT * 
FROM Employees
WHERE JobTitle = 'Sales Representative'

--09. Write a SQL query to find the names of all employees whose first name starts with "SA".
SELECT *
FROM Employees
WHERE FirstName LIKE 'SA%'

--10. Write a SQL query to find the names of all employees whose last name contains "ei".
SELECT *
FROM Employees
WHERE LastName LIKE '%ei%'

--11. Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
SELECT Salary
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000

--12. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
SELECT CONCAT(FirstName, ' ', LastName) AS Employee
FROM Employees
WHERE Salary = 25000 OR Salary = 14000 OR Salary= 12500 OR Salary = 23600

--13. Write a SQL query to find all employees that do not have manager.
SELECT *
FROM Employees
WHERE ManagerID IS NULL

--14. Write a SQL query to find all employees that have salary more than 50000. 
--Order them in decreasing order by salary.
SELECT *
FROM Employees
WHERE Salary >= 50000

--15.Write a SQL query to find the top 5 best paid employees.
SELECT TOP 5 CONCAT(FirstName, ' ', LastName) AS Employee
FROM Employees
ORDER BY Salary DESC

--16. Write a SQL query to find all employees along with their address. 
--Use inner join with ON clause.
SELECT e.FirstName, e.LastName, e.AddressID, a.AddressID, a.AddressText
FROM Employees e
INNER JOIN Addresses a
	ON e.AddressID = a.AddressID

--17. Write a SQL query to find all employees and their address. 
--Use equijoins (conditions in the WHERE clause).
SELECT *
FROM Employees e
JOIN Addresses a
	ON e.AddressID = a.AddressID

--18. Write a SQL query to find all employees along with their manager.
SELECT e.EmployeeID, CONCAT(e.FirstName, ' ', e.LastName) AS Employee,
				m.ManagerID, CONCAT(m.FirstName, ' ', m.LastName) AS Manager
FROM Employees e
JOIN Employees m
	ON e.ManagerID = m.EmployeeID

--19. Write a SQL query to find all employees, along with their manager and their address. 
--Join the 3 tables: Employees e, Employees m and Addresses a.
SELECT e.EmployeeID, CONCAT(e.FirstName, ' ', e.LastName) AS Employee,
		m.EmployeeID, CONCAT(m.FirstName, ' ', m.LastName) AS Manager,
		a.AddressID, a.AddressText
FROM Employees e
JOIN Employees m
	ON E.ManagerID = M.EmployeeID
JOIN Addresses a
	ON E.AddressID = A.AddressID

--20. Write a SQL query to find all departments and all town names as a single list. Use UNION.
SELECT d.Name
FROM Departments d
UNION 
SELECT t.Name
FROM Towns t

--21. Write a SQL query to find all the employees and the manager for each of them 
--along with the employees that do not have manager. Use right outer join. 
--Rewrite the query to use left outer join.
SELECT CONCAT(e.FirstName,' ', e.LastName) AS Employee,
		CONCAT(m.FirstName, ' ', m.LastName) AS Manager
FROM Employees e
RIGHT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID


SELECT CONCAT(e.FirstName,' ', e.LastName) AS Employee,
		CONCAT(m.FirstName, ' ', m.LastName) AS Manager
FROM Employees e
LEFT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID
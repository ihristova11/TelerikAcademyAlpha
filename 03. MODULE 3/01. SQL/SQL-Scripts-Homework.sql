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

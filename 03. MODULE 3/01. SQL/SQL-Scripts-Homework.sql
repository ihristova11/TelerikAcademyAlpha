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
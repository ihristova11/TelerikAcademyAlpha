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



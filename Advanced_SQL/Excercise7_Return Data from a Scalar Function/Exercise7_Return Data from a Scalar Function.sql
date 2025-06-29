use dbms;
DROP TABLE IF EXISTS Employees;
DROP TABLE IF EXISTS Departments;

CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);


CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);


INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'IT'),
(3, 'Finance');


INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Bob', 'Johnson', 3, 5500.00, '2021-07-01');


DELIMITER $$

CREATE FUNCTION fn_CalculateAnnualSalary(empId INT)
RETURNS DECIMAL(10,2)
DETERMINISTIC
BEGIN
    DECLARE annual_salary DECIMAL(10,2);
    
    SELECT Salary * 12
    INTO annual_salary
    FROM Employees
    WHERE EmployeeID = empId;

    RETURN annual_salary;
END$$

DELIMITER ;


SELECT fn_CalculateAnnualSalary(1) AS AnnualSalary;

USE dbms;

DROP TABLE IF EXISTS Employees;
DROP TABLE IF EXISTS Departments;

CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY AUTO_INCREMENT,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);


INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');

-- Insert initial data into Employees
INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
('John', 'Doe', 1, 5000.00, '2020-01-15'),
('Jane', 'Smith', 2, 6000.00, '2019-03-22'),
('Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
('Emily', 'Davis', 4, 5500.00, '2021-11-05');

-- Define procedure to get employees by department
DELIMITER $$
CREATE PROCEDURE sp_GetEmployeesByDepartment(IN DeptID INT)
BEGIN
    SELECT 
        E.EmployeeID,
        E.FirstName,
        E.LastName,
        D.DepartmentName,
        E.Salary,
        E.JoinDate
    FROM 
        Employees E
    INNER JOIN 
        Departments D ON E.DepartmentID = D.DepartmentID
    WHERE 
        E.DepartmentID = DeptID;
END$$
DELIMITER ;

-- Call procedure for Department 3 (IT)
CALL sp_GetEmployeesByDepartment(3);

-- Define procedure to insert new employee
DELIMITER $$
CREATE PROCEDURE sp_InsertEmployee (
    IN FirstName VARCHAR(50),
    IN LastName VARCHAR(50),
    IN DepartmentID INT,
    IN Salary DECIMAL(10,2),
    IN JoinDate DATE
)
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (FirstName, LastName, DepartmentID, Salary, JoinDate);
END$$
DELIMITER ;

-- Insert new employee Sarah Williams into Finance (DepartmentID 2)
CALL sp_InsertEmployee('Sarah', 'Williams', 2, 6200.00, '2023-08-10');

-- Show all employees after insertion
SELECT * FROM Employees;

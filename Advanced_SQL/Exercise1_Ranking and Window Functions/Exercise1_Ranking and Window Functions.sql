USE dbms; 
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);
INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Laptop', 'Electronics', 80000),
(2, 'TV', 'Electronics', 60000),
(3, 'Camera', 'Electronics', 60000),
(4, 'Jeans', 'Fashion', 2000),
(5, 'Shirt', 'Fashion', 1500),
(6, 'Jacket', 'Fashion', 2000),
(7, 'Watch', 'Fashion', 3000);
SELECT *
FROM (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum,
           RANK()       OVER (PARTITION BY Category ORDER BY Price DESC) AS PriceRank,
           DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRank
    FROM Products
) RankedProducts
WHERE RowNum <= 3 OR PriceRank <= 3 OR DenseRank <= 3;



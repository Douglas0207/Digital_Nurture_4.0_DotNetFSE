# Exercise 1 – Ranking and Window Functions

## 🔍 Problem Statement

Write a SQL query to create a `Products` table with product details, insert sample data, and retrieve the **top 3 products in each category** using `ROW_NUMBER()`, `RANK()`, and `DENSE_RANK()` window functions, based on descending price order.

This exercise demonstrates the use of **window functions** in SQL to rank rows within groups, which is a common requirement in analytical queries such as getting top-N results.

## 🗃️ Table Structure

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);

This table stores product information across various categories, including product names, categories, and their prices.

## 📥 Sample Data Inserted

INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Laptop', 'Electronics', 80000),
(2, 'TV', 'Electronics', 60000),
(3, 'Camera', 'Electronics', 60000),
(4, 'Jeans', 'Fashion', 2000),
(5, 'Shirt', 'Fashion', 1500),
(6, 'Jacket', 'Fashion', 2000),
(7, 'Watch', 'Fashion', 3000);

We inserted a mix of electronic and fashion items with varying prices to simulate real-world data for ranking analysis.

## 🧠 SQL Logic Applied

We used three window functions to assign ranks to products within each category:

- `ROW_NUMBER()` – assigns a unique number to each row based on price, even if prices are the same.
- `RANK()` – gives the same rank to rows with the same price but may skip numbers.
- `DENSE_RANK()` – similar to `RANK()` but without gaps in ranking.

These ranks are calculated within each category using `PARTITION BY Category` and ordered by price in descending order.

SELECT *
FROM (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum,
           RANK()       OVER (PARTITION BY Category ORDER BY Price DESC) AS PriceRank,
           DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRank
    FROM Products
) RankedProducts
WHERE RowNum <= 3 OR PriceRank <= 3 OR DenseRank <= 3;

The inner query adds three types of rank columns for each product. The outer query filters the results to only include the top 3 products per category according to the three different rankings.

## ✅ Output Screenshot

<img width="1440" alt="Screenshot 2025-06-29 at 9 13 10 PM" src="https://github.com/user-attachments/assets/1e2fb021-f5ec-4091-b0f6-a0d271cc3a9b" />


This screenshot shows the product list along with their calculated row numbers, ranks, and dense ranks, filtered to show only the top entries per category.

## 🧾 Explanation

This query is useful for finding the top-N products within each category — a common requirement in business intelligence and analytics. 

By comparing `ROW_NUMBER`, `RANK`, and `DENSE_RANK`, we understand the differences in how SQL handles ties:
- `ROW_NUMBER()` always gives unique numbers (no ties).
- `RANK()` allows ties but leaves gaps.
- `DENSE_RANK()` allows ties but maintains continuous ranking.

This logic is commonly used in dashboards, reports, leaderboards, and performance analysis tools.

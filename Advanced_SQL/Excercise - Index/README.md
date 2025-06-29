# Exercise – Index

## 🔍 Problem Statement

The aim of this exercise is to understand the purpose and performance impact of using **indexes** in a relational database. Indexes are created on columns that are frequently searched or used in conditions, to improve query speed and efficiency.

## 🧠 SQL Logic Applied

In this exercise, we worked with a set of interrelated tables: `Customers`, `Products`, `Orders`, and `OrderDetails`. After populating them with data, we executed queries to search for specific product names and order dates — first **without indexes**, and then **after creating indexes** on those columns.

We created:
- A single-column index on `ProductName` in the `Products` table.
- A single-column index on `OrderDate` in the `Orders` table.
- A composite index on `CustomerID` and `OrderDate` in the `Orders` table.

These indexes optimize the database's ability to quickly locate rows without scanning the entire table.

## ✅ Output Screenshot

<img width="1440" alt="Screenshot 2025-06-29 at 9 15 48 PM" src="https://github.com/user-attachments/assets/1c82b4d7-3a76-43b2-a1b5-d01af906888e" />


## 🧾 Explanation

Indexes significantly reduce query time by allowing the database engine to find records faster, especially for large datasets. This is particularly useful for:
- Search operations on specific columns
- Join conditions
- WHERE clauses with multiple filters

However, while indexes improve read performance, they may slightly affect insert/update speed and use additional storage. Composite indexes are useful when queries filter on multiple columns.

This exercise shows how **strategically placed indexes** improve query performance, especially in transactional systems like e-commerce databases.

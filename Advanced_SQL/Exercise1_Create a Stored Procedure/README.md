# Exercise 1 – Stored Procedures with Employees & Departments

## 🔍 Problem Statement

The goal of this exercise is to demonstrate how to use stored procedures in MySQL for retrieving and inserting employee data linked to their respective departments.

## 🧠 SQL Logic Applied

We created two stored procedures:

- One procedure retrieves all employees from a specific department using a department ID as input. It performs an inner join between Employees and Departments to return detailed information.

- The second procedure inserts a new employee into the system, accepting values like first name, last name, salary, department, and join date as parameters.

These procedures help modularize the database logic and reduce the repetition of SQL queries. It also ensures cleaner application-layer code when interacting with the database.

## ✅ Output Screenshot

<img width="1440" alt="Screenshot 2025-06-29 at 9 17 14 PM" src="https://github.com/user-attachments/assets/1df52e16-ba39-46d4-a3ea-8ddb5ca742aa" />


## 🧾 Explanation

Using stored procedures helps in:
- Abstracting complex queries
- Improving code reusability
- Adding security by restricting direct access to tables
- Centralizing business logic at the database level

This approach is especially useful in large applications where multiple modules need to perform similar database operations.

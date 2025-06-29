# Exercise 7 – Return Data from a Scalar Function

## 🔍 Problem Statement

The objective of this exercise is to demonstrate how to create and use a scalar function in MySQL that performs a calculation and returns a single value.

## 🧠 SQL Logic Applied

We created a user-defined function that calculates the **annual salary** of an employee based on their monthly salary stored in the database. The function takes an `EmployeeID` as input, retrieves the corresponding monthly salary, multiplies it by 12, and returns the result.

This approach helps encapsulate simple business logic (like salary computations) directly inside the database for reusability and better data handling.

## ✅ Output Screenshot

<img width="1440" alt="Screenshot 2025-06-29 at 9 14 10 PM" src="https://github.com/user-attachments/assets/9dc1e9c1-3907-409b-be1c-e9268b47324c" />


## 🧾 Explanation

Scalar functions return a single computed value and can be reused in queries just like built-in SQL functions. They are ideal for:
- Repeated calculations
- Reducing duplication of logic in multiple queries
- Making complex queries easier to read

This function is useful in payroll or reporting systems where annual salary needs to be shown without modifying the original table structure.

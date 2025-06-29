# Exercise – NUnit Unit Testing

## 🔍 Problem Statement

This exercise demonstrates the use of **unit testing** in C# using the **NUnit framework**. The goal is to test the `Add` method of a simple calculator class to ensure it behaves correctly for various inputs.

## 🧠 Logic Applied

We created a basic calculator class with an `Add` method, and a corresponding test class using NUnit. The test class contains multiple test cases to verify that the `Add` method returns the expected result for:
- Positive integers
- Zero values
- Negative integers

NUnit attributes like `[SetUp]`, `[TestCase]`, and `[TearDown]` are used to structure and manage the tests efficiently.

- `[SetUp]` prepares the test environment by creating a new Calculator instance.
- `[TestCase]` provides input and expected output combinations to validate the `Add` method.
- `[TearDown]` is used to clean up after each test, ensuring no shared state affects test outcomes.

## ✅ Output Screenshot

<img width="1440" alt="Screenshot 2025-06-29 at 9 30 38 PM" src="https://github.com/user-attachments/assets/40ea7409-3b6b-4a58-8543-e6f0c6b7f091" />


## 🧾 Explanation

Unit testing is essential in software development to ensure individual components work as intended. In this example:
- We verified the correctness of a simple addition method.
- We used multiple inputs to check for reliability across edge cases.
- The structure follows best practices in NUnit-based test-driven development.

This exercise highlights how **automated tests** help catch errors early, improve code quality, and provide confidence during future changes or refactoring.

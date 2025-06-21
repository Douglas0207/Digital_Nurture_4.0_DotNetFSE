📈 Exercise: Financial Forecasting Using Recursion

📘 Scenario
This exercise involves building a basic financial forecasting tool that predicts future values based on historical data using recursive techniques. The goal is to understand recursion and apply it to a real-world problem.

📚 Step 1: Understanding Recursive Algorithms

🔁 What is Recursion?
Recursion is a programming technique where a function calls itself to solve smaller instances of the same problem. It’s useful for tasks that can be broken down into repeated sub-problems.

Advantages of recursion:
- Simplifies code for problems with repetitive or nested structures.
- Often provides cleaner, more elegant solutions.

However, recursion must be carefully handled to avoid stack overflow or redundant computations.

⚙️ Step 2: Setup

We define a method to predict future financial values based on:
- A base value (e.g., starting revenue or profit)
- A fixed growth rate
- The number of years into the future

📌 Recursive Formula:
FutureValue(years) = FutureValue(years - 1) * (1 + growthRate)

🧠 Step 3: Implementation – Recursive Forecasting

A simple recursive function is implemented in C#:

Example:

double PredictFutureValue(double currentValue, double growthRate, int years)
{
    if (years == 0)
        return currentValue;
    return PredictFutureValue(currentValue, growthRate, years - 1) * (1 + growthRate);
}

This function calculates the projected value year by year, based on compound growth.

📊 Step 4: Analysis

⏱ Time Complexity
- Without optimization, the time complexity is O(n), where n = number of years.
- Each recursive call computes one year into the future.

⚠️ Optimization Tips
- Use **memoization** or convert to an **iterative approach** to avoid redundant recursive calls.
- For performance-critical systems, avoid deep recursion and prefer loops for predictable growth calculations.

🖼 Output Screenshots
Screenshots showing predicted values for various inputs are included to demonstrate the recursive calculation in action.

🛠 Tools Used
- Language: C#
- IDE: Visual Studio / VS Code

🙌 Author
Robinson Douglas
<img width="1440" alt="Screenshot 2025-06-21 at 8 45 42 PM" src="https://github.com/user-attachments/assets/0d65e8a0-c6fb-47d8-95dd-85d88763f796" />

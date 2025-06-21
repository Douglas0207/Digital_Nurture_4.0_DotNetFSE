🛒 Exercise 2: E-commerce Platform Search Function

📘 Scenario
This exercise focuses on implementing and understanding the search functionality of an e-commerce platform. In this version, we focus on the linear search algorithm, with plans to implement binary search next.

📚 Step 1: Understanding Asymptotic Notation

🔍 Big O Notation
Big O notation is used to describe an algorithm’s time and space complexity as input size grows.

- O(1) – Constant time
- O(n) – Linear time
- O(log n) – Logarithmic time

📈 Search Scenarios for Linear Search

Scenario    | Time Complexity
------------|----------------
Best        | O(1)
Average     | O(n)
Worst       | O(n)

Linear search checks each element one by one until a match is found.

⚙️ Step 2: Setup

A Product class was created with the following attributes:

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }
}

An array of Product objects is used to simulate the product catalog.

🧠 Step 3: Implementation – Linear Search

- The linear search algorithm iterates through the product list.
- It checks each Product for a matching name or ID.
- Simple to implement and effective for small or unsorted datasets.

Pseudocode:

foreach (Product product in products)
{
    if (product.ProductName == targetName)
    {
        // Found product
    }
}

📊 Step 4: Analysis

⏱ Time Complexity of Linear Search

- Best Case: O(1) – First item matches
- Worst Case: O(n) – Match is at the end or not present
- Average Case: O(n)

✅ Conclusion
Linear search is simple but not optimal for large datasets. It will be replaced with binary search in the next iteration, which requires sorting and offers better performance.

🖼 Output Screenshots
Screenshots of the console output demonstrating linear search functionality are included.

🛠 Tools Used
- Language: C#
- IDE: Visual Studio / VS Code

📌 Upcoming
🔜 Binary Search implementation and performance comparison will be added in the next update.

🙌 Author
Robinson Douglas
<img width="1440" alt="Screenshot 2025-06-21 at 8 47 27 PM" src="https://github.com/user-attachments/assets/b09132dc-1c93-4cb1-a9c9-f72779cb5edd" />

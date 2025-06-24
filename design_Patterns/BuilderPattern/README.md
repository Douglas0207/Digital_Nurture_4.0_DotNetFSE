# Builder Pattern - Implementation Summary

## Objective
To construct complex objects (like a Computer) with optional parameters in a readable, flexible, and scalable way using the Builder Design Pattern.

## Design Steps

1. **Create the Product Class**
   - Defined a `Computer` class with optional parts:
     - CPU
     - RAM
     - Storage
     - Graphics Card
     - Operating System

2. **Implement a Static Nested Builder Class**
   - Inside the `Computer` class, added a nested static class called `Builder`.
   - Provided methods inside the `Builder` class to set each field one by one.
   - Added a `Build()` method that returns a new `Computer` object.

3. **Private Constructor in Product Class**
   - Made the `Computer` constructor `private`.
   - Allowed construction only via the `Builder` class.

4. **Test the Builder Implementation**
   - In `Program.cs`, demonstrated creating computers using the Builder:
     - One with full specifications
     - Another with partial specs

5. **Handled Missing Fields Gracefully**
   - Used null-coalescing (`??`) to display “Not specified” for unset fields.

## Key Concepts Demonstrated

- Step-by-step object construction
- Better readability compared to telescoping constructors
- Clean object immutability pattern
- Safe handling of optional properties

## Output Example (Console)

<img width="1440" alt="Screenshot 2025-06-24 at 10 47 21 PM" src="https://github.com/user-attachments/assets/2d98f62a-0578-4ae1-a1e7-9b20a92653ae" />

# Decorator Pattern - Implementation Summary

## Objective
To dynamically add notification features (like Email, SMS, Slack) to a base notifier class without modifying its structure using the Decorator Design Pattern.

## Design Steps

1. **Define a Common Interface**
   - Created an interface `INotifier` with a method `Send(string message)`.

2. **Implement the Concrete Component**
   - Created `EmailNotifier` class that implements `INotifier` and sends the base notification via Email.

3. **Create an Abstract Decorator**
   - Defined an abstract class `NotifierDecorator` that:
     - Implements `INotifier`
     - Holds a protected reference to another `INotifier` instance
     - Passes the `Send()` call down the chain

4. **Implement Concrete Decorators**
   - Developed classes like `SMSNotifierDecorator` and `SlackNotifierDecorator` that:
     - Inherit from `NotifierDecorator`
     - Add their own logic after calling `base.Send()`

5. **Test the Notification Stack**
   - In `Program.cs`, layered multiple decorators:
     - Email → SMS → Slack
   - Sent a single message that passed through all decorators.

## Key Concepts Demonstrated

- Open/Closed Principle: new behaviors without modifying existing code
- Layering functionality at runtime
- Flexible, pluggable extension of object behavior

## Output Example (Console)

<img width="1440" alt="Screenshot 2025-06-24 at 10 48 38 PM" src="https://github.com/user-attachments/assets/02a305ae-7639-42ea-80a5-0c787ee9dab8" />

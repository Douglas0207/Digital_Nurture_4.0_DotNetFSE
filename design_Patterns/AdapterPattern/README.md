# Adapter Pattern - Implementation Summary

## Objective
To integrate multiple third-party payment gateways with different interfaces into a unified payment processing system using the Adapter Design Pattern.

## Design Steps

1. **Define the Target Interface**
   - Created an interface `PaymentProcessor` with a method `ProcessPayment(decimal amount)` representing the standard payment operation.

2. **Create Adaptee Classes**
   - Developed concrete payment gateway classes like `PayPalGateway` and `GPayGateway`, each with their own unique method signatures:
     - `PayPalGateway.MakePayment(amount)`
     - `GPayGateway.MakeTransaction(amount)`

3. **Implement Adapter Classes**
   - Created adapter classes `PayPalAdapter` and `GPayAdapter` that:
     - Implement the `PaymentProcessor` interface.
     - Internally call the respective gateway's actual methods.
     - Translate the generic `ProcessPayment()` call into the specific gateway logic.

4. **Test the Adapter Integration**
   - In the `Program.cs`, instantiated both adapter classes and invoked `ProcessPayment()` with different amounts.
   - Confirmed that both payment gateways executed successfully through a common interface.

## Key Concepts Demonstrated

- Interface-based programming
- Decoupling client code from third-party APIs
- Flexibility in extending support for new gateways by simply creating new adapter classes

## Output Example (Console)


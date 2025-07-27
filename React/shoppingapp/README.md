# React – Exercise 7

## Objective

In this exercise, I learned to:

- Understand what props are and how to use them in React  
- Learn the concept of default props  
- Differentiate between props and state in a component  
- Understand how `ReactDOM.render()` is used to render a component to the DOM  

## What I Did

I created a new React project named `shoppingapp` using create-react-app and opened it in Visual Studio Code.

Inside the project, I created two class components: `OnlineShopping` and `Cart`. In the `Cart` class, I defined two properties: `Itemname` and `Price` which were passed through props.

In the `OnlineShopping` component, I created an array of five items where each item represented a cart entry with a name and a price. I then looped through this array and rendered the `Cart` component for each item, passing the data using props.

By doing this, I got a clear understanding of how props work for passing data between components and how `ReactDOM.render()` is used to load the main component into the browser.

## Output Screenshot

<img width="1440" height="900" alt="Screenshot 2025-07-27 at 8 41 59 PM" src="https://github.com/user-attachments/assets/1ce4f4af-a88b-438d-bc61-5f7272db2980" />

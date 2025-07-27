# React Course – Exercise 8

## Objective

In this exercise, I learned to:

- Understand how state works in React components  
- Use the `state` object to store and update data within a component  

## What I Did

I created a new React application named `counterapp` using create-react-app and opened it in Visual Studio Code.

Inside the app, I built a class component called `CountPeople`. This component was designed to track the number of people entering and exiting a mall.

I used the constructor to define the initial state with two values: `entrycount` and `exitcount`, both set to 0.

Two methods were created:
- `UpdateEntry()` to increase the entry count by 1 each time the "Login" button is clicked  
- `UpdateExit()` to increase the exit count by 1 each time the "Exit" button is clicked  

Both values were updated using the `setState()` method. I also added two buttons in the UI to trigger these methods, allowing users to interact with the component and see the counts change in real time.

This helped me clearly understand how state works in React and how it allows components to respond dynamically to user actions.

## Output Screenshot

<img width="1440" height="900" alt="Screenshot 2025-07-27 at 9 25 52 PM" src="https://github.com/user-attachments/assets/8929b676-0418-4f9d-b2db-df00eebd4b02" />


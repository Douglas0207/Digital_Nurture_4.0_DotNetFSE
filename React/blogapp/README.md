# React – Exercise 4

## Objective

In this exercise, I learned to:

- Understand the need for component life cycle methods in React  
- Explore the different life cycle hook methods and their roles  
- Learn the sequence of how a component is rendered, updated, and unmounted  

## What I Did

I created a new React project named `blogapp` using create-react-app and opened it in Visual Studio Code.

Inside the `src` folder, I created two new class components:

- `Post` – to define individual post properties  
- `Posts` – to handle the collection of posts and manage lifecycle methods  

In the `Posts` component, I used the constructor to initialize a state with an empty list of posts. Then I defined a method called `loadPosts()` which used the Fetch API to retrieve data from a public API (`https://jsonplaceholder.typicode.com/posts`) and update the state.

To trigger the data fetching after the component mounted, I implemented the `componentDidMount()` lifecycle method and called `loadPosts()` from there.

I also implemented the `render()` method to loop through the posts and display each one’s title and body using headings and paragraphs.

To handle unexpected errors gracefully, I defined a `componentDidCatch()` method that would show an alert if something went wrong during rendering.

Finally, I added the `Posts` component into the main `App` component and ran the application to see the list of blog posts displayed in the browser.

## Output Screenshot

<img width="1440" height="900" alt="Screenshot 2025-07-27 at 7 20 55 PM" src="https://github.com/user-attachments/assets/f72fa5c0-ceea-44bc-b1c9-af2a9d9f7be9" />


# React – Exercise 5

## Objective

In this exercise, I learned to:

- Understand the importance of styling in React components  
- Use CSS Modules to define scoped styles  
- Apply styles using both `className` and inline `style` properties  

## What I Did

As part of a MyAcademy team project simulation, I was given a partially built React application that displayed the details of different cohorts. My task was to apply styling to the components to make them visually appealing and organized.

I began by unzipping the given React project and restoring the node modules using the terminal. Once the environment was ready, I opened the application in Visual Studio Code.

Inside the project, I created a new CSS Module file called `CohortDetails.module.css`. In this file, I defined a reusable class named `box` which included styling like fixed width, padding, border, and rounded corners to give a card-like appearance to each cohort block.

I also styled HTML elements directly—like the `<dt>` tag—by using tag selectors in the CSS Module. I set its font weight for better visibility.

Next, I imported this CSS Module into the CohortDetails component and applied the styles appropriately. For the `<h3>` tag, I applied conditional inline styles:  
- If the cohort status was “ongoing”, the text appeared in green  
- For all other statuses, the text appeared in blue  

These styling techniques helped visually separate ongoing and completed cohorts while maintaining a consistent and polished layout.

## Output Screenshot

<img width="1440" height="900" alt="Screenshot 2025-07-27 at 7 59 04 PM" src="https://github.com/user-attachments/assets/7cb6f9ca-0375-4d90-ad91-692f66de5251" />


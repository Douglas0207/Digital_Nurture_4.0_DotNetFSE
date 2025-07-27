# React – Exercise 6

## Objective

In this exercise, I learned to:

- Understand the need and advantages of using React Router  
- Explore the different router components available in React  
- Learn how to configure routes and create a navigation system  
- Pass parameters through URLs to display specific data  

## What I Did

I created a new React project called `TrainersApp` using create-react-app and opened it in Visual Studio Code.

First, I created a class named `Trainer` inside a file called `trainer.js` with properties like ID, Name, Email, Phone, Technology, and Skills. I then created a new file `TrainersMock.js` to hold mock data representing multiple trainers.

To enable routing in my application, I installed the `react-router-dom` library. I created a new component named `TrainersList` which accepted the mock data and displayed the list of trainers. Each trainer’s name was rendered as a clickable link.

I also created a simple `Home` component to serve as the landing page. Then I updated the main `App` component to set up routing using `BrowserRouter`, `Routes`, `Route`, and `Link`. I defined the following routes:
- `/` for the Home component  
- `/trainers` for the list of trainers  
- `/trainers/:id` for viewing a specific trainer’s details  

To support detailed views, I created a `TrainerDetail` component. This component used the `useParams` hook to extract the trainer ID from the URL. It then searched the mock data using this ID and displayed the corresponding trainer’s details.

Finally, I tested the full flow:
- Navigating to the home page  
- Viewing the list of trainers  
- Clicking on a trainer to see their details using dynamic routing  

## Output Screenshot

<img width="1440" height="900" alt="Screenshot 2025-07-27 at 8 21 28 PM" src="https://github.com/user-attachments/assets/19a741bb-15d4-4f0a-b157-c6ad0371fa73" />

<img width="1440" height="900" alt="Screenshot 2025-07-27 at 8 21 30 PM" src="https://github.com/user-attachments/assets/d84c8cff-4fa9-45b4-b833-071a844d7cb7" />

<img width="1440" height="900" alt="Screenshot 2025-07-27 at 8 21 32 PM" src="https://github.com/user-attachments/assets/2633c95e-8f4a-4c51-91a5-3b3004b3805e" />

<img width="1440" height="900" alt="Screenshot 2025-07-27 at 8 21 38 PM" src="https://github.com/user-attachments/assets/f3e83a19-3252-49bd-be40-e1142fd55a7d" />

import React from "react";
import CourseDetails from "./components/CourseDetails";
import BookDetails from "./components/BookDetails";
import BlogDetails from "./components/BlogDetails";

function App() {
  const showAll = true; 

  const courses = [
    { name: "Angular", date: "4/5/2021" },
    { name: "React", date: "6/3/20201" },
  ];

  const books = [
    { title: "Master React", price: 670 },
    { title: "Deep Dive into Angular 11", price: 800 },
    { title: "Mongo Essentials", price: 450 },
  ];

  const blogs = [
    { title: "React Learning", author: "Stephen Biz", content: "Welcome to learning React!" },
    { title: "Installation", author: "Schwezdenier", content: "You can install React from npm." },
  ];

  return (
    <div className="App">
      <h1 style={{ textAlign: "center" }}>📚 Blogger App</h1>

      {showAll ? (
        <div style={{ display: "flex", justifyContent: "space-around" }}>
          <CourseDetails courses={courses} />
          <BookDetails books={books} />
          <BlogDetails blogs={blogs} />
        </div>
      ) : (
        <p style={{ textAlign: "center" }}>Components are hidden (toggle showAll to true)</p>
      )}
    </div>
  );
}

export default App;

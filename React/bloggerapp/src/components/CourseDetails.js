import React from "react";

const CourseDetails = ({ courses }) => {
  return (
    <div style={{ width: "30%", padding: "10px", borderRight: "4px solid green" }}>
      <h2>Course Details</h2>
      {courses.map((course, index) => (
        <div key={index}>
          <h3>{course.name}</h3>
          <p>{course.date}</p>
        </div>
      ))}
    </div>
  );
};

export default CourseDetails;

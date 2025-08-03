import React from "react";

const BlogDetails = ({ blogs }) => {
  return (
    <div style={{ width: "30%", padding: "10px" }}>
      <h2>Blog Details</h2>
      {blogs.map((blog, index) => (
        <div key={index}>
          <h3>{blog.title}</h3>
          <p><strong>{blog.author}</strong></p>
          <p>{blog.content}</p>
        </div>
      ))}
    </div>
  );
};

export default BlogDetails;

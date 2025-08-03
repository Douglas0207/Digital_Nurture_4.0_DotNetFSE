import React from "react";

const User = ({ onLogout }) => {
  return (
    <div style={{ textAlign: "center" }}>
      <h2>Welcome User!</h2>
      <p>You are now logged in and can book your flight tickets.</p>
      <button onClick={onLogout}>Logout</button>
    </div>
  );
};

export default User;

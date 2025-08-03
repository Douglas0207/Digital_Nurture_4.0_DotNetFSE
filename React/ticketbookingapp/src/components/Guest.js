import React from "react";

const Guest = ({ onLogin }) => {
  return (
    <div style={{ textAlign: "center" }}>
      <h2>Welcome Guest!</h2>
      <p>You can browse available flight details, but must login to book tickets.</p>
      <button onClick={onLogin}>Login</button>
    </div>
  );
};

export default Guest;

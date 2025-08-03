import React, { useState } from "react";
import Guest from "./components/Guest";
import User from "./components/User";

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLogin = () => setIsLoggedIn(true);
  const handleLogout = () => setIsLoggedIn(false);

  let content;

  if (isLoggedIn) {
    content = <User onLogout={handleLogout} />;
  } else {
    content = <Guest onLogin={handleLogin} />;
  }

  return (
    <div className="App">
      <h1 style={{ textAlign: "center" }}>Ticket Booking App</h1>
      {content}
    </div>
  );
}

export default App;

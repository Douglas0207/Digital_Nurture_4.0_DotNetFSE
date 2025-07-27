import React from "react";
import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";

import Home from "./Home";
import TrainersList from "./TrainerList";
import TrainerDetails from "./TrainerDetails";
import trainers from './TrainersMock';


const App = () => {
  return (
    <Router>
      <div style={{ padding: "20px" }}>
        <h1>My Academy Trainers App</h1>
        <nav>
          <Link to="/">Home</Link> | <Link to="/trainers">Show Trainers</Link>
        </nav>

        <hr />

        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/trainers" element={<TrainersList trainers={trainers} />} />
          <Route path="/trainers/:id" element={<TrainerDetails />} />
        </Routes>
      </div>
    </Router>
  );
};

export default App;

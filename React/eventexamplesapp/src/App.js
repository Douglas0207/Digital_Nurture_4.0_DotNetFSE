import React from "react";
import Counter from "./components/Counter";
import CurrencyConvertor from "./components/CurrencyConvertor";

function App() {
  return (
    <div className="App">
      <h1 style={{ textAlign: "center" }}>React Event Handling Examples</h1>
      <Counter />
      <CurrencyConvertor />
    </div>
  );
}

export default App;

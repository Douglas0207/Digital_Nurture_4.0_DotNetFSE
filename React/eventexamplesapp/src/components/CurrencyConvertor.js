import React, { useState } from "react";

const CurrencyConvertor = () => {
  const [rupees, setRupees] = useState("");
  const [euro, setEuro] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();
    const euroValue = (parseFloat(rupees) / 90).toFixed(2); // example rate
    setEuro(euroValue);
  };

  return (
    <div style={{ textAlign: "center", marginTop: "40px" }}>
      <h2>Currency Converter (INR ➡️ EUR)</h2>

      <form onSubmit={handleSubmit}>
        <input
          type="number"
          value={rupees}
          placeholder="Enter INR"
          onChange={(e) => setRupees(e.target.value)}
        />
        &nbsp;
        <button type="submit">Convert</button>
      </form>

      {euro && <h3>Euro: €{euro}</h3>}
    </div>
  );
};

export default CurrencyConvertor;

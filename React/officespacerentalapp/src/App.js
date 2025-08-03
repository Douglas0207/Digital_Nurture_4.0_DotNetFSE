import React from "react";

function App() {
  const heading = <h1>Office Space, at Affordable Range</h1>;

  const offices = [
    {
      name: "DBS",
      rent: 50000,
      address: "Chennai",
      image: "https://images.unsplash.com/photo-1600585154340-be6161a56a0c?auto=format&fit=crop&w=800&q=80",
    },
    {
      name: "SmartWorks",
      rent: 65000,
      address: "Bangalore",
      image: "https://images.unsplash.com/photo-1573164713988-8665fc963095?auto=format&fit=crop&w=800&q=80",
    },
    {
      name: "Innov8",
      rent: 58000,
      address: "Hyderabad",
      image: "https://images.unsplash.com/photo-1552820728-8b83bb6b7738?auto=format&fit=crop&w=800&q=80",
    },
  ];
  

  return (
    <div style={{ textAlign: "center" }}>
      {heading}

      {offices.map((office, index) => {
        const rentStyle = {
          color: office.rent < 60000 ? "red" : "green",
          fontWeight: "bold",
        };

        return (
          <div key={index} style={{ marginBottom: "40px" }}>
            <img
              src={office.image}
              alt={office.name}
              style={{ width: "400px", height: "300px" }}
            />
            <h2 style={{ color: "black" }}>Name: {office.name}</h2>
            <p style={rentStyle}>Rent: Rs. {office.rent}</p>
            <p>Address: {office.address}</p>
          </div>
        );
      })}
    </div>
  );
}

export default App;

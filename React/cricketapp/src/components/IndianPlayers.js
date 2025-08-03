import React from "react";

const IndianPlayers = () => {
  const indianPlayers = ["Sachin", "Dhoni", "Virat", "Rohit", "Yuvraj", "Raina"];

  const [first, second, third, fourth, fifth, sixth] = indianPlayers;

  const oddPlayers = [
    { label: "First", name: `${first}1` },
    { label: "Third", name: `${third}3` },
    { label: "Fifth", name: `${fifth}5` },
  ];

  const evenPlayers = [
    { label: "Second", name: `${second}2` },
    { label: "Fourth", name: `${fourth}4` },
    { label: "Sixth", name: `${sixth}6` },
  ];

  const T20Players = ["Mr. First Player", "Mr. Second Player", "Mr. Third Player"];
  const RanjiPlayers = ["Mr. Fourth Player", "Mr. Fifth Player", "Mr. Sixth Player"];

  const allPlayers = [...T20Players, ...RanjiPlayers]; 

  return (
    <div>
      <h2>Odd Players</h2>
      {oddPlayers.map((p, index) => (
        <div key={index}>{p.label} : {p.name}</div>
      ))}

      <hr />
      <h2>Even Players</h2>
      {evenPlayers.map((p, index) => (
        <div key={index}>{p.label} : {p.name}</div>
      ))}

      <hr />
      <h2>List of Indian Players Merged:</h2>
      {allPlayers.map((p, index) => (
        <div key={index}>{p}</div>
      ))}
    </div>
  );
};

export default IndianPlayers;

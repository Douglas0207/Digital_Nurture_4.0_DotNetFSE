import React, { Component } from "react";

class Counter extends Component {
  constructor() {
    super();
    this.state = {
      count: 0,
    };
  }

  increment = () => {
    this.setState({ count: this.state.count + 1 });
    this.sayHello();
  };

  sayHello = () => {
    console.log("Hello! You clicked increment.");
  };

  decrement = () => {
    this.setState({ count: this.state.count - 1 });
  };

  sayWelcome = (msg) => {
    alert(msg);
  };

  handleClick = (event) => {
    alert("I was clicked");
    console.log("Synthetic Event:", event);
  };

  render() {
    return (
      <div style={{ textAlign: "center" }}>
        <h2>Counter: {this.state.count}</h2>

        <button onClick={this.increment}>Increment</button>&nbsp;
        <button onClick={this.decrement}>Decrement</button>

        <br /><br />

        <button onClick={() => this.sayWelcome("Welcome!")}>Say Welcome</button>

        <br /><br />

        <button onClick={this.handleClick}>OnPress</button>
      </div>
    );
  }
}

export default Counter;

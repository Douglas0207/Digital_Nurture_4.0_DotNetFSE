import React from 'react';
import './CountPeople.css';

class CountPeople extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      entrycount: 0,
      exitcount: 0
    };
  }

  updateEntry = () => {
    this.setState({ entrycount: this.state.entrycount + 1 });
  };

  updateExit = () => {
    this.setState({ exitcount: this.state.exitcount + 1 });
  };

  render() {
    return (
      <div className="container">
        <div className="entry">
          <button onClick={this.updateEntry}>Login</button>
          <span>{this.state.entrycount} People Entered!!!</span>
        </div>
        <div className="exit">
          <button onClick={this.updateExit}>Exit</button>
          <span>{this.state.exitcount} People Left!!!</span>
        </div>
      </div>
    );
  }
}

export default CountPeople;

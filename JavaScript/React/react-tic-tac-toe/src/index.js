import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';


class Square extends React.Component {

  render() {
    return (
      <button className="square" 
      onClick={() => this.props.onClick()}>
      {/*onPointerOut={() => this.setState(prevState =>{return {value: prevState.value + 99}})}>*/}
        {this.props.value}
      
      </button>
    );
  }
}

class Board extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      squares: Array(9).fill(null),
    };
  }

  handleClick(i) {
    const squares = this.state.squares.slice();
    squares[i] = 'X';
    this.setState({squares: squares});
  }

  renderSquare(i) {
    return <Square 
    value={this.state.squares[i]}
    onClick={() => this.handleClick(i)}/>;
  }

  render() {
    const status = 'Next player: X';

    return (
      <div>
        <div className="status">{status}</div>
        <div className="board-row">
          {this.renderSquare(0)}
          {this.renderSquare(1)}
          {this.renderSquare(2)}
        </div>
        <div className="board-row">
          {this.renderSquare(3)}
          {this.renderSquare(4)}
          {this.renderSquare(5)}
        </div>
        <div className="board-row">
          {this.renderSquare(6)}
          {this.renderSquare(7)}
          {this.renderSquare(8)}
        </div>
      </div>
    );
  }
}

class GreatestList extends React.Component {
  render() {
    return (
      <div className="greatest-list">
        <h1>Ryan is the greatest list {this.props.name}</h1>
        <ul>
          <li>Grant</li>
          <li>Matty P</li>
          <li>Donald D Trump</li>
          <li>Mr. T</li>
        </ul>
      </div>
    );
  }
}

class Game extends React.Component {
  render() {
    return (
      <div className="game">
        <div className="game-board">
          <Board />
        </div>
        <div className="game-info">
          <div>{/* status */}</div>
          <ol>{/* TODO */}</ol>
        </div>
        <div className="Greatest-list">
        <GreatestList/>
      </div>
      </div>

      
    );
  }
}

// ========================================

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(<Game />);

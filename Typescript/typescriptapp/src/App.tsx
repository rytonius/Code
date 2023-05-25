import React, { useState } from 'react';
import logo from './logo.svg';
import './App.css';
import { CreatePlayer } from './factory/EntityFactory'
import { Entity } from './models/Entity'

interface MPProps {
  player: Entity;
};

class ManipulatePlayer extends React.Component<MPProps> {
  static DisplayPlayer: any;

  render() {
    const { player } = this.props;

    return (
      <p className="test">
        Name: {player.Name} 
        <br/>HP: {player.HP}
      </p>
    )
  }
}

interface MyButtonProps {
  count: number;
  onClick: () => void;
}

function MyButton({count, onClick}: MyButtonProps) {

  return (
    <button onClick={onClick}
    >Stop clicking on me {count}
    </button>
  );
}

function AboutPage() {
  return (
    <>
      <h1>Have you brushed your teeth?</h1>
      <p>Hello there.<br />How do you do? <br/> You should scroll down a little more</p>
      <p>I'm going to eat you</p>
    </>
  )
}

export default function App() {
  const [count, setCount] = useState(0);
  const [player, setPlayer] = useState(() => CreatePlayer("Billy", 200));
  const [enemy, setEnemy] = useState(() => CreatePlayer("Monster",100));

  function damagePlayer() {
    setCount(count + 1);
    setPlayer(prevPlayer=> ({
      ...prevPlayer,
      HP: prevPlayer.HP - 1,
    }))
  }


  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <div className="Entities">
          <ManipulatePlayer player={player}/>
          <ManipulatePlayer player={enemy}/>
        </div>

        <MyButton count={count} onClick={damagePlayer}/>
      </header>
      <footer>
        <AboutPage></AboutPage>
      </footer>
    </div>
  );
}


import React, { useState } from 'react';
import './App.css';

function App() {
  const [players, setPlayers] = useState([]);

  const addMatchResult = (winner, loser, goalsFor, goalsAgainst) => {
    console.log(winner, loser, goalsFor, goalsAgainst);
  };

  return (
    <div className="App">
      <h1>FIFA Tournament Leaderboard</h1>
      <table>
        <thead>
          <tr>
            <th>Player</th>
            <th>Wins</th>
            <th>Draws</th>
            <th>Losses</th>
            <th>Goals For</th>
            <th>Goals Against</th>
            <th>Points</th>
          </tr>
        </thead>
        <tbody>
          {/* Map through players state to display rows */}
        </tbody>
      </table>
      <h2>Submit Match Result</h2>
      <form onSubmit={(e) => {
        e.preventDefault();
        const winner = e.target.winner.value;
        const loser = e.target.loser.value;
        const goalsFor = parseInt(e.target.goalsFor.value, 10);
        const goalsAgainst = parseInt(e.target.goalsAgainst.value, 10);
        addMatchResult(winner, loser, goalsFor, goalsAgainst);
      }}>
        <input type="text" name="winner" placeholder="Winner's Name" required />
        <input type="text" name="loser" placeholder="Loser's Name" required />
        <input type="number" name="goalsFor" placeholder="Winner's Goals" min="0" required />
        <input type="number" name="goalsAgainst" placeholder="Loser's Goals" min="0" required />
        <button type="submit">Submit Result</button>
      </form>
    </div>
  );
}

export default App;

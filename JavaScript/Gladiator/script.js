let player = {
  hp: 100,
  maxHp: 100,
  attack: 25,
  defense: 10,
  xp: 0,
  level: 1
};

let enemy = {
  hp: 100,
  maxHP: 100,
  attack: 20,
  defense: 5,
  xp: 50
};

const playerHpElement = document.getElementById('player-hp');
const enemyHpElement = document.getElementById('enemy-hp');
const playerAttackElement = document.getElementById('player-attack');
const enemyAttackElement = document.getElementById('enemy-attack');
const playerDefenseElement = document.getElementById('player-defense');
const enemyDefenseElement = document.getElementById('enemy-defense');
const attackButton = document.getElementById('attack-button');
const messageElement = document.getElementById('message');

const playerXpElement = document.getElementById('player-xp')
const playerLvLElement = document.getElementById('player-level')
const enemyXpElement = document.getElementById('enemy-xp')


function applyDamage(target, damage) {
  target.hp -= damage;
  if (target.hp < 0) {
    target.hp = 0;
  }
}

function giveXp(xp) {
  player.xp += xp;
  if (player.xp >= player.level * 100) {
    player.xp -= player.level * 100;
    levelUp();
    messageElement.textContent += ` Player leveled up to ${player.level}!`;
  }
}

function levelUp() {
  player.level++;
  player.maxHp += 10;
  player.attack += 2;
  player.defense += 1;
 
}

function healPlayer() {
  player.hp = player.maxHp;
  playerHpElement.textContent = player.hp;
}

function spawnEnemy() {
  enemy = {
    hp: 100 + player.level * 20,
    maxHp: 100 + player.level * 20,
    attack: 20 + player.level * 2,
    defense: 5 + player.level,
    xp: 50 + player.level * 10
  };
  OnLoad()

}

function playerAttack() {
  const damage = Math.max(player.attack - enemy.defense, 0);
  applyDamage(enemy, damage);
  enemyHpElement.textContent = enemy.hp;
  messageElement.textContent = `Player dealt ${damage} damage to Enemy.`;

  if (enemy.hp <= 0) {
    messageElement.textContent = "Player has defeated the Enemy!";
    giveXp(enemy.xp);
    healPlayer();
    spawnEnemy();
    messageElement.textContent = "A new enemy has appeared!";
    attackButton.disabled = false;
  } else {
    setTimeout(enemyAttack, 500);
    attackButton.disabled = true;
  }
}

function enemyAttack() {
  const damage = Math.max(enemy.attack - player.defense, 0);
  applyDamage(player, damage);
  playerHpElement.textContent = player.hp;
  messageElement.textContent = `Enemy dealt ${damage} damage to Player.`;

  if (player.hp === 0) {
    messageElement.textContent = "Enemy has defeated the Player!";
  } else {
    attackButton.disabled = false;
  }
}

function OnLoad() {
  playerHpElement.textContent = player.hp;
  playerAttackElement.textContent = player.attack;
  playerDefenseElement.textContent = player.defense;
  playerXpElement.textContent = player.xp;
  playerLvLElement.textContent = player.level;
  enemyHpElement.textContent = enemy.hp;
  enemyAttackElement.textContent = enemy.attack;
  enemyDefenseElement.textContent = enemy.defense;
  enemyXpElement.textContent = enemy.xp;
}

attackButton.addEventListener('click', playerAttack);
document.addEventListener("DOMContentLoaded", function() {
  OnLoad();
});

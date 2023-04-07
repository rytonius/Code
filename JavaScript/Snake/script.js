const canvas = document.getElementById('game-board');
const ctx = canvas.getContext('2d');

const gridSize = 20;
const snakeSpeed = 100;

let snake = [{ x: 200, y: 200 }];
let food = { x: 300, y: 300 };
let direction = { x: 0, y: -gridSize };

function gameLoop() {
  setTimeout(() => {
    moveSnake();
    if (checkCollision()) {
      resetGame();
      return;
    }
    drawBoard();
    drawSnake();
    drawFood();
    gameLoop();
  }, snakeSpeed);
}

function moveSnake() {
  const head = { x: snake[0].x + direction.x, y: snake[0].y + direction.y };
  snake.unshift(head);

  if (head.x === food.x && head.y === food.y) {
    generateFood();
  } else {
    snake.pop();
  }
}

function checkCollision() {
  const head = snake[0];
  
  // Check collision with game borders
  if (head.x < 0 || head.y < 0 || head.x >= canvas.width || head.y >= canvas.height) {
    return true;
  }

  // Check collision with snake's body
  for (let i = 1; i < snake.length; i++) {
    if (head.x === snake[i].x && head.y === snake[i].y) {
      return true;
    }
  }

  return false;
}

function generateFood() {
  food.x = Math.floor(Math.random() * (canvas.width / gridSize)) * gridSize;
  food.y = Math.floor(Math.random() * (canvas.height / gridSize)) * gridSize;
}

function drawBoard() {
  ctx.fillStyle = '#000';
  ctx.fillRect(0, 0, canvas.width, canvas.height);
}

function drawSnake() {
  ctx.fillStyle = '#0f0';
  for (const segment of snake) {
    ctx.fillRect(segment.x, segment.y, gridSize, gridSize);
  }
}

function drawFood() {
  ctx.fillStyle = '#f00';
  ctx.fillRect(food.x, food.y, gridSize, gridSize);
}

function changeDirection(event) {
  switch (event.key) {
    case 'ArrowUp':
      if (direction.y === 0) {
        direction = { x: 0, y: -gridSize };
      }
      break;
    case 'ArrowDown':
      if (direction.y === 0) {
        direction = { x: 0, y: gridSize };
      }
      break;
    case 'ArrowLeft':
      if (direction.x === 0) {
        direction = { x: -gridSize, y: 0 };
      }
      break;
    case 'ArrowRight':
      if (direction.x === 0) {
        direction = { x: gridSize, y: 0 };
      }
      break;
  }
}

function resetGame() {
  snake = [{ x: 200, y: 200 }];
  food = { x: 300, y: 300 };
  direction = { x: 0, y: -gridSize };
  setTimeout(() => gameLoop(), 1000);
}

document.addEventListener('keydown', changeDirection);
gameLoop();

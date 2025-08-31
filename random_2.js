// 기본적으로 Math.random을 사용함

// 0 이상 1 미만의 실수
console.log(Math.random());

// 1 ~ 100까지 정수
console.log(Math.floor(Math.random() * 100) + 1);

// 특정 범위(0 ~ 50)
function getRandom(min, max) {
  return Math.floor(Math.random() * (max - min + 1) + min);
}

console.log(getRandom(0, 50));

//Problem 6

function InsideCircleChecker(pointX, pointY){
    var circleCenterX = 0.0;
    var circleCenterY = 0.0;
    var circleRad = 5;
    var isInside;
    isInside = (((pointX - circleCenterX) * (pointX - circleCenterX)) +
    ((pointY - circleCenterY) * (pointY - circleCenterY)) <= (circleRad * circleRad));
    return isInside;
}

console.log('Problem 6:');
console.log('These coordinates are inside the circle =', InsideCircleChecker(0, 1));
console.log('These coordinates are inside the circle = ', InsideCircleChecker(-5, 0));
console.log('These coordinates are inside the circle = ', InsideCircleChecker(-4, 5));
console.log('These coordinates are inside the circle = ', InsideCircleChecker(1.5, -3));
console.log('These coordinates are inside the circle = ', InsideCircleChecker(-4, -3.5));
console.log('These coordinates are inside the circle = ', InsideCircleChecker(100, -30));
console.log('These coordinates are inside the circle = ', InsideCircleChecker(0, 0));
console.log('These coordinates are inside the circle = ', InsideCircleChecker(0.2, -0.8));
console.log('These coordinates are inside the circle = ', InsideCircleChecker(0.9, -4.93));
console.log('These coordinates are inside the circle = ', InsideCircleChecker(2, 2.655));
console.log('\n');

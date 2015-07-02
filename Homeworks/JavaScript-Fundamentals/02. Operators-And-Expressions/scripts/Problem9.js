//Problem 9

function InsideCircleAndOutOfRectangleChecker(pointX, pointY) {
    var circleCenterX = 1.0;
    var circleCenterY = 1.0;
    var circleRad = 3;
    var isInside;
    var isOutside;
    isInside = (((pointX - circleCenterX) * (pointX - circleCenterX)) +
    ((pointY - circleCenterY) * (pointY - circleCenterY)) <= (circleRad * circleRad));
    isOutside = (((pointX < -1) || (pointX > 5)) || ((pointY < -1) || (pointY > 1)));
    if (isInside && isOutside) {
        console.log('yes');
    }
    else {
        console.log('no');
    }
}

console.log('Problem 9:');
console.log('These coordinates are within the circle and out of the rectangle :');
InsideCircleAndOutOfRectangleChecker(1, 2);
console.log('These coordinates are within the circle and out of the rectangle :');
InsideCircleAndOutOfRectangleChecker(2.5, 2);
console.log('These coordinates are within the circle and out of the rectangle :');
InsideCircleAndOutOfRectangleChecker(0, 1);
console.log('These coordinates are within the circle and out of the rectangle :');
InsideCircleAndOutOfRectangleChecker(2.5, 1);
console.log('These coordinates are within the circle and out of the rectangle :');
InsideCircleAndOutOfRectangleChecker(2, 0);
console.log('These coordinates are within the circle and out of the rectangle :');
InsideCircleAndOutOfRectangleChecker(4, 0);
console.log('These coordinates are within the circle and out of the rectangle :');
InsideCircleAndOutOfRectangleChecker(2.5, 1.5);
console.log('These coordinates are within the circle and out of the rectangle :');
InsideCircleAndOutOfRectangleChecker(2, 1.5);
console.log('These coordinates are within the circle and out of the rectangle :');
InsideCircleAndOutOfRectangleChecker(1, 2.5);
console.log('These coordinates are within the circle and out of the rectangle :');
InsideCircleAndOutOfRectangleChecker(-100, -100);
console.log('\n');

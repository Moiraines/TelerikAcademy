//Problem 1

var point1 = buildPoint(1, 2),
    point2 = buildPoint(5, 1),
    point3 = buildPoint(0, 0),
    point4 = buildPoint(6, 2),
    point5 = buildPoint(3, 5),
    point6 = buildPoint(2, 1),
    line1 = buildLine(point1, point2),
    line2 = buildLine(point3, point4),
    line3 = buildLine(point5, point6);

function buildPoint(X, Y) {
    return {
        X: X,
        Y: Y
    }
}

function buildLine(startPoint, endPoint) {
    return {
        Point1: startPoint,
        Point2: endPoint,
        Length: Distance(startPoint, endPoint)
    }
}

function Distance (p1, p2){
    var distance = Math.sqrt((p2.X - p1.X) * (p2.X - p1.X) +
        (p2.Y - p1.Y) * (p2.Y - p1.Y));
    return distance.toFixed(2) * 1;
}

function validTriangle (line1, line2, line3){
    if (line1.Length < line2.Length + line3.Length && line2.Length < line1.Length + line3.Length && line3.Length < line1.Length + line2.Length){
        return true;
    }
    else{
        return false;
    }
}


console.log('Problem 1:');
console.log('The distance between point1 and point2 is:' + (line1.Length ? line1.Length : 'none'));
console.log('The distance between point3 and point4 is:' + (line2.Length ? line2.Length : 'none'));
console.log('The distance between point5 and point6 is:' + (line3.Length ? line3.Length : 'none'));
console.log('Can we build a valid triangle from line1, line2 and line3? : ' + validTriangle(line1, line2, line3));
console.log('\n');


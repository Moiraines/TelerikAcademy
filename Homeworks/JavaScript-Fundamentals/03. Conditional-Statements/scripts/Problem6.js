//Problem 6
function QuadraticEquation(a, b, c){
    var x1;
    var x2;
    var dis = b * b -(4 * a * c);
    if (dis > 0) {
        x1 = (-b - Math.sqrt(dis)) / (2 * a);
        x2 = (-b + Math.sqrt(dis)) / (2 * a);
        console.log('x1=' + x1 + '; x2=' + x2);
    }
    else if( dis < 0) {
        console.log('no real roots');
    }
    else {
        x1 = x2 = -(b / (2 * a));
        console.log('x1=x2=' + x1);
    }

}
console.log('Problem 6:');
console.log('Roots:');
QuadraticEquation(2, 5, -3);
QuadraticEquation(-1, 3, 0);
QuadraticEquation(-0.5, 4, -8);
QuadraticEquation(5, 2, 8);
console.log('\n');

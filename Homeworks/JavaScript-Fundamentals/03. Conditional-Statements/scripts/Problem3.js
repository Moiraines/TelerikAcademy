//Problem 3
function BiggestNumber(a, b, c){
    if (a > b) {
        if ( c > a) {
            console.log(c);
        }
        else {
            console.log(a);
        }
    }
    else {
        if ( c > b) {
            console.log(c);
        }
        else {
            console.log(b);
        }
    }

}
console.log('Problem 3:');
console.log('Biggest:');
BiggestNumber(5, 2, 2);
BiggestNumber(-2, -2, 1);
BiggestNumber(-2, 4, 3);
BiggestNumber(0, -2.5, 5);
BiggestNumber(-0.1, -0.5, -1.1);
console.log('\n');

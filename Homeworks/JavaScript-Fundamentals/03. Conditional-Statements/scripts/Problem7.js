//Problem 7
function BiggestNumber(a, b, c, d, e){
    if (a > b && a > c && a > d && a > e) {
        console.log(a);
    }
    else {
        if ( b > c && b > d && b > e) {
            console.log(b);
        }
        else {
            if ( c > d && c > e) {
                console.log(c);
            }
            else {
                if (d > e) {
                    console.log(d);
                }
                else {
                    console.log(e);
                }
            }
        }
    }

}
console.log('Problem 7:');
console.log('Biggest:');
BiggestNumber(5, 2, 2, 4, 1);
BiggestNumber(-2, -22, 1, 0, 0);
BiggestNumber(-2, 4, 3, 2, 0);
BiggestNumber(0, -2.5, 0, 5, 5);
BiggestNumber(-3, -0.5, -1.1, -2, -0.1);
console.log('\n');

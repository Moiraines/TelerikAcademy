//Problem 1
function SmallerComesFirst(a, b){
    if (a > b) {
        console.log(b + ' ' + a);
    }
    else {
        console.log(a + ' ' + b);
    }
}
console.log('Problem 1:');
SmallerComesFirst(5, 2);
SmallerComesFirst(3, 4);
SmallerComesFirst(5.5, 4.5);
console.log('\n');

//Problem 2
function DivideChecker(number){
    if ((number % 7 === 0) && (number % 5 === 0)) {
        console.log('true');
    }
    else {
        console.log('false');
    }
}
console.log('Problem 2:');
DivideChecker(3);
DivideChecker(0);
DivideChecker(5);
DivideChecker(7);
DivideChecker(35);
DivideChecker(140);
console.log('\n');
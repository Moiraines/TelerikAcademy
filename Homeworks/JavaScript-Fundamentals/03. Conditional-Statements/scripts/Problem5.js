//Problem 5
function DigitAsWord(input){
    switch (input) {
        case 0: console.log("zero");
            break;
        case 1: console.log("one");
            break;
        case 2: console.log("two");
            break;
        case 3: console.log("three");
            break;
        case 4: console.log("four");
            break;
        case 5: console.log("five");
            break;
        case 6: console.log("six");
            break;
        case 7: console.log("seven");
            break;
        case 8: console.log("eight");
            break;
        case 9: console.log("nine");
            break;
        default: console.log("not a digit");
            break;
    }
}
console.log('Problem 5:');
console.log('Results:');
DigitAsWord(2);
DigitAsWord(1);
DigitAsWord(0);
DigitAsWord(5);
DigitAsWord(-0.1);
DigitAsWord('hi');
DigitAsWord(9);
DigitAsWord(10);
console.log('\n');


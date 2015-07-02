//Problem 1
var stringNumber,
    digit;


function LastDigit(number){
    stringNumber = number.toString();
    digit = stringNumber[stringNumber.length-1];
    switch (digit){
        case '0': return 'zero';
            break;
        case 1: return 'one';
            break;
        case '2': return 'two';
            break;
        case '3': return 'three';
            break;
        case '4': return 'four';
            break;
        case '5': return 'five';
            break;
        case '6': return 'six';
            break;
        case '7': return 'seven';
            break;
        case '8': return 'eight';
            break;
        case '9': return 'nine';
            break;
        default:
            break;
    }
}



console.log('Problem 1:');
console.log('The last digit of 512 is: ' + LastDigit(512));
console.log('The last digit of 1024 is: ' + LastDigit(1024));
console.log('The last digit of 12309 is: ' + LastDigit(12309));
console.log('\n');


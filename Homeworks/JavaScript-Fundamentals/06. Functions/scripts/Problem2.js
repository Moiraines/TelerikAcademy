//Problem 2
var stringNumber,
    reverseString = '',
    reverseNumber,
    i;


function ReverseNumber(number){
    stringNumber = number.toString();
   for (i = stringNumber.length - 1; i >= 0; i -= 1){
        reverseString += stringNumber[i];
   }
    reverseNumber = reverseString * 1;
    reverseString = '';
    return reverseNumber;
}

console.log('Problem 2:');
console.log('The reverse number of 256 is: ' + ReverseNumber(256));
console.log('The last digit of 123.45 is: ' + ReverseNumber(123.45));
console.log('\n');

//Problem 4

function ThirdDigitChecker(number){
    var thirdDigit7;
    thirdDigit7 = Math.floor(number / 100) % 10 == 7;
    return thirdDigit7;
}

console.log('Problem 4:');
console.log('The third digit from right-to left is 7? :', ThirdDigitChecker(5));
console.log('The third digit from right-to left is 7? :', ThirdDigitChecker(701));
console.log('The third digit from right-to left is 7? :', ThirdDigitChecker(1732));
console.log('The third digit from right-to left is 7? :', ThirdDigitChecker(9703));
console.log('The third digit from right-to left is 7? :', ThirdDigitChecker(877));
console.log('The third digit from right-to left is 7? :', ThirdDigitChecker(777877));
console.log('The third digit from right-to left is 7? :', ThirdDigitChecker(9999799));
console.log('\n');

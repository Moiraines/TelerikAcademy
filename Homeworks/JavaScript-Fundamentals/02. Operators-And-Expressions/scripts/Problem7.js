//Problem 7

function PrimeDigitChecker(number){

    if (number <= 1) {
        return false;
    }
    else {
        for ( var i = 2; i < number; i++) {
            if (number % i === 0) {
                return false;
            }
        }
        return true;
    }
}

console.log('Problem 7:');
console.log('This is a prime number :', PrimeDigitChecker(1));
console.log('This is a prime number :', PrimeDigitChecker(2));
console.log('This is a prime number :', PrimeDigitChecker(3));
console.log('This is a prime number :', PrimeDigitChecker(4));
console.log('This is a prime number :', PrimeDigitChecker(9));
console.log('This is a prime number :', PrimeDigitChecker(37));
console.log('This is a prime number :', PrimeDigitChecker(97));
console.log('This is a prime number :', PrimeDigitChecker(51));
console.log('This is a prime number :', PrimeDigitChecker(-3));
console.log('This is a prime number :', PrimeDigitChecker(0));
console.log('\n');
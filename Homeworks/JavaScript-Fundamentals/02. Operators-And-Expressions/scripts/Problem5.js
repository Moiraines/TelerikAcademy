//Problem 5

function ThirdBitChecker(number){
    var mask = 1 << 3;
    var nAndMask = number & mask;
    var bit;
    bit = nAndMask >> 3;
    return bit;
}

console.log('Problem 5:');
console.log('The third bit of the number is :', ThirdBitChecker(5));
console.log('The third bit of the number is :', ThirdBitChecker(8));
console.log('The third bit of the number is :', ThirdBitChecker(0));
console.log('The third bit of the number is :', ThirdBitChecker(15));
console.log('The third bit of the number is :', ThirdBitChecker(5343));
console.log('The third bit of the number is :', ThirdBitChecker(62241));
console.log('\n');
/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(start, end) {
	var i,
		divisor,
		maxDivisor,
		result = [],
		isPrime;

	start = start * 1;
	end = end * 1;
	if(arguments.length < 2){
		throw Error;
	}

	for (i = start; i <= end; i+=1) {
		isPrime = true;
		maxDivisor = Math.sqrt(i);
		if(i > 1 ){
			for (divisor = 2; divisor <= maxDivisor; divisor+=1) {
				if(!(i % divisor)) {
					isPrime = false;
					break;
				}
			}

			if (isPrime) {
				result.push(i);
			}
		}
	}

	return result;
}
console.log(findPrimes('0', '5'));
module.exports = findPrimes;

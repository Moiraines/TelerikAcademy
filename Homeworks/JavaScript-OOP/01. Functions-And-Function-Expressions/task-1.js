/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(input) {

	var i,
		sum = 0,
		len = input.length;

	if (!input.length){
		return null;
	}
	if (input === undefined){
		throw Error;
	}

	for (i = 0; i < len; i+=1) {
		if (parseInt(input[i])){
			sum += parseInt(input[i]);
		}
		else {
			throw Error;
		}
	}
	return sum;
}

module.exports = sum;
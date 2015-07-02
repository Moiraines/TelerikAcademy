//Problem 1

function reversed(input){
    var result = '',
        i,
        len = input.length;

    for (i = len - 1; i >= 0; i-=1){
        result += input[i];
    }

    return result;
}

console.log('Problem 1: ');
console.log('Reverse of sample is: ' + reversed('sample'));
console.log('\n');

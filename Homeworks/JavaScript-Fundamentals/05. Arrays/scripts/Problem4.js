//Problem 4

var arr = [3, 2, 3, 4, 2, 2, 4],
    result = [],
    maxSequence = 0,
    sequenceStart = 0,
    counter = 1;


function MaximalSequence(array){
    for (var i = 0; i < array.length; i += 1) {
        if (i > 0){
            if (array[i] < array[i-1]){

                counter = 1;
            }
            else {
                counter += 1;
            }

            if (counter > maxSequence){
                maxSequence = counter;
                sequenceStart = i + 1 - maxSequence;
            }
        }

    }

    for ( i = sequenceStart; i < sequenceStart + maxSequence; i += 1){
        result.push(array[i]);
    }

    console.log(result.join(', '));
}


console.log('Problem 4:');
console.log('Maximal increasing sequence of elements in arr = [3, 2, 3, 4, 2, 2, 4] is:');
MaximalSequence(arr);
console.log('\n');

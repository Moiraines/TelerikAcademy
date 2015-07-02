//Problem 6

var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    maxCount = 0,
    counter = 1,
    mostFrequentNumber;

arr.sort();

function MostFrequentNumber(array){
    mostFrequentNumber = array[0];
    for (var i = 0; i < array.length; i += 1){
        if (array[i] === array[i - 1]){
            counter += 1;
        }
        else{
            counter = 1;
        }

        if (maxCount < counter){
            maxCount = counter;
            mostFrequentNumber = array[i];
        }
    }

    console.log(mostFrequentNumber + ' (' + maxCount + ' times)');
}


console.log('Problem 6:');
console.log('The most frequent number in arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3] is:');
MostFrequentNumber(arr);
console.log('\n');

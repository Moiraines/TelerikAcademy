//Problem 5

var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    sortedArr = [],
    smallestEl = Number.MAX_VALUE,
    index;

//Selection sort with recursion
function SelectionSort(array){
    for (var i = 0; i < array.length; i += 1){
        if (array.length === 1){
            sortedArr.push(array[i]);
            return;
        }

        if (array[i] < smallestEl){
            smallestEl = array[i];
        }
    }

    sortedArr.push(smallestEl);
    index = array.indexOf(smallestEl);
    array.splice(index, 1);

    smallestEl = Number.MAX_VALUE;
    SelectionSort(array);
}

function PrintSortedArray(array){
    console.log(array.join(', '));
}


console.log('Problem 5:');
console.log('Selection sort used on arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3] :');
SelectionSort(arr);
PrintSortedArray(sortedArr);
console.log('\n');

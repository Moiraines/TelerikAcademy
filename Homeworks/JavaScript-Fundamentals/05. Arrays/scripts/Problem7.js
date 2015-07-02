//Problem 7

var sortedArr = [-5, 1, 2, 3, 4, 9, 16, 25, 49, 100, 108, 270, 500],
    min = 0,
    max = sortedArr.length - 1,
    mid;

//Binary search with recursion
function BinarySearch(array, keyElement, min, max){
    if (min > max){
        return 'there is not such element';
    }
    else{
        mid = Math.floor((min + max) / 2);
        if(keyElement === array[mid]){
            return mid;
        }
        else if(keyElement < array[mid]){
            return BinarySearch(array, keyElement, min, mid - 1);
        }
        else{
            return BinarySearch(array, keyElement, mid + 1, max);
        }
    }
}

console.log('Problem 7:');
console.log('Binary Search in arr = [-5, 1, 2, 3, 4, 9, 16, 25, 49, 100, 108, 270, 500] :');
console.log('Search index for element "4": ' + BinarySearch(sortedArr, 4, min, max));
console.log('Search index for element "108": ' + BinarySearch(sortedArr, 108, min, max));
console.log('Search index for element "25": ' + BinarySearch(sortedArr, 25, min, max));
console.log('\n');

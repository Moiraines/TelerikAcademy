//Problem 6
var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    isLarger;

function BiggerThanNeighbours(array, index){
    if  (index === 0 || index === array.length-1){
        return 'this element has not two neighbors. Please choose other element';
    }
    else{
        if ((array[index - 1] < array[index]) && (array[index + 1] < array[index])){
            isLarger = true;
        }
        else{
            isLarger = false;
        }
        return isLarger;
    }
}

console.log('Problem 6:');
console.log('The element at index 3 is larger than his neighbours: ' + BiggerThanNeighbours(arr, 3));
console.log('The element at index 5 is larger than his neighbours: ' + BiggerThanNeighbours(arr, 5));
console.log('The element at index 0 is larger than his neighbours: ' + BiggerThanNeighbours(arr, 0));
console.log('\n');



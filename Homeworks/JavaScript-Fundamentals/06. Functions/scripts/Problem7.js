//Problem 7
var arr1 = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    arr2 = [4, 1, 1, 4, 5, 7, 28, 100, 105, 200, 401, 600, 3000],
    isLarger,
    i;

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
function FirstIndexCheck(arr) {
    for (i = 0; i <= arr.length-1; i +=1) {
        if(BiggerThanNeighbours(arr, i) === true) {
            return i;
        }
    }
    return -1;
}


console.log('Problem 7:');
console.log('First element in arr larger then its neighbours is at index: ' + FirstIndexCheck(arr1));
console.log('First element in arr2 larger then its neighbours is at index: ' + FirstIndexCheck(arr2));
console.log('\n');




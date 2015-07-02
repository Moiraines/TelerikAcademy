//Problem 3
myarray = [3, 2, 5, 1];
function MinAndMax(arr){
var min = arr[0],
    max = arr[0];
    for (var i = 0; i <arr.length; i += 1){
        if (arr[i] <= min){
            min = arr[i];
        }
        if (arr[i] >= max){
            max = arr[i];
        }
    }
    console.log('Max = ' + max);
    console.log('Min = ' + min);
}



console.log('Problem 3:');
console.log('Examples with Sequence:\n3, 2, 5, 1');
MinAndMax(myarray);

console.log('You can change the values of myarray for other tests');
console.log('');
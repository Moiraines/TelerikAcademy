//Problem 5
var i,
    counter;

function NumberCount(number, array){
    counter = 0;
    for (i = 0; i < array.length; i += 1){
        if (array[i] === number){
            counter += 1;
        }
    }
    return counter;
}

function test(){
    var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
        number = 4;
    console.log('Problem 5:');
    console.log('The number ' + number + ' appears ' + NumberCount(number, arr) + ' times');
}

test();
console.log('\n');


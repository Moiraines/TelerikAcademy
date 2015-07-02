//Problem 2
function SmallerComesFirst(a, b, c){
    var counter = 0;
    var array = [a, b, c];
    for ( var i = 0; i < array.length; i++ ){
        if (array[i] < 0) {
            counter++;
        }
    }

    if (a === 0 || b === 0 || c === 0) {
        console.log(0);
    }
    else {
        if (counter % 2 === 0) {
            console.log('+');
        }
        else {
            console.log('-');
        }
    }

}
console.log('Problem 2:');
SmallerComesFirst(5, 2, 2);
SmallerComesFirst(-2, -2, 1);
SmallerComesFirst(-2, 4, 3);
SmallerComesFirst(0, -2.5, 4);
SmallerComesFirst(-1, -0.5, -5.1);
console.log('\n');

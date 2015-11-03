//Task 2
//Create a function that gets the value of <input type="text"> ands prints its value to the console
console.log(separatorLine);
console.log('\n' + 'Problem2');

(function getElementsByQuerySelector(input) {
    'use strict';
    var inputs = document.querySelectorAll(input),
        len = inputs.length,
        i;

    for (i = 0; i < len; i+=1) {
        console.log('Value: ');
        console.log(inputs[i].value);
    }
}('input[type=text]'));
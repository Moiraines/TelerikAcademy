//Task 1
var word = 'pesho';
var number = 5;
var floatNumber = 3.5;
var bool = true;
var opposite = false;
var undefiniedVariable;
var nothing = null;
var array = [5];
var PI = Math.PI;
var str = '1234';
var x = new Number(5);
var anotherStupidVariable = undefined;
var func = function () { alert('I am Function') };

console.log('Task 1:')
var massiveArray = [word, number, floatNumber, bool, opposite, undefiniedVariable, nothing, array, PI, str, anotherStupidVariable, func];
var counter = 0;
for (var i in massiveArray) {
    counter++;
    console.log(counter + '=' + massiveArray[i]);
}
console.log('\n');

//Task 2
var quote = '"How you doin\'?\", Joey said.';
console.log('Task 2:');
console.log(quote);
console.log('\n');

//Task 3
console.log('Task 3:');

for (i in massiveArray) {
    console.log('Variable = ' + (massiveArray[i]) + ', typeof(variable) = ' + typeof (massiveArray[i]));
}
console.log('\n');

//Task 4
console.log('Task 4:');
var a = null;
var b = undefined;
console.log('Variable = ' + (a) + ', typeof(variable) = ' + typeof (a));
console.log('Variable = ' + (b) + ', typeof(variable) = ' + typeof (b));

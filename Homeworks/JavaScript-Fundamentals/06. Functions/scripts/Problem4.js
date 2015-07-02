//Problem 4
var count;

function CountElements(element){
    count = document.getElementsByTagName(element).length;
    return count;
}

console.log('Problem 4:');
console.log('The count of divs elements on the web page is: ' + CountElements('div'));
console.log('\n');


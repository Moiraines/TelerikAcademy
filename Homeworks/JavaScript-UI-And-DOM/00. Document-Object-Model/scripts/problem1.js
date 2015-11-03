//Task 1
//Write a script that selects all the div nodes that are directly inside other div elements
// - Create a function using querySelectorAll()
// - Create a function using getElementsByTagName()
console.log('Problem1');

var separatorLine = '-'.repeat(100);

(function getElements(input) {
    'use strict';
    var divs = document.getElementsByTagName(input),
        i,
        len,
        childDiv,
        innerChildren;

    divs = [].slice.call(divs);
    len = divs.length;

    console.log('Nested div elements selected by "getElementsByTagName()";');

    for (i = 0; i < len; i+=1) {
        childDiv = divs[i];
        innerChildren = childDiv.children;
        for (var child in innerChildren)
        if (innerChildren[child].tagName === 'DIV') {
            console.log(innerChildren[child].innerHTML);
        }
    }
}('div'));

console.log(separatorLine);

(function getElementsByQuerySelector(input) {
    'use strict';
    var nestedDivs = document.querySelectorAll(input + ' > ' + input),
        len = nestedDivs.length,
        i;

    console.log('Nested div elements selected by "querySelectorAll()":');

    for (i = 0; i < len; i+=1) {
        console.log(nestedDivs[i].innerHTML)
    }
}('div'));
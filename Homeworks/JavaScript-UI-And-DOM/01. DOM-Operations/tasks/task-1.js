/* globals $ */

/* 
 Create a function that takes an id or DOM element and an array of contents
 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */

module.exports = function () {

    return function (element, contents) {
        var currentElement,
            fragment = document.createDocumentFragment(),
            div,
            i,
            len;

        if (typeof(element) !== 'string' && !(element instanceof HTMLElement)){
            throw Error ('element must be a string or HTML element');
        }

        if(!contents || contents.some(function(item){
                return (typeof(item) !== 'string' && typeof(item) !== 'number');
            })){
            throw Error ('Content must content number or string');
        }

        if (typeof (element) === 'string') {
            currentElement = document.getElementById(element);
        } else {
            currentElement = element;
        }

        while (currentElement.lastChild) {
            currentElement.removeChild(currentElement.lastChild);
        }

        for (i = 0, len = contents.length; i < len; i+=1) {
            div = document.createElement('div');
            div.innerHTML = contents[i];
            fragment.appendChild(div);
        }

        currentElement.appendChild(fragment);
    };
};